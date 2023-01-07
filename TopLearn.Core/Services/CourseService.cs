using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;
using TopLearn.DataLayer.Context;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using TopLearn.Core.Generator;
using System.IO;
using TopLearn.Core.DTOs.Course;
using Microsoft.EntityFrameworkCore;

namespace TopLearn.Core.Services
{
    public class CourseService : ICourseService
    {
        private TopLearnContext _context;
        public CourseService(TopLearnContext context)
        {
            _context = context;
        }

        public void AddComment(CourseComment Comment)
        {
            _context.CourseComments.Add(Comment);
            _context.SaveChanges();
        }

        public int AddCourse(Course course, IFormFile imgCourse, IFormFile CourseDemo)
        {
            course.CreateDate = DateTime.Now;
            course.CourseImageName = "no-photos.jpg";

            //TODO Check Image

            if (imgCourse != null)
            {
                course.CourseImageName = NameGenerator.GenerateUniqueCode() + Path.GetExtension(imgCourse.FileName);

                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/Image", course.CourseImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }

            }
            if (CourseDemo != null)
            {
                course.DemoFileName = NameGenerator.GenerateUniqueCode() + Path.GetExtension(CourseDemo.FileName);
                string DemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/Demoes", course.DemoFileName);
                using (var stream = new FileStream(DemoPath, FileMode.Create))
                {
                    CourseDemo.CopyTo(stream);
                }

            }
            _context.Add(course);
            _context.SaveChanges();
            return course.CourseId;
        }

        public int AddEpisode(CourseEpisode episode, IFormFile episodefile)
        {
            episode.EpisodeFileName = episodefile.FileName;

            string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", episode.EpisodeFileName);
            using (var stream = new FileStream(FilePath, FileMode.Create))
            {
                episodefile.CopyTo(stream);
            }

            _context.CourseEpisodes.Add(episode);
            _context.SaveChanges();
            return episode.EpisodeId;
        }

        public void AddGroup(CourseGroup c)
        {
              _context.CourseGroup.Add(c);
            _context.SaveChanges();
        }

        public bool CheckExistFile(string filename)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", filename);
            return File.Exists(path);
        }

        public int CountOfComments(int courseid)
        {
            return _context.CourseComments.Where(c => c.CourseId == courseid && !c.IsDelete).Count();
        }

        public void EditEpisode(CourseEpisode episode, IFormFile episodefile)
        {
            if (episodefile != null)
            {
                string DeleteFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", episode.EpisodeFileName);
                File.Delete(DeleteFilePath);

                episode.EpisodeFileName = episodefile.FileName;
                string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", episode.EpisodeFileName);
                using (var stream = new FileStream(FilePath, FileMode.Create))
                {
                    episodefile.CopyTo(stream);
                }

            }
            _context.Update(episode);
            _context.SaveChanges();

        }

        public List<CourseGroup> GetAllCourses()
        {
            return _context.CourseGroup.Include(c=>c.CourseGroups).ToList();
        }

        public CourseGroup GetById(int groupid)
        {
            return _context.CourseGroup.Find(groupid);
        }

        public Tuple<List<ShowCourseListViewModel>, int> GetCourse(int pageid = 1, string filter = "", string getType = "all", string orderBy = "date", int startprice = 0, int endprice = 0, List<int> SelectedGroups = null, int take = 0)
        {
            if (take == 0)
            {
                take = 8;
            }
            IQueryable<Course> result = _context.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.CourseTitle.Contains(filter));

            }
            switch (getType)
            {
                case "all":
                    break;
                case "bought":
                    {
                        result = result.Where(c => c.CoursePrice != 0);
                        break;
                    }
                case "free":
                    {
                        result = result.Where(c => c.CoursePrice == 0);
                        break;
                    }

            }
            switch (orderBy)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "updatedate":
                    {
                        result = result.OrderByDescending(c => c.UpdateDate);
                        break;
                    }
            }
            if (startprice > 0)
            {
                result = result.Where(c => c.CoursePrice > startprice);
            }
            if (endprice > 0)
            {
                result = result.Where(c => c.CoursePrice < startprice);
            }
            if (SelectedGroups != null && SelectedGroups.Any())
            {
                foreach (var groupid in SelectedGroups)
                {
                    result = result.Where(r => r.GroupId == groupid || r.SubGroup == groupid);
                }

            }
            int Skip = (pageid - 1) * take;
            int pagecount = result.Include(C => C.CourseEpisodes).Select(c => new ShowCourseListViewModel()
            {
                CourseId = c.CourseId,
                ImageName = c.CourseImageName,
                Price = c.CoursePrice,
                Title = c.CourseTitle,
                //با این روش داده از نوع تایم اسپن را میتوان جمع زد
                //TotalTime =new TimeSpan( c.CourseEpisodes.Sum(ec => ec.EpisodeTime.Ticks))

            }).Count() / take;


            var query = result.Include(C => C.CourseEpisodes).Select(c => new ShowCourseListViewModel()
            {
                CourseId = c.CourseId,
                ImageName = c.CourseImageName,
                Price = c.CoursePrice,
                Title = c.CourseTitle,
                //با این روش داده از نوع تایم اسپن را میتوان جمع زد
                //TotalTime =new TimeSpan( c.CourseEpisodes.Sum(ec => ec.EpisodeTime.Ticks))

            }).Skip(Skip).Take(take).ToList();


            return Tuple.Create(query, pagecount);
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.Find(id);
        }

        public Tuple<List<CourseComment>, int> GetCourseComment(int courseId, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pagecount = _context.CourseComments.Where(c => !c.IsDelete && c.CourseId == courseId).Count() / take;
            if ((pagecount % 2) != 0)
            {
                pagecount++;
            }

            return Tuple.Create(_context.CourseComments.Include(c => c.User).Where(c => !c.IsDelete && c.CourseId == courseId)
                .Skip(skip).Take(take).OrderByDescending(c => c.CreateDate).ToList(), pagecount);

        }

        public List<CourseComment> GetCourseComments(int courseId)
        {
            return _context.CourseComments.Where(u => !u.IsDelete && u.CourseId == courseId).Include(u => u.Course).Include(u => u.User).ToList();
        }

        public List<ShowCourseForAdminViewModel> getCourseForAdmin()
        {
            return _context.Courses.Select(c => new ShowCourseForAdminViewModel()
            {
                CourseId = c.CourseId,
                Title = c.CourseTitle,
                ImageName = c.CourseImageName,
                EpisodeCount = c.CourseEpisodes.Count
            }).ToList();
        }

        public Course GetCourseForShow(int courseid)
        {


            return _context.Courses.Include(c => c.CourseEpisodes)
                   .Include(c => c.CourseStatus).Include(c => c.CourseLevel)
                   .Include(c => c.User).Include(c => c.UserCourses)
                   .FirstOrDefault(c => c.CourseId == courseid);
        }



        public CourseEpisode GetEpisodeById(int EpisodeId)
        {
            return _context.CourseEpisodes.Find(EpisodeId);
        }

        public List<SelectListItem> getGroupForManage()
        {
            return _context.CourseGroup.Where(c => c.ParentId == null).Select(g => new SelectListItem()
            {

                Text = g.GroupTitle,
                Value = g.GroupId.ToString()


            }).ToList();


        }

        public List<SelectListItem> getLevels()
        {
            return _context.CourseStatuses.Select(s => new SelectListItem()
            {
                Text = s.StatusTitle,
                Value = s.StatusId.ToString()
            }).ToList();
        }

        public List<CourseEpisode> getListOfepisodesOfCourse(int courseId)
        {
            return _context.CourseEpisodes.Where(e => e.CourseId == courseId).ToList();
        }

        public List<ShowCourseListViewModel> GetPopularCourses()
        {
            return _context.Courses.Include(c => c.OrderDetails)
                .Where(c => c.OrderDetails.Any())
                .OrderByDescending(d => d.OrderDetails.Count)
                .Take(8)
                .Select(c => new ShowCourseListViewModel()
                {
                    CourseId = c.CourseId,
                    ImageName = c.CourseImageName,
                    Price = c.CoursePrice,
                    Title = c.CourseTitle,
                   
                })
                .ToList();
        
    }

        public List<SelectListItem> getStatues()
        {
            return _context.CourseLevels.Select(l => new SelectListItem()
            {
                Text = l.LevelTitle,
                Value = l.LevelId.ToString()
            }).ToList();
        }


        //public List<SelectListItem> getSubGroupForManage(int groupId)
        //{
        //    return _context.CourseGroup.Where(c => c.ParentId == groupId).Select(g => new SelectListItem()
        //    {

        //        Text = g.GroupTitle,
        //        Value = g.GroupId.ToString()


        //    }).ToList();


        //}
        public List<SelectListItem> getSubGroupForManage( )
        {
            return _context.CourseGroup.Where(c => c.ParentId!=null).Select(g => new SelectListItem()
            {

                Text = g.GroupTitle,
                Value = g.GroupId.ToString()


            }).ToList();


        }
        public List<SelectListItem> getTeachers()
        {
            return _context.UserRoles.Where(u => u.RoleID == 4).Select(s => new SelectListItem()
            {
                Text = s.User.UserName,
                Value = s.UserID.ToString()

            }).ToList();
        }

        public void UpdateCourse(Course course, IFormFile imgCourse, IFormFile CourseDemo)
        {
            course.UpdateDate = DateTime.Now;
            if (imgCourse != null)
            {
                if (course.CourseImageName != null)
                {
                    string ImageDeletepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/Image", course.CourseImageName);
                    if (File.Exists(ImageDeletepath))
                    {
                        File.Delete(ImageDeletepath);
                    }
                }
                course.CourseImageName = NameGenerator.GenerateUniqueCode() + Path.GetExtension(imgCourse.FileName);

                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/Image", course.CourseImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }

            }
            if (CourseDemo != null)
            {
                if (course.DemoFileName != null)
                {
                    string demoDeletepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/Demoes", course.DemoFileName);
                    if (File.Exists(demoDeletepath))
                    {
                        File.Delete(demoDeletepath);
                    }
                }
                course.DemoFileName = NameGenerator.GenerateUniqueCode() + Path.GetExtension(CourseDemo.FileName);
                string DemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/Demoes", course.DemoFileName);
                using (var stream = new FileStream(DemoPath, FileMode.Create))
                {
                    CourseDemo.CopyTo(stream);
                }

            }
            _context.Update(course);
            _context.SaveChanges();
        }

        public void UpdateGroup(CourseGroup c)
        {
            _context.CourseGroup.Update(c);
            _context.SaveChanges();
        }
    }
}

