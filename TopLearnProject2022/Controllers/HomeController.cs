using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.Services.Interfaces;
using TopLearnProject2022.Models;

namespace TopLearnProject2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService _user;
        ICourseService _course;
        public HomeController(ILogger<HomeController> logger, IUserService user, ICourseService course)
        {
            _logger = logger;
            _user = user;
            _course = course;
        }

        public IActionResult Index()
        {
            try
            {
                var popular = _course.GetPopularCourses();
                ViewBag.Popularcourse = popular;
                return View(_course.GetCourse().Item1);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult Privacy()
        {
            try {
                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id)
        {
            try {
                if (HttpContext.Request.Query["Status"] != "" &&
                    HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                    && HttpContext.Request.Query["Authority"] != "")
                {
                    string authority = HttpContext.Request.Query["Authority"];

                    var wallet = _user.GetWalletByWalletId(id);

                    var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                    var res = payment.Verification(authority).Result;
                    if (res.Status == 100)
                    {
                        ViewBag.code = res.RefId;
                        ViewBag.IsSuccess = true;
                        wallet.IsPay = true;
                        _user.UpdateWallet(wallet);
                    }
                }

                return View();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetSubGroups(int id)
        {
            try
            {
                List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text="انتخاب کنید",Value=""}

            };
                //var subgroup = _course.getSubGroupForManage(id);
                list.AddRange(_course.getSubGroupForManage());
                return Json(new SelectList(list, "Value", "Text"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //ck editor
        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            try {
                if (upload.Length <= 0) return null;

                var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();

                var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/MyImages",
                    fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    upload.CopyTo(stream);
                }
                var url = $"{"/MyImages/"}{fileName}";

                return Json(new { uploaded = true, url });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
