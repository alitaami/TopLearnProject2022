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
    public class CreateDiscountModel : PageModel
    {
        IOrderService _order;
        public CreateDiscountModel(IOrderService order)
        {
            _order = order;
        }
        [BindProperty]
        public Discount discount { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid   )
            {
               
                return Page();
            }
            else if(_order.ISExistCode(discount.DiscountCode) == true)
            { 
                ViewData["Exist"] = "کد وارد شده تکراریست";
                return Page();
            }
           
                _order.AddDiscount(discount);
                return RedirectToPage("index");
            
        }
        //admin/discounts/creatediscount?handler=checkcode
        //admin//discounts/creatediscount/checkcode
        //public IActionResult OnGetCheckCode(string code)
        //{
        //    // iactionresult  نمیتواند
        //    // true false 
        //    // برگرداند  بخاطر آن از content 
        //    // برای گرفتن متن درست یا نادرست استفاده کردیم

        //    return Content(_order.ISExistCode(code).ToString());
        //}
    
    }
}
