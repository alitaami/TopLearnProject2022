#pragma checksum "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0765b4ba8f9f3290242fc65600214fe9f402e3a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_MyOrders_ShowOrder), @"mvc.1.0.view", @"/Areas/UserPanel/Views/MyOrders/ShowOrder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
using TopLearn.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0765b4ba8f9f3290242fc65600214fe9f402e3a1", @"/Areas/UserPanel/Views/MyOrders/ShowOrder.cshtml")]
    #nullable restore
    public class Areas_UserPanel_Views_MyOrders_ShowOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.DataLayer.Entities.Order.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
  
    int sumOrder = Model.OrderSum;
    string DiscountType = ViewBag.type.ToString();
    ViewData["Title"] = "ShowOrder";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Main Content -->
<form method=""post"" action=""/UserPanel/MyOrders/UseDiscount"">

    <div class=""page-wrapper"">
        <div class=""container-fluid"">

            <!-- Title -->
            <div class=""row heading-bg"">
                <div class=""col-lg-3 col-md-4 col-sm-4 col-xs-12"">
                    <h5 class=""txt-dark""> فاکتورِ کاربر  : ");
#nullable restore
#line 19 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n\r\n                </div>\r\n\r\n                <!-- Breadcrumb -->\r\n");
            WriteLiteral("                <!-- /Breadcrumb -->\r\n            </div>\r\n            <!-- /Title -->\r\n");
#nullable restore
#line 35 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
             if (!Model.OrderDetails.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger alert-dismissable\">\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button> ریزفاکتوری وجود ندارد و یا  قبل از پرداخت حذف شده است\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
             if (ViewBag.finaly == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""alert alert-success alert-dismissable"">
                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                    <i class=""zmdi zmdi-check pr-15 pull-left""></i><p class=""pull-left"">فاکتور با موفقیت پرداخت گردیده است</p>
                    <div class=""clearfix""></div>
                </div>
");
#nullable restore
#line 49 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
             if (DiscountType != null)
            {
                switch (DiscountType)
                {
                    case "Success":
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-success alert-dismissable"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                <i class=""zmdi zmdi-check pr-15 pull-left""></i><p class=""pull-left"">کد تخفیف اعمال گردید</p>
                                <div class=""clearfix""></div>
                            </div>
");
#nullable restore
#line 61 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                            break;
                        }
                    case "ExpireDate":
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-danger alert-dismissable"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                <i class=""zmdi  pr-15 pull-left""></i><p class=""pull-left"">کد تخفیف منقضی شده است</p>
                                <div class=""clearfix""></div>
                            </div>
");
#nullable restore
#line 69 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                            break;
                        }
                    case "NotFound":
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-warning alert-dismissable"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                <i class=""zmdi   pr-15 pull-left""></i><p class=""pull-left"">کد تخفیف وارد شده صحیح نیست</p>
                                <div class=""clearfix""></div>
                            </div>
");
#nullable restore
#line 77 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                            break;
                        }
                    case "Finished":
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-danger alert-dismissable"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                <i class=""zmdi   pr-15 pull-left""></i><p class=""pull-left"">  تعداد دفعات مجاز استفاده از کد تخفیف به پایان رسیده است</p>
                                <div class=""clearfix""></div>
                            </div>
");
#nullable restore
#line 85 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                            break;
                        }
                    case "UserUsed":
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-info alert-dismissable"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                                <i class=""zmdi   pr-15 pull-left""></i><p class=""pull-left"">کد تخفیف استفاده شده است</p>
                                <div class=""clearfix""></div>
                            </div>
");
#nullable restore
#line 93 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                            break;
                        }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



            <!-- Row -->
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""panel panel-default card-view"">
                        <div class=""panel-wrapper collapse in"">
                            <div class=""panel-body row"">
                                <form id=""example-advanced-form"" action=""#"">
                                    <div class=""table-wrap"">
                                        <div class=""table-responsive"">
                                            <table class=""table display product-overview mb-30"" id=""datable_1"">
                                                <thead>
                                                    <tr>
                                                        <th>عکس دوره</th>
                                                        <th>محصول</th>
                                                        <th>تعداد</th>
                                                        <th>قیمت</th>
");
            WriteLiteral("                                                    </tr>\r\n                                                </thead>\r\n                                                <tfoot>\r\n");
