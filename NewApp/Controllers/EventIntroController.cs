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
    public class EventIntroController : Controller
    {
        // GET: EventIntro
       

        public ActionResult Index()
        {
            return View(CreateModel());
        }
        private static EventsInto CreateModel()
        {
            var item = RenderingContext.Current.ContextItem;
            var eventinro = new EventsInto()
            {
                ContentHeading = new HtmlString(FieldRenderer.Render(item, "ContentHeading")),
                ContentIntro = new HtmlString(FieldRenderer.Render(item, "ContentIntro"))
            };
            return eventinro;
        }
    }
}