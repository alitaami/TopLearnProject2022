using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearnProject2022.Pages.Admin.Courses
{
    [PermissionChecker(13)]
    public class CreateEpisodeModel : PageModel
    {
        ICourseService _course;
        public CreateEpisodeModel(ICourseService c)
        {
            _course = c; 
        }
        [BindProperty]
        public CourseEpisode CourseEpisode { get; set; }
        public void OnGet(int id)
        {
            //چنین نوشتیم که آیدی خودش تکرار شود و بخاطر ان در قسمت ویو هم
            // input hidden  asp-for=CourseId
            //نوشتیم تا آیدی در رفت و برگشت تکرار شود و کنترل آن ساده شود
            CourseEpisode = new CourseEpisode();
            CourseEpisode.CourseId = id;
        }

        public IActionResult OnPost(IFormFile fileEpisode)
        {
            if (!ModelState.IsValid || fileEpisode == null)
                return Page();
            if (_course.CheckExistFile(fileEpisode.FileName))
            {
                ViewData["IsExistFile"] = true;
                return Page();
            }
            _course.AddEpisode(CourseEpisode, fileEpisode);
            return Redirect("/Admin/Courses/IndexEpisode/" + CourseEpisode.CourseId);
        }
    }
}
