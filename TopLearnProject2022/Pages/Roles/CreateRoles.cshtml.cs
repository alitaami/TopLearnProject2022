using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;

namespace TopLearnProject2022.Pages.Roles
{
    [PermissionChecker(7)]
    public class CreateRolesModel : PageModel
    {

        private IPermissionService _permission;
        public CreateRolesModel(IPermissionService per)
        {

            _permission = per;
        }
        [BindProperty]
        public TopLearn.DataLayer.Entities.User.Role Role { get; set; }
        public void OnGet()
        {
            ViewData["Permissions"] = _permission.GetPermissions();
        }
        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();


            Role.IsDelete = false;
            int roleId = _permission.addrole(Role);
            //TODO Add permissions
            _permission.AddPermissionToRole(roleId, SelectedPermission);
            return RedirectToPage("Index");
        }
    }
}
