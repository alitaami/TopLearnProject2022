using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Order;

namespace TopLearnProject2022.Pages.Admin.Discounts
{
    public class DeleteDiscountModel : PageModel
    {
        IOrderService _order;
        public DeleteDiscountModel(IOrderService order)
        {
            _order = order;
        }
        
        public Discount discount { get; set; }
        public void OnGet(int id)
        {
            ViewData["discountId"] = id;
            discount = _order.GetdiscountbyId(id);
        }
        public IActionResult OnPost(int discountid)
        {
            _order.DeleteDiscount(discountid);
            return RedirectToPage("Index");
        }
    }
}
