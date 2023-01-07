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
    [PermissionChecker(3)]
    public class CreateUserModel : PageModel
    {
        private IPermissionService _permission;
        private IUserService _user;
        public CreateUserModel(IPermissionService permission,IUserService user)
        {
            _permission = permission;
            _user = user;

        }
        //چون قرار است تغییراتی در مقدار پراپرتی اعمال شود باید بایندپراپرتی باشد
        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"] = _permission.GetRoles();
        }
        public IActionResult OnPost(List<int>SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            int userid = _user.AddUserFromAdmin(CreateUserViewModel);
            _permission.AddRolesToUser(SelectedRoles, userid);
            return Redirect("/Admin/Users");
        }
    }
}
