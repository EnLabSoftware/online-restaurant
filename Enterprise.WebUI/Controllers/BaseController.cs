using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterprise.WebUI.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        public JsonResult GetJsonResult(object data, JsonRequestBehavior? requestBehavior = JsonRequestBehavior.AllowGet)
        {
            if (requestBehavior != null)
            {
                var jsonResult = Json(data, requestBehavior.Value);
                jsonResult.MaxJsonLength = Int32.MaxValue;
                return jsonResult;
            }
            else
            {
                var jsonResult = Json(data);
                jsonResult.MaxJsonLength = Int32.MaxValue;
                return jsonResult;
            }
        }

        public JsonResult GetJsonResult(object data, bool success, string message,
            JsonRequestBehavior? requestBehavior = JsonRequestBehavior.AllowGet)
        {
            if (requestBehavior != null)
            {
                var jsonResult = Json(new
                {
                    data = data,
                    success = success,
                    message
                }, requestBehavior.Value);
                jsonResult.MaxJsonLength = Int32.MaxValue;

                return jsonResult;
            }
            else
            {
                var jsonResult = Json(new
                {
                    data = data,
                    success = success,
                    message
                });
                jsonResult.MaxJsonLength = Int32.MaxValue;

                return jsonResult;
            }
        }

        public const string CartSessionKey = "CartId";
        public string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    var tempCartId = Guid.NewGuid();

                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }

            return context.Session[CartSessionKey].ToString();
        }

        public string RenderRazorViewToString(Controller controller, string viewName, object model)
        {

            controller.ViewData.Model = model;
            using (var sw = new System.IO.StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, viewName);
                var viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
        
    }
}