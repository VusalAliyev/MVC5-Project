using BusinessLayer.Concrete;
using DataAccessLayer.EFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class DefaultController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        public PartialViewResult Index(int id=0)
        {
            var contentlist = cm.GetListByHeadingId(id);
            return PartialView(contentlist);
        }
        public ActionResult Headings()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
    }
}