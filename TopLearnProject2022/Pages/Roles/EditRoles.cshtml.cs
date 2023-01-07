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
    [PermissionChecker(8)]
    public class EditRolesModel : PageModel
    {
        private IPermissionService _permission;
        public EditRolesModel(IPermissionService per)
        {

            _permission = per;
        }
        [BindProperty]
        public TopLearn.DataLayer.Entities.User.Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permission.GetRoleById(id);
            ViewData["Permissions"] = _permission.GetPermissions();
            ViewData["SelectedPermissions"] = _permission.PermissionsRole(id);

        }
        public IActionResult OnPost(List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
                return Page();


            _permission.updateRole(Role);

            _permission.UpdatePermissionsRole(Role.RoleId, SelectedPermission);

            return RedirectToPage("Index");
        }
    }
}
