using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs.Course;
using TopLearn.Core.DTOs.Order;
using TopLearn.DataLayer.Entities.Course;
using TopLearn.DataLayer.Entities.Order;

namespace TopLearn.Core.Services.Interfaces
{
  public  interface IOrderService
    {
        int AddOrder(string userName, int courseId);
        void UpdatePriceOrder(int orderid);
        Order getOrderForUSerPanel(string username, int orderid);
        Order getOrderForUSerPanel(string username);
        Order getOrderById(int orderid); 
        bool FinalyOrder(string username,int Orderid);
        void deleteOrder(string username,int detailid);
        void UpdateOrder(Order order);
        List<Order> GetOrders(string username);
        List<ShowUserCoursesDto> GetCourses(string username);

        #region Discount 
        DiscountUseType UseDiscount(int orderId, string code);
        void AddDiscount(Discount discount);

        List<Discount> GetDiscounts();
        Discount GetdiscountbyId(int id);
        bool ISExistCode(string code);
        bool IsUserHaveCourse(string username,int courseid);
        void DeleteDiscount(int discountid);
        #endregion
    }
}
