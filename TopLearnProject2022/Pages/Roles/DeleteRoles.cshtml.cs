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
    [PermissionChecker(9)]
    public class DeleteRoleModel : PageModel
    {
        private IPermissionService _permission;
        public DeleteRoleModel(IPermissionService per)
        {

            _permission = per;
        }
        [BindProperty]
        public TopLearn.DataLayer.Entities.User.Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permission.GetRoleById(id);
        }
        public IActionResult OnPost()
        {
            _permission.deleterole(Role);
            return RedirectToPage("Index");
        }
    }
}
