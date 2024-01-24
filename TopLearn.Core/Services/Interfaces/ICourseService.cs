using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.Core.DTOs.Course;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Core.Services.Interfaces
{
    public interface ICourseService
    {
        #region Group
        List<DataLayer.Entities.Course.CourseGroup> GetAllCourses();
        List<SelectListItem> getGroupForManage();

        //  List<SelectListItem> getSubGroupForManage(int groupId);
        List<SelectListItem> getSubGroupForManage();
        List<SelectListItem> getTeachers();

        List<SelectListItem> getStatues();
        List<SelectListItem> getLevels();
        void AddGroup(CourseGroup c);
        void UpdateGroup(CourseGroup c);
        CourseGroup GetById(int groupid);
        #endregion
        #region Course
        List<DTOs.Course.ShowCourseForAdminViewModel> GetCourseForTeacher(string userName);
        int AddCourse(Course course, IFormFile imgCourse, IFormFile CourseDemo);
        Course GetCourseById(int id);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile CourseDemo);
        List<ShowCourseListViewModel> GetPopularCourses();
        #endregion
        #region Episode
        List<CourseEpisode> getListOfepisodesOfCourse(int courseId);
        bool CheckExistFile(string filename);
        int AddEpisode(CourseEpisode episode, IFormFile episodefile);
        CourseEpisode GetEpisodeById(int EpisodeId);
        void EditEpisode(CourseEpisode episode, IFormFile episodefile);

        Tuple<List<ShowCourseListViewModel>, int> GetCourse(int pageid = 1, string filter = "", string getType = "all",
             string orderBy = "date", int startprice = 0, int endprice = 0, List<int> SelectedGroups = null, int take = 0);
        Course GetCourseForShow(int courseid);

        #endregion
        #region comments
        void AddComment(CourseComment Comment);
        List<CourseComment> GetCourseComments(int courseId);

        int CountOfComments(int courseid);
        Tuple<List<CourseComment>, int> GetCourseComment(int courseId, int pageId = 1);
        #endregion

    }
}
