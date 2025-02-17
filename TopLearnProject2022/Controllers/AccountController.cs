﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Toplearn.Core.Convertors;
using Toplearn.Core.Security;
using Toplearn.Core.Senders;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generator;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearnProject2022.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;
        IViewRenderService _viewRender;
        public AccountController(IUserService userService, IViewRenderService viewRender)
        {
            _userService = userService;
            _viewRender = viewRender;
            
        }
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("Login")]
        public IActionResult Login()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login, string ReturnUrl = "/")
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.email = "ada";
                    return View(login);
                }

                var user = _userService.LoginUser(login);
                if (user != null)
                {
                    if (user.IsActive)
                    {
                        var Claims = new List<Claim>()
                        {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                        };
                        var identity = new ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        var properties = new AuthenticationProperties
                        {
                            IsPersistent = login.RememberMe
                        };
                        HttpContext.SignInAsync(principal, properties);

                        ViewBag.success = "sd";
                        if (ReturnUrl != "/")
                        {
                            return Redirect(ReturnUrl);
                        }
                        return View();
                    }
                    else
                    {
                        ViewBag.e = "sda";
                        return View();

                    }
                    //ModelState.AddModelError("Email", "حساب کاربری شما فعال نمیباشد");
                }
                else
                {

                    ViewBag.email = "sda";
                    return View(login);
                    //ModelState.AddModelError("Email", "کاربری با این مشخضات یافت نشد");

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            } 
        }
        [Route("Logout")]
        public IActionResult Logout()
        {
            try
            {
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return Redirect("/");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Register")]
        public IActionResult Register()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(register);
                }

                if (_userService.IsExistUserName(register.Username))
                {
                    ViewBag.User = "نام کاربری تکراریست";
                    return View(register);
                }

                if (_userService.IsExistEmail(FixedText.FixEmail(register.Email)))
                {
                    ViewBag.email = "ایمیل تکراریست";
                    return View(register);
                }

                if (register.RePassword != register.Password)
                {
                    ViewBag.pass = "رمز های عبور باهم تطابقت ندارند";
                    return View(register);
                }

                User user = new User()
                {
                    AcctiveCode = NameGenerator.GenerateUniqueCode(),
                    Email = register.Email,
                    Password = PasswordHelper.EncodePasswordMd5(register.Password),
                    UserName = register.Username,
                    RegistersDate = DateTime.Now,
                    UserAvatar = "defaultavatar.jpg",
                    IsActive = false,
                };

                _userService.AddUser(user);

                #region send activation email
                string body =  _viewRender.RenderToStringAsync("_ActiveEmail", user);
                await SendMail.SendAsync(user.Email, "فعالسازی", body);
                #endregion

                return Redirect("/Account/ActiveAccount");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        #region ActiveAccount
        public IActionResult ActiveAccount(string id)
        {
            try {
                ViewBag.IsActive = _userService.ActiveAccount(id);
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region forgotpassword
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword(ForgotPassword forgot)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(forgot);
                }
                string fixedemail = FixedText.FixEmail(forgot.Email);
                User user = _userService.GetUserByEmail(fixedemail);
                if (user == null)
                {
                    return View(forgot);
                    ViewBag.email = "s";
                }
                string bodyemail = _viewRender.RenderToStringAsync("_forgotpassword", user);
                SendMail.SendAsync(user.Email, "بازیابی کلمه عبور", bodyemail);
                ViewBag.s = "s s";
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

#region resetpassword
        [Route("ResetPassword")]
        public IActionResult ResetPassword(string id)
        {
            try
            {
                return View(new ResetPassword()
                {
                    ActiveCode = id
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("ResetPassword")]
        [HttpPost]
        public IActionResult ResetPassword(ResetPassword reset)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(reset);

                }
                User user = _userService.GetUserByActiveCode(reset.ActiveCode);
                if (user == null)
                {
                    return NotFound();
                }
                if (reset.RePassword != reset.Password)
                {
                    ViewBag.pass = "رمز های عبور باهم تطابقت ندارند";
                    //ModelState.AddModelError("Email", "");
                    return View(reset);

                }
                string newpass = PasswordHelper.EncodePasswordMd5(reset.Password);
                user.Password = newpass;
                _userService.UpdateUser(user);
                ViewBag.success = "sd";
                return Redirect("/Login");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }  
        }
        #endregion
    }
}
