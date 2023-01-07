using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Toplearn.Core.Convertors
{
 public interface IViewRenderService
    {
        string RenderToStringAsync(string viewName, object model);

    }
    public class RenderViewToString : IViewRenderService
    {
        private readonly IRazorViewEngine _razorViewEngine;
        private readonly ITempDataProvider _tempDataProvider;
        private readonly IServiceProvider _serviceProvider;

        public RenderViewToString(IRazorViewEngine razorViewEngine,
            ITempDataProvider tempDataProvider,
            IServiceProvider serviceProvider)
        {
            _razorViewEngine = razorViewEngine;
            _tempDataProvider = tempDataProvider;
            _serviceProvider = serviceProvider;
         }

        public string RenderToStringAsync(string viewName, object model)
        {
            var httpContext = new DefaultHttpContext { RequestServices = _serviceProvider };
            var actionContext = new ActionContext(httpContext, new Microsoft.AspNetCore.Routing.RouteData(), new Microsoft.AspNetCore.Mvc.Abstractions.ActionDescriptor());
       
            using (var sw=new StringWriter())
            {
              
                var viewresult = _razorViewEngine.FindView(actionContext, viewName, false);


                    if (viewresult.View == null)
                    {
                        throw new ArgumentException($"{viewName} does not match");
                    }

                var viewDictonary = new ViewDataDictionary(new EmptyModelMetadataProvider(),new ModelStateDictionary() )
                    {
                    Model = model
                };
                    var viewContext = new ViewContext(
                        actionContext,
                        viewresult.View,
                        viewDictonary,
                        new TempDataDictionary(actionContext.HttpContext, _tempDataProvider),
                        sw,
                        new HtmlHelperOptions()
                        );
                    viewresult.View.RenderAsync(viewContext);
                    return sw.ToString();
                }
            }  
        
        }
    }
