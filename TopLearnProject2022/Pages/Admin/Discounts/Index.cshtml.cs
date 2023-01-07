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
    public class IndexModel : PageModel
    {
        IOrderService _order;
        public IndexModel(IOrderService order)
        {
            _order = order;
        }
       
        public List<Discount> discount { get; set; }
        public void OnGet()
        {
            discount = _order.GetDiscounts();
        }
    }
}
