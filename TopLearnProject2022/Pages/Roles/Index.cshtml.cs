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
    [PermissionChecker(6)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permission;
        public IndexModel(IPermissionService permission )
        {
            _permission = permission;
       
        }
        public List<TopLearn.DataLayer.Entities.User.Role> RolesList { get; set; }
        public void OnGet()
        {
            RolesList = _permission.GetRoles();
        }
    }
}
