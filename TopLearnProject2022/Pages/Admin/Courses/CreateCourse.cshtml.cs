using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearnProject2022.Pages.Admin.Courses
{
    [PermissionChecker(11)]
    public class CreateCourseModel : PageModel
    {

        ICourseService _course;
        public CreateCourseModel(ICourseService course)
        {
            _course = course;
        }

        [BindProperty]
        public Course Course { get; set; }
        public void OnGet()
        {
            var group = _course.getGroupForManage();
            ViewData["Groups"] = new SelectList(group, "Value", "Text");

            //var subgroup = _course.getSubGroupForManage(int.Parse(group.First().Value));
            //ViewData["SubGroups"] = new SelectList(subgroup, "Value", "Text");
         
            var subgroup = _course.getSubGroupForManage( );
            ViewData["SubGroups"] = new SelectList(subgroup, "Value", "Text");

            var teacher = _course.getTeachers();
            ViewData["Teachers"] = new SelectList(teacher, "Value", "Text");

            var level = _course.getLevels();
            ViewData["Levels"] = new SelectList(level, "Value", "Text");

            var statue = _course.getStatues();
            ViewData["Statues"] = new SelectList(statue, "Value", "Text");


        }
        public IActionResult OnPost(IFormFile imgCourseUp, IFormFile demoUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _course.AddCourse(Course, imgCourseUp, demoUp);
            return RedirectToPage("Index");
        }
    }
}
