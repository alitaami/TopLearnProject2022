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
    [PermissionChecker(12)]
    public class EditCourseModel : PageModel
    {

        ICourseService _course;
        public EditCourseModel(ICourseService course)
        {
            _course = course;
        }

        [BindProperty]
        public Course Course { get; set; }
        public void OnGet(int id)
        {
            Course = _course.GetCourseById(id);
            var group = _course.getGroupForManage();
            ViewData["Groups"] = new SelectList(group, "Value", "Text", Course.GroupId);

            List<SelectListItem> subgroup = new List<SelectListItem>()
            {
                new SelectListItem(){Text="انتخاب کنید",Value=""}

            };
            subgroup.AddRange(_course.getSubGroupForManage());
            string selectedSubGroup = null;
            if (Course.SubGroup != null)
            {
                selectedSubGroup = Course.SubGroup.ToString(); 
            }
           
            ViewData["SubGroups"] = new SelectList(subgroup, "Value", "Text", selectedSubGroup);

            var teacher = _course.getTeachers();
            ViewData["Teachers"] = new SelectList(teacher, "Value", "Text", Course.TeacherId);

            var level = _course.getLevels();
            ViewData["Levels"] = new SelectList(level, "Value", "Text", Course.LevelId);

            var statue = _course.getStatues();
            ViewData["Statues"] = new SelectList(statue, "Value", "Text", Course.StatusId);
        }
        public IActionResult OnPost(IFormFile imgCourseUp, IFormFile demoUp)
        {
            if (!ModelState.IsValid)
                return Page();
            _course.UpdateCourse(Course, imgCourseUp, demoUp);
            return RedirectToPage("Index");
        }

    }



}
