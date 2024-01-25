using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Toplearn.Core.Security;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generator;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services
{
    public class UserService : IUserService
    {
        private TopLearnContext _Context;
        public UserService(TopLearnContext context)
        {
            _Context = context;
        }

        public bool ActiveAccount(string activecode)
        {
            var user = _Context.Users.SingleOrDefault(d => d.AcctiveCode == activecode);
            if (user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.AcctiveCode = TopLearn.Core.Generator.NameGenerator.GenerateUniqueCode();

            _Context.UserRoles.Add(new UserRole
            {
                RoleID = 3,
                UserID = user.UserId
            });

            _Context.SaveChanges();
            return true; 
        }

        public int AddToWallet(Wallet w)
        {
            _Context.Wallets.Add(w);
            _Context.SaveChanges();
            return w.WalletId;
        }

        public int AddUser(User user)
        {
            _Context.Add(user);
            _Context.SaveChanges();
            return user.UserId;
        }

        public int AddUserFromAdmin(CreateUserViewModel user)
        {
            User u = new User();
            u.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            u.AcctiveCode = NameGenerator.GenerateUniqueCode();
            u.Email = user.Email;
            u.IsActive = true;
            u.RegistersDate = DateTime.Now;
            u.UserName = user.Username;
            #region save avatar  
            if (user.UserAvatar != null)
            {
                string imagePath = "";


                u.UserAvatar = NameGenerator.GenerateUniqueCode() + Path.GetExtension(user.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", u.UserAvatar);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    user.UserAvatar.CopyTo(stream);
                }

            }
            #endregion
            return AddUser(u);
        }

        public int BalanceUserWallet(string username)
        {
            var userId = GetUserIdByUserName(username);
            var enter = _Context.Wallets
                .Where(w => w.UserId == userId && w.TypeId == 1 && w.IsPay)

                .Select(w => w.Amount).ToList();
            var exit = _Context.Wallets
               .Where(w => w.UserId == userId && w.TypeId == 2)
               .Select(w => w.Amount).ToList();
            return (enter.Sum() - exit.Sum());
        }

        public void ChangePassword(string username, string newpassword)
        {
            var user = GetInfoByUsername(username);
            var hashnewpassword = PasswordHelper.EncodePasswordMd5(newpassword);
            user.Password = hashnewpassword;
            UpdateUser(user);
        }

        public int ChargeWallet(string username, int amount, string description, bool ispay = false)
        {
            Wallet w = new Wallet();
            w.Amount = amount;
            w.CreateDate = DateTime.Now;
            w.Description = description;
            w.IsPay = ispay;
            w.TypeId = 1;
            w.UserId = GetUserIdByUserName(username);
            return AddToWallet(w);
        }

        public bool CheckUserRole(string username)
        {
            int userId = GetUserIdByUserName(username);

            var check = _Context.UserRoles
                .Any(r => r.UserID == userId && r.RoleID == 1 && r.RoleID == 2 && r.RoleID == 4);

            return check;
        }

        public bool CompareOldPass(string username, string oldpassword)
        {
            string hashold = PasswordHelper.EncodePasswordMd5(oldpassword);
            return _Context.Users.Any(u => u.UserName == username && u.Password == hashold);
        }

        public void DEleteUser(int userId)
        {
            User user = GetUserByUserId(userId);
            user.IsDelete = true;
            UpdateUser(user);
        }

        public void EditProfile(string username, EditProfileViewModel profile)
        {
            if (profile.UserAvatar != null)
            {
                string imagePath = "";
                if (profile.AvatarName != "Defult.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }

                profile.AvatarName = NameGenerator.GenerateUniqueCode() + Path.GetExtension(profile.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    profile.UserAvatar.CopyTo(stream);
                }

            }

            var User = GetInfoByUsername(username);


            User.Email = profile.Email;
            User.UserAvatar = profile.AvatarName;
            User.IsActive = false;
            UpdateUser(User);


        }

        public void EditUserForAdmin(EditUserViewModel editUser)
        {
            User user = GetUserByUserId(editUser.UserId);
            user.Email = editUser.Email;
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }

            if (editUser.UserAvatar != null)
            {
                //delete old image
                if (editUser.AvatatrName != "defaultavatar.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editUser.AvatatrName);
                    if (File.Exists(deletePath))
                    {
                        File.Delete(deletePath);
                    }
                }
                // Save new image
                string imagePath = "";
                user.UserAvatar = NameGenerator.GenerateUniqueCode() + Path.GetExtension(editUser.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    editUser.UserAvatar.CopyTo(stream);
                }
            }
            UpdateUser(user);
        }

        public EditProfileViewModel GetDataForEdit(string username)
        {
            return _Context.Users.Where(u => u.UserName == username).Select(u => new EditProfileViewModel
            {

                Email = u.Email,
                AvatarName = u.UserAvatar


            }).Single();
        }

        public USerForAdminViewModel GetDeletedUsers(int pageId = 1, string filteremail = "", string username = "")
        {
            //LazyLoad  بعد از فراخوانی در قسمت های بعدی سراغ دیتابیس میرود
            IQueryable<User> Result = _Context.Users.Where(u => u.IsDelete == true);


            if (!string.IsNullOrEmpty(filteremail))
            {
                Result = Result.Where(r => r.Email.Contains(filteremail));

            }
            if (!string.IsNullOrEmpty(username))
            {
                Result = Result.Where(r => r.UserName.Contains(username));
            }
            int take = 1;  //تعداد داده ها در هر صفحه
            int skip = (pageId - 1) * take;
            USerForAdminViewModel List = new USerForAdminViewModel();
            List.CurrentPage = pageId;
            List.PageCount = Result.Count() / take;
            List.Users = Result.OrderBy(u => u.RegistersDate).Skip(skip).Take(take).ToList();
            return List;
        }

        public User GetInfoByUsername(string username)
        {
            return _Context.Users.SingleOrDefault(u => u.UserName == username);
        }

        public User GetUserByActiveCode(string activecode)
        {
            return _Context.Users.SingleOrDefault(u => u.AcctiveCode == activecode);
        }

        public User GetUserByEmail(string email)
        {
            return _Context.Users.SingleOrDefault(u => u.Email == email);
        }

        public User GetUserByUserId(int userid)
        {
            return _Context.Users.Find(userid);
        }

        public EditUserViewModel GetUserforShowInEditMode(int userid)
        {
            return _Context.Users.Where(u => u.UserId == userid)
                 .Select(u => new EditUserViewModel()
                 {
                     UserId = u.UserId,
                     AvatatrName = u.UserAvatar,
                     Email = u.Email,
                     UserRoles = u.UserRoles.Select(r => r.RoleID).ToList(),
                     Username = u.UserName

                 }).Single();
        }

        public int GetUserIdByUserName(string username)
        {
            return _Context.Users.Single(u => u.UserName == username).UserId;
        }

        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetInfoByUsername(username);
            InformationUserViewModel info = new InformationUserViewModel();
            info.UserName = user.UserName;
            info.Email = user.Email;
            info.RegisterDate = user.RegistersDate;
            info.Wallet = BalanceUserWallet(username);
            return info;
        }

        public InformationUserViewModel GetUserInformation(int UserId)
        {
            var user = GetUserByUserId(UserId);
            InformationUserViewModel info = new InformationUserViewModel();
            info.UserName = user.UserName;
            info.Email = user.Email;
            info.RegisterDate = user.RegistersDate;
            info.Wallet = BalanceUserWallet(user.UserName);
            return info;
        }

        public USerForAdminViewModel GetUsers(int pageId = 1, string filteremail = "", string username = "")
        {
            //LazyLoad  بعد از فراخوانی در قسمت های بعدی سراغ دیتابیس میرود
            IQueryable<User> Result = _Context.Users;


            if (!string.IsNullOrEmpty(filteremail))
            {
                Result = Result.Where(r => r.Email.Contains(filteremail));

            }
            if (!string.IsNullOrEmpty(username))
            {
                Result = Result.Where(r => r.UserName.Contains(username));
            }
            int take = 10;  //تعداد داده ها در هر صفحه
            int skip = (pageId - 1) * take;
            USerForAdminViewModel List = new USerForAdminViewModel();
            List.CurrentPage = pageId;
            List.PageCount = Result.Count() / take;
            List.Users = Result.OrderBy(u => u.RegistersDate).Skip(skip).Take(take).ToList();
            return List;
        }

        public List<WalletViewModel> GetUserWallet(string username)
        {

            int userid = GetUserIdByUserName(username);

            return _Context.Wallets
                .Where(w => w.IsPay && w.UserId == userid)
                .Select(w => new WalletViewModel()
                {
                    Amount = w.Amount,
                    Type = w.TypeId,
                    DateTime = w.CreateDate,
                    Description = w.Description

                }).ToList();

        }

        public Wallet GetWalletByWalletId(int walletid)
        {
            return _Context.Wallets.Find(walletid);
        }



        public bool IsExistEmail(string email)
        {
            return _Context.Users.Any(a => a.Email == email);
        }

        public bool IsExistUserName(string username)
        {
            return _Context.Users.Any(a => a.UserName == username);
        }

        public bool IsValid(int userId)
        {
            return _Context.UserRoles.Any(u => u.UserID == userId && u.RoleID == 3);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashpassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedText.FixEmail(login.Email);

            return _Context.Users.SingleOrDefault(a => a.Email == email && a.Password == hashpassword);
        }

        public void UpdateUser(User user)
        {
            _Context.Update(user);
            _Context.SaveChanges();
        }

        public void UpdateWallet(Wallet w)
        {
            _Context.Wallets.Update(w);
            _Context.SaveChanges();
        }
    }
}
