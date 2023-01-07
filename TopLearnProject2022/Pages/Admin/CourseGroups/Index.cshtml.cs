using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearnProject2022.Pages.Admin.CourseGroups
{
    [PermissionChecker(16)]
    public class IndexModel : PageModel
    {
        public ICourseService _course;
        public IndexModel (ICourseService c)
        {
            _course = c;
        }
        public List<CourseGroup> CourseGroups { get; set; }
       
        
        public void OnGet()
        {
            CourseGroups = _course.GetAllCourses();
        }
    }
}
