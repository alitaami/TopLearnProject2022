#pragma checksum "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac5856420bab5dd41c752c3ff2f6956df614d00a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Courses_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Courses/Index.cshtml")]
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
#line 1 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\_ViewImports.cshtml"
using TopLearnProject2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\_ViewImports.cshtml"
using TopLearnProject2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5856420bab5dd41c752c3ff2f6956df614d00a", @"/Pages/Admin/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5325403a7be638dab6206b59b72c458e397346", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>لیست دوره ها</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac5856420bab5dd41c752c3ff2f6956df614d00a3585", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""card-body"">
    <div class=""table-responsive"" tabindex=""1"" style=""overflow: hidden; outline: none;"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">تصویر</th>
                    <th scope=""col"">عنوان دوره</th>
                    <th scope=""col"">تعداد جلسه</th>

                    <th scope=""col"">دستورات</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"
                 foreach (var course in Model.ListCourse)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 1414, "\"", 1451, 2);
            WriteAttributeValue("", 1420, "/Course/Image/", 1420, 14, true);
#nullable restore
#line 36 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"
WriteAttributeValue("", 1434, course.ImageName, 1434, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"thumbnail\" style=\"width:120px\" /></td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"
                       Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"
                       Write(course.EpisodeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1663, "\"", 1712, 2);
            WriteAttributeValue("", 1670, "/Admin/Courses/EditCourse/", 1670, 26, true);
#nullable restore
#line 40 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"
WriteAttributeValue("", 1696, course.CourseId, 1696, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:aliceblue;\" class=\"btn btn-warning\">ویرایش</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1856, 2);
            WriteAttributeValue("", 1812, "/Admin/Courses/IndexEpisode/", 1812, 28, true);
#nullable restore
#line 41 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"
WriteAttributeValue("", 1840, course.CourseId, 1840, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:aliceblue;\" class=\"btn bg-primary\"> جلسات</a>\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1950, "\"", 1957, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:aliceblue;\" class=\"btn btn-danger\">حذف</a>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Sarv\source\repos\TopLearnProject2022\TopLearnProject2022\Pages\Admin\Courses\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>
        </table>

    </div>
</div>
<script src=""/assets/vendors/bundle.js""></script>
<!-- end::global scripts -->
<!-- begin::custom scripts -->


<script src=""/assets/vendors/bundle.js""></script>
<!-- end::global scripts -->
<!-- begin::chart -->
<script src=""/assets/vendors/charts/chart.min.js""></script>
<script src=""/assets/vendors/charts/sparkline.min.js""></script>
<script src=""/assets/vendors/circle-progress/circle-progress.min.js""></script>
<script src=""/assets/js/examples/charts.js""></script>
<!-- end::chart -->
<!-- begin::swiper -->
<script src=""/assets/vendors/swiper/swiper.min.js""></script>
<script src=""/assets/js/examples/swiper.js""></script>
<!-- begin::custom scripts -->
<script src=""/assets/js/custom.js""></script>
<script src=""/assets/js/app.js""></script>
");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearnProject2022.Pages.Admin.Courses.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearnProject2022.Pages.Admin.Courses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearnProject2022.Pages.Admin.Courses.IndexModel>)PageContext?.ViewData;
        public TopLearnProject2022.Pages.Admin.Courses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
