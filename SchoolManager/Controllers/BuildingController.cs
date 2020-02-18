using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManager.Models;

namespace SchoolManager.Controllers
{
    public class BuildingController : Controller
    {
        // GET: Building
        SchoolManagementEntities db = new SchoolManagementEntities();
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult ListBuilding(int pageNumber, int pageSize, string search)
        {
            

<<<<<<< HEAD
            var data = db.Building.OrderBy(x=>x.Name);
=======
            var data = db.Buildings.OrderBy(x=>x.Name);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            if (search.Trim() != "")
            {
                data = data.Where(x => x.Name.Contains(search)).OrderBy(x=>x.Name);
                
            }
            
            var pageCount = data.Count() % pageSize == 0 ? data.Count() / pageSize : data.Count() / pageSize + 1;
            ViewBag.pageCount = pageCount;
            if ( pageCount >= pageNumber)
            {
                var model = data.OrderBy(x => x.Name).Skip(pageSize * pageNumber - pageSize).Take(pageSize).ToList();
                ViewBag.pageNumber = pageNumber;
                return PartialView(model);
            }
            
            ViewBag.pageNumber = 1;
            return PartialView(data.OrderBy( x => x.Name).ToList());


        }
        public PartialViewResult FormCreateEdit()
        {

            return PartialView();
        }
       
        public PartialViewResult InfoDetail(int id)
        {
<<<<<<< HEAD
            Building cl = db.Building.Find(id);
=======
            Building cl = db.Buildings.Find(id);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            return PartialView(cl);
        }


        [HttpPost]
        public JsonResult Create(string node, string name , int status)
        {
            Building cl = new Building();
            cl.Node = node;
            cl.Name = name;
            cl.Status = status;  
            cl.CreateDate = DateTime.Now;
            
<<<<<<< HEAD
            db.Building.Add(cl);
=======
            db.Buildings.Add(cl);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            db.SaveChanges();
            return Json(true);
        }
        [HttpPost]
        public JsonResult Update(int id, string node, string name , int status )
        {
<<<<<<< HEAD
            var cl = db.Building.Find(id);
=======
            var cl = db.Buildings.Find(id);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            cl.Node = node;
            cl.Name = name;
            cl.Status = status; 
            cl.UpdateDate = DateTime.Now;
            db.SaveChanges();
            return Json(true);
        }
        [HttpPost]
        public JsonResult Delete(int id)
        {
<<<<<<< HEAD
            var cl = db.Building.Find(id);
            db.Building.Remove(cl); 
=======
            var cl = db.Buildings.Find(id);
            db.Buildings.Remove(cl); 
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            db.SaveChanges();
            return Json(true);
        }
    }
}