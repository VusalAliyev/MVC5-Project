using BusinessLayer.Concrete;
using DataAccessLayer.EFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var imageValues = ifm.GetList();
            return View(imageValues);
        }
    }
}