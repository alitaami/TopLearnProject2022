using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearnProject2022.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _course;
           private readonly IOrderService _order;
        IUserService _user;
        public CourseController(ICourseService course, IOrderService t, IUserService u)
        {
            _course = course;
            _order = t;
            _user = u;
        }
        public IActionResult Index(int pageid = 1, string filter = "", string getType = "all", string orderBy = "date", int startprice = 0, int endprice = 0, List<int> SelectedGroups = null)

        {
            
            return View(_course.GetCourse(pageid, filter, getType, orderBy, startprice, endprice, SelectedGroups, 12));
        }
        [Route("/Course/ShowCourse/{id}")]
        public IActionResult ShowCourse(int id)
        {
            try
            {
                Course c = new Course();
                var course = _course.GetCourseForShow(id);
                //course =  _course.GetcourseLevels(course.LevelId);
                //course = (Course)_course.GetcourseStatues(course.StatusId);

                if (course == null)
                {
                    return NotFound();
                }
                return View(course);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        public IActionResult BuyCourse(int id)
        {
            try
            {
                int orderId = _order.AddOrder(User.Identity.Name, id);
                return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("DownloadFile/{episodeId}")]
        public IActionResult DownloadFile(int episodeId)
        {
            try
            {
                var episode = _course.GetEpisodeById(episodeId);
                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles",
                    episode.EpisodeFileName);
                string fileName = episode.EpisodeFileName;
                if (episode.IsFree)
                {
                    byte[] file = System.IO.File.ReadAllBytes(filepath);
                    return File(file, "application/force-download", fileName);
                }

                if (User.Identity.IsAuthenticated)
                {
                    if (_order.IsUserHaveCourse(User.Identity.Name, episode.CourseId))
                    {
                        byte[] file = System.IO.File.ReadAllBytes(filepath);
                        return File(file, "application/force-download", fileName);
                    }
                }

                return Forbid();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult CreateComment(CourseComment C)
        {
            try
            {
                C.IsDelete = false;
                C.CreateDate = DateTime.Now;
                C.UserId = _user.GetUserIdByUserName(User.Identity.Name);
                _course.AddComment(C);

                return View("ShowComment", _course.GetCourseComments(C.CourseId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    public IActionResult ShowComment(int id,int pageId=1)
        {
            try
            {
                return View(_course.GetCourseComment(id, pageId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
