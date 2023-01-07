using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.Services.Interfaces;

namespace TopLearnProject2022.ViewComponents
{
    public class CourseGroupComponent : ViewComponent
    {
        private ICourseService _course;
          public CourseGroupComponent(ICourseService course)
        {
            _course = course;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("CourseGroup",_course.GetAllCourses()));
             
        }
    }
}
