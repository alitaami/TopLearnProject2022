using System;
using System.Collections.Generic;
using System.Text;

namespace TopLearn.Core.DTOs.Course
{
   public class ShowCourseForAdminViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public int EpisodeCount { get; set; }
    }
}