#nullable restore
#line 121 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                     if (!Model.IsFinaly)
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n\r\n                                                            <th colspan=\"3\">جمع کل: ");
#nullable restore
#line 126 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                                               Write(sumOrder.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </th>
                                                            <th>
                                                                <div class=""col-4 "" style=""display:flex    "">

                                                                    <label class=""control-label mr-10 "" style=""width: 80px; align-self:center"">کد تخفیف:</label>
                                                                    <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 6771, "\"", 6793, 1);
#nullable restore
#line 131 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 6779, Model.OrderId, 6779, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"orderid\" />\r\n                                                                    <input type=\"text\" name=\"code\" class=\"form-control \"");
            BeginWriteAttribute("id", " id=\"", 6934, "\"", 6939, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                                                                    <button type=""submit"" class=""btn btn-success btn-sm"">اعمال</button>


                                                                </div>


                                                            </th>
                                                            <th></th>


                                                        </tr>
");
#nullable restore
#line 145 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"

                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                     if(Model.IsFinaly && Model.OrderDetails.Any())
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                        <th colspan=\"3\">جمع کل: ");
#nullable restore
#line 151 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                                           Write(sumOrder.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                                                        </tr>");
#nullable restore
#line 152 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </tfoot>\r\n                                                    <tbody>\r\n");
#nullable restore
#line 155 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                         foreach (var item in Model.OrderDetails)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                <td>\r\n\r\n                                                                    <img");
            BeginWriteAttribute("src", " src=\"", 8308, "\"", 8356, 2);
            WriteAttributeValue("", 8314, "/Course/Image/", 8314, 14, true);
#nullable restore
#line 160 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 8328, item.Course.CourseImageName, 8328, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"iMac\" width=\"80\">\r\n                                                                </td>\r\n                                                                <td class=\"txt-dark\">\r\n                                                                    <a");
            BeginWriteAttribute("href", " href=\"", 8610, "\"", 8641, 2);
            WriteAttributeValue("", 8617, "/ShowCourse/", 8617, 12, true);
#nullable restore
#line 163 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 8629, item.Course, 8629, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 163 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                                                                                  Write(item.Course.CourseTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                                </td>\r\n                                                                <td class=\"txt-dark\">\r\n                                                                    ");
#nullable restore
#line 166 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </td>\r\n                                                                <td>\r\n                                                                    ");
#nullable restore
#line 169 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                                Write((item.Count * item.Price).ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                                                </td>\r\n\r\n");
#nullable restore
#line 173 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                                 if (item.Order.IsFinaly == false)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 9732, "\"", 9785, 2);
            WriteAttributeValue("", 9739, "/UserPanel/MyOrders/DeleteOrder/", 9739, 32, true);
#nullable restore
#line 175 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 9771, item.DetailId, 9771, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-inverse\" title=\"Delete\" data-toggle=\"tooltip\"><i class=\"zmdi zmdi-delete txt-danger\"></i></a></td>\r\n");
#nullable restore
#line 176 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </tr>\r\n");
#nullable restore
#line 179 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"

                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </tbody>\r\n                                                </table>\r\n\r\n");
#nullable restore
#line 185 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                             if (Model.IsFinaly == false)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                 if (_UserService.BalanceUserWallet(User.Identity.Name) >= sumOrder)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"form-actions pull-right pr-15\">\r\n                                                        <a class=\"btn btn-success btn-anim mr-10 pull-left\"");
            BeginWriteAttribute("href", " href=\"", 10717, "\"", 10770, 2);
            WriteAttributeValue("", 10724, "/UserPanel/MyOrders/FinalyOrder/", 10724, 32, true);
#nullable restore
#line 191 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 10756, Model.OrderId, 10756, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i><span class=\"btn-text\">تایید فاکتور</span></a>\r\n                                                        <div class=\"clearfix\"></div>\r\n                                                    </div>\r\n");
#nullable restore
#line 194 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                }
                                                else
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <div class=""alert  alert-danger"">
                                                        موجودی کیف پول شما کافی نمیباشد لطفا از این
                                                        <a href=""/UserPanel/Wallet"" class=""alert-link"">لینک</a>
                                                        اقدام به شارژ کنید و سپس فاکتور خود را تایید کنید
                                                    </div>
");
#nullable restore
#line 203 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 203 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                 

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /Row -->
        </div>
</form>
<!-- Footer -->
");
            WriteLiteral("<!-- /Footer -->\r\n                        </div>\r\n<!-- /Main Content -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _UserService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.DataLayer.Entities.Order.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
