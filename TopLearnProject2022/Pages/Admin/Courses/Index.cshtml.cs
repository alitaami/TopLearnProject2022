using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;

namespace TopLearnProject2022.Pages.Admin.Courses
{
    [PermissionChecker(10)]
    public class IndexModel : PageModel
    {
        ICourseService _course;
        public IndexModel(ICourseService course)
        {
            _course = course;
        }
        public List<TopLearn.Core.DTOs.Course.ShowCourseForAdminViewModel> ListCourse { get; set; }
        public void OnGet()
        {
            var name = User.Identity.Name;
            ListCourse = _course.GetCourseForTeacher(name);
        }
    }
}
