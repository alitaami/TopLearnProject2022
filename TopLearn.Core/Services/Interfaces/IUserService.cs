using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services.Interfaces
{
   public interface IUserService
    {
        bool IsExistUserName(string username);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        bool ActiveAccount(string activecode);
        User GetUserByEmail( string email);
        User GetUserByUserId(int userid);
        User GetInfoByUsername(string username);
        User GetUserByActiveCode(string activecode);
        int GetUserIdByUserName(string username);
        bool CheckUserRole(string username);
        void UpdateUser(User user);
        InformationUserViewModel GetUserInformation(string username);
        InformationUserViewModel GetUserInformation(int UserId);
        EditProfileViewModel GetDataForEdit(string username);
        public void EditProfile(string username, EditProfileViewModel profile);
        bool CompareOldPass(string username, string oldpassword);
        void ChangePassword(string username, string newpassword);
        int BalanceUserWallet(string username);
        List<WalletViewModel> GetUserWallet(string username);
        int ChargeWallet(string username, int amount, string description, bool ispay = false);
        int AddToWallet(Wallet  w);
        Wallet GetWalletByWalletId(int walletid);
        void UpdateWallet(Wallet w);
        bool IsValid(int userId);

         #region admin panel

        USerForAdminViewModel GetUsers(int pageId = 1, string filteremail = "", string username = "");
        USerForAdminViewModel GetDeletedUsers(int pageId = 1, string filteremail = "", string username = "");

        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserforShowInEditMode(int userid);
        void EditUserForAdmin(EditUserViewModel editUser);
        void DEleteUser(int userId);
        #endregion
    }
}
