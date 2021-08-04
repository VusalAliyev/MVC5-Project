using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllContent(string p)
        {
            var values = cm.GetList(p);
            if (p==null)
            {
                values = cm.GettAll();
            }
            return View(values);
        }
        public ActionResult ContentByHeading(int id)
        {
            
            var contentvalues = cm.GetListByHeadingId(id);
            return View(contentvalues);
        }
    }
}