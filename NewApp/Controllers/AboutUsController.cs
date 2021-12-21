using NewApp.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApp.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult Index()
        {
            return View(CreateModel());
        }

        private static AboutUs CreateModel()
        {
            var item = RenderingContext.Current.ContextItem;
            var aboutinfo = new AboutUs()
            {
                Title = new HtmlString(FieldRenderer.Render(item, "Title")),
                Description = new HtmlString(FieldRenderer.Render(item, "Description"))
            };
            return aboutinfo;
        }
    }
}