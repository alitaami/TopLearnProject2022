using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;

namespace TopLearnProject2022.Pages.Admin.Users
{
    [PermissionChecker(5)]
    public class DeleteUserModel : PageModel
    {
        IUserService _user;
        public DeleteUserModel (IUserService user)
        {
            _user = user;
        }
      public  InformationUserViewModel InformationUserViewModel { get; set; }
        public void OnGet(int id)
        {
            // به این دلیل فرستادیم که در متد پست بتوان از آن استفاده کنیم
            ViewData["UserId"] = id;
            InformationUserViewModel = _user.GetUserInformation(id);
        }
        public IActionResult OnPost(int UserId)
        {
            _user.DEleteUser(UserId);
            return RedirectToPage("Index");
        }
    }
}
