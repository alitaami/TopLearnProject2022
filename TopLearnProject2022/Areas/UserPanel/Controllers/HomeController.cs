using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toplearn.Core.Convertors;
using Toplearn.Core.Security;
using Toplearn.Core.Senders;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;

namespace TopLearnProject2022.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {

        private IUserService _user;
        IViewRenderService _viewRender;
        public HomeController(IUserService user, IViewRenderService viewRender)
        {
            _user = user;
            _viewRender = viewRender;
        }
        [Route("UserPanel/Index")]
        public IActionResult Index()
        {
            return View(_user.GetUserInformation(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_user.GetDataForEdit(User.Identity.Name));
        }
        [Route("UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(/*string activecode,*/ EditProfileViewModel profile)
        {
            if (!ModelState.IsValid)
                return View(profile);

            _user.EditProfile(User.Identity.Name, profile);

            ViewBag.s = true;

            var user = _user.GetInfoByUsername(User.Identity.Name);

            string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.Send(user.Email, "فعالسازی", body);


            ViewBag.exit = "s";
            return View(profile);

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //if (user.IsActive == false)
            //{
            //    return View( );






            //}

        }
        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();

        }
        [Route("UserPanel/ChangePassword")]
        [HttpPost]
        public IActionResult ChangePassword(ChangePAsswordViewModel change)
        {
            if (!ModelState.IsValid)
                return View(change);
          
            var user = User.Identity.Name;
            if (!_user.CompareOldPass(user, change.OldPassword))
            {
                ViewBag.e = "s";
                return View();

            }
            _user.ChangePassword(user, change.Password);
            ViewBag.s = "sd";
            return View();

        }
    }
}
