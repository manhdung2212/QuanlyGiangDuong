using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManager.Models; 
namespace SchoolManager.Controllers
{
    public class FacultyManagerController : Controller
    {
        SchoolManagementEntities db = new SchoolManagementEntities();
        // GET: Faculty
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public PartialViewResult ListFaculty(int pageNumber, int pagesize, string search)
        {
            
<<<<<<< HEAD
            var data = db.Faculty.OrderBy(x => x.Name);
=======
            var data = db.Faculties.OrderBy(x => x.Name);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
           

            if (search.Trim() != "")
            {
                data = data.Where(x => x.Name.Contains(search)).OrderBy(x => x.Name);
            }
            var pageCount = data.Count() % pagesize == 0 ? data.Count() / pagesize : data.Count() / pagesize + 1;
            if (pageNumber <= pageCount)
            {
                var model = data.OrderBy(x => x.Name).Skip(pagesize * pageNumber - pagesize).Take(pagesize);
                ViewBag.pageCount = pageCount;
                ViewBag.pageNumber = pageNumber;
                return PartialView(model);
            }
            return PartialView(data.OrderBy(x => x.Name));
        }
        public PartialViewResult FormCreateEdit()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult Create(string Name, string Node,  int Status)
        {
            Faculty Fa = new Faculty { Name = Name, Node = Node, CreateDate = DateTime.Now, UpdateDate = DateTime.Now, Status = Status };
            
<<<<<<< HEAD
            db.Faculty.Add(Fa);
=======
            db.Faculties.Add(Fa);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            db.SaveChanges();
            return Json(true);
        }
        [HttpPost]
        public JsonResult Update(int ID, string Name, string Node,int Status)
        {

<<<<<<< HEAD
            var model = db.Faculty.Find(ID);
=======
            var model = db.Faculties.Find(ID);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            model.Name = Name;
            model.Node = Node;
            
          
            model.UpdateDate = DateTime.Now;
            model.Status = Status;
            db.SaveChanges();
            return Json(true);
        }
        [HttpPost]
        public JsonResult Delete(int ID)
        {
<<<<<<< HEAD
            var model = db.Faculty.Find(ID);
            db.Faculty.Remove(model);
=======
            var model = db.Faculties.Find(ID);
            db.Faculties.Remove(model);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
            db.SaveChanges();
            return Json(true);
        }
    
        public PartialViewResult ChitietKhoa(int ID)
        {
<<<<<<< HEAD
            Faculty data = db.Faculty.Find(ID);
=======
            Faculty data = db.Faculties.Find(ID);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451

            return PartialView(data);
        }

    
}
}