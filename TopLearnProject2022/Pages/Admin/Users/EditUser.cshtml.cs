using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;

namespace TopLearnProject2022.Pages.Admin.Users
{
    [PermissionChecker(4)]
    public class EditUserModel : PageModel
    {
        private IUserService _user;
        private IPermissionService _Per;
        public EditUserModel(IUserService user, IPermissionService per)
        {
            _user = user;
            _Per = per;

        }
        [BindProperty]
        public TopLearn.Core.DTOs.EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
            EditUserViewModel = _user.GetUserforShowInEditMode(id);
            ViewData["Roles"] = _Per.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _user.EditUserForAdmin(EditUserViewModel);

            _Per.EditRolesUser(SelectedRoles, EditUserViewModel.UserId);
            return RedirectToPage("Index");
        }

    }
}
