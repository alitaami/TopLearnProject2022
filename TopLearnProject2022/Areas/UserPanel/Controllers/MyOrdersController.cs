using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.DTOs.Order;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Order;
using TopLearnProject2022.Controllers;

namespace TopLearnProject2022.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class MyOrdersController : Controller
    {



        private IOrderService _orderService;

        public MyOrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View(_orderService.GetOrders(User.Identity.Name));
        }
        public IActionResult DeleteOrder(int id)
        {
            _orderService.deleteOrder(User.Identity.Name, id);
            
            return Redirect("/UserPanel/MyOrders");

        }
         
        public IActionResult ShowOrder(int id, bool finaly = false,string type="")
        {
            var order = _orderService.getOrderForUSerPanel(User.Identity.Name, id);

            if (order == null)
            {
                return NotFound();
            }
            ViewBag.finaly = finaly;
            ViewBag.type = type;
            return View(order);
        }
        public IActionResult ShowOrder2(bool finaly = false, string type = "")
        {
            var order = _orderService.getOrderForUSerPanel(User.Identity.Name);

            if (order == null)
            {
                return NotFound("سبد خریدی برای این کاربر وجود ندارد");
            //    ViewBag.NoOrder = "سبد خریدی برای این کاربر وجود ندارد";
            //    return RedirectToAction("Index", "Home", new { area = "" });
            }

            ViewBag.finaly = finaly;
            ViewBag.type = type;
            return View(order);
        }

        public IActionResult FinalyOrder(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name, id))
            {

                return Redirect("/UserPanel/MyOrders/ShowOrder/" + id + "?finaly=true");
            }
            return BadRequest();
        }
        public IActionResult UseDiscount(string code,int orderid)
        {
            DiscountUseType type =
                _orderService.UseDiscount(orderid, code);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderid + "?type=" + type.ToString());

        }
        public IActionResult UserCourses()
        {
            ViewBag.UserCourses = _orderService.GetCourses(User.Identity.Name);

            return View();
        }
        }
    }

