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
    [PermissionChecker(2)]
    public class IndexModel : PageModel
    {
        private IUserService _user;
        public IndexModel(IUserService user)
        {
            _user = user;

        }
        public USerForAdminViewModel USerForAdminViewModel { get; set; }
        public void OnGet(int pageid=1,string filteremail="",string username="" )
        {
            USerForAdminViewModel = _user.GetUsers(pageid,filteremail,username);
        }
   
    }
}
