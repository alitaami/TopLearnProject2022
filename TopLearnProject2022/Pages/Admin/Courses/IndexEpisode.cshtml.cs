using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearnProject2022.Pages.Admin.Courses
{
    [PermissionChecker(15)]
    public class IndexEpisodeModel : PageModel
    {
        ICourseService _course;
        public IndexEpisodeModel(ICourseService c)
        {
            _course = c;
        }
        public List<CourseEpisode>  CourseEpisodes { get; set; }
        public void OnGet(int id)
        {
             ViewData["CourseId"] = id;
            CourseEpisodes = _course.getListOfepisodesOfCourse(id);
        }
    }
}
