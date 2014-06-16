using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mobiles.Data;
using Mobiles.Data.Models;

namespace Mobiles.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<SpecifictionType> types;
            using (var db = new MobileDetailsDbContext())
            {
                types = db.SpecifictionTypes.Include("SpecifictionHeadings").OrderBy(s=>s.Name).ToList();
            }
            return View(types);
        }


        public ActionResult CurrentHeadingValues(int id)
        {
            List<SpecifictionHeadingValue> values;
            using (var db = new MobileDetailsDbContext())
            {
                values = db.SpecifictionHeadingValues.Where(s => s.Heading_Id == id).Include("SpecifictionHeading").ToList();
            }
            return View(values);
        }


    }
}
