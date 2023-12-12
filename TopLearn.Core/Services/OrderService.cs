using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Toplearn.Core.Convertors;
using Toplearn.Core.Senders;
using TopLearn.Core.DTOs.Course;
using TopLearn.Core.DTOs.Order;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Course;
using TopLearn.DataLayer.Entities.Order;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services
{
    public class OrderService : IOrderService
    {
        IUserService _User;
        TopLearnContext _Context;
        public OrderService(IUserService userService, TopLearnContext context)
        {
            _User = userService;
            _Context = context;
        }

        public void AddDiscount(Discount discount)
        {

            _Context.Discounts.Add(discount);
            _Context.SaveChanges();

            var users = _Context.Users.ToList();
            foreach (var user in users)
            {
                SendMail.SendAsync(user.Email, "کدتخفیف", $"کد تخفیف {discount.DiscountCode} را می‌توانید تا تاریخ {discount.EndDate} استفاده کنید"); 
            }
        }

        public int AddOrder(string userName, int courseId)
        {
            int userId = _User.GetUserIdByUserName(userName);

            Order order = _Context.Orders.FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var Course = _Context.Courses.Find(courseId);

            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum = Course.CoursePrice,
                    //قابلیت ef core
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail
                        {
                            CourseId=courseId,
                            Count = 1,
                            Price =Course.CoursePrice
                        }

                    }
                };

                _Context.Orders.Add(order);
                _Context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _Context.OrderDetails.FirstOrDefault(d => d.OrderId == order.OrderId && d.CourseId == courseId);
                if (detail != null)
                {
                    detail.Count += 1;
                    _Context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {

                        Count = 1,
                        CourseId = courseId,
                        Price = Course.CoursePrice,
                        OrderId = order.OrderId

                    };
                    _Context.OrderDetails.Add(detail);

                }

                _Context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }
            return order.OrderId;
        }

        public void DeleteDiscount(int discountid)
        {
            Discount discount = GetdiscountbyId(discountid);
            discount.IsDelete = true;
            _Context.SaveChanges();
        }

        public void deleteOrder(string username, int detailid)
        {
            int userId = _User.GetUserIdByUserName(username);
            var detail = _Context.OrderDetails.Find(detailid);
            if (detail != null)
            {
                if (detail.Count > 1)
                {

                    _Context.OrderDetails.Add(new OrderDetail
                    {
                        Count = detail.Count - 1,
                        CourseId = detail.CourseId,
                        Price = detail.Price,
                        OrderId = detail.OrderId
                    });
                    _Context.OrderDetails.Remove(detail);
                }
                else
                {
                    _Context.OrderDetails.Remove(detail);
                }
                _Context.SaveChanges();
            }
        }


        public bool FinalyOrder(string username, int Orderid)
        {
            int userId = _User.GetUserIdByUserName(username);
            var order = _Context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Course)
                .FirstOrDefault(o => o.OrderId == Orderid && o.UserId == userId);
            if (order == null || order.IsFinaly)
            {
                return false;
            }
            if (_User.BalanceUserWallet(username) > order.OrderSum)
            {

                order.IsFinaly = true;

                _User.AddToWallet(new Wallet
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    IsPay = true,
                    Description = "فاکتور شماره #" + order.OrderId,
                    UserId = userId,
                    TypeId = 2
                });
                _Context.Orders.Update(order);
                foreach (var detail in order.OrderDetails)
                {
                    _Context.UserCourses.Add(new UserCourse
                    {
                        UserId = userId,
                        CourseId = detail.CourseId

                    });

                }
                _Context.SaveChanges();
                return true;

            }
            return false;
        }

        public List<ShowUserCoursesDto> GetCourses(string username)
        {
            int userid = _User.GetUserIdByUserName(username);

            var courses = _Context.UserCourses
                .Include(o => o.Course).Where(o => o.UserId == userid).Select(n => new ShowUserCoursesDto
                {
                    CourseId = n.CourseId,
                    ImageName = n.Course.CourseImageName,
                    Title = n.Course.CourseTitle
                }).ToList();

            return courses;
        }

        public Discount GetdiscountbyId(int id)
        {
            return _Context.Discounts.Find(id);
        }

        public List<Discount> GetDiscounts()
        {
            return _Context.Discounts.ToList();
        }

        public Order getOrderById(int orderid)
        {
            return _Context.Orders.Find(orderid);
        }

        public Order getOrderForUSerPanel(string username, int orderid)
        {
            int userid = _User.GetUserIdByUserName(username);
            return _Context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Course)
                .FirstOrDefault(o => o.UserId == userid && o.OrderId == orderid);
        }

        public List<Order> GetOrders(string username)
        {
            int userId = _User.GetUserIdByUserName(username);
            return _Context.Orders.Where(u => u.UserId == userId).ToList();
        }

        public bool ISExistCode(string code)
        {
            return _Context.Discounts.Where(d => d.IsDelete == false).Any(d => d.DiscountCode == code);
        }

        public bool IsUserHaveCourse(string username, int courseid)
        {
            int userid = _User.GetUserIdByUserName(username);
            return _Context.UserCourses.Any(c => c.CourseId == courseid && c.UserId == userid);
        }

        public void UpdateOrder(Order order)
        {
            _Context.Orders.Update(order);
            _Context.SaveChanges();
        }

        public void UpdatePriceOrder(int orderid)
        {

            var order = _Context.Orders.Find(orderid);
            order.OrderSum = _Context.OrderDetails.Where(d => d.OrderId == orderid).Sum(d => d.Price * d.Count);
            _Context.Orders.Update(order);
            _Context.SaveChanges();

        }

        public DiscountUseType UseDiscount(int orderId, string code)
        {
            //تبدیل زمان کنونی میلادی به شمسی
            DateTime miladi = DateTime.Now;
            var c = miladi.ToShamsi();
            DateTime d = DateTime.Parse(c);

            var order = getOrderById(orderId);
            var Discount = _Context.Discounts.SingleOrDefault(d => d.DiscountCode == code);

            if (Discount == null)
                return DiscountUseType.NotFound;

            if (Discount.StartDate != null && Discount.StartDate > d)
                return DiscountUseType.ExpireDate;

            if (Discount.EndDate != null && Discount.EndDate < d)
                return DiscountUseType.ExpireDate;

            if (Discount.UsableCount != null && Discount.UsableCount < 1)
                return DiscountUseType.Finished;


            if (_Context.UserDiscountCodes.Any(ud => ud.UserID == order.UserId && ud.DiscountId == Discount.DiscountId))
                return DiscountUseType.UserUsed;

            order.OrderSum = (order.OrderSum * (100 - Discount.Percent) / 100);


            UpdateOrder(order);
            if (Discount.UsableCount != null)
            {
                Discount.UsableCount -= 1;


            }

            _Context.Discounts.Update(Discount);
            _Context.UserDiscountCodes.Add(new DataLayer.Entities.User.UserDiscountCode()
            {
                UserID = order.UserId,
                DiscountId = Discount.DiscountId

            });
            _Context.SaveChanges();

            return DiscountUseType.Success;
        }


    }
}
