using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManager.Models;
using SchoolManager.ViewModels;  
namespace SchoolManager.Controllers
{
    public class UserAppController : Controller
    {
        // GET: UserApp
        SchoolManagementEntities db = new SchoolManagementEntities();  
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View(); 
        }
        [HttpPost]
        public JsonResult Login( string account , string password)
        {
<<<<<<< HEAD
            var user = db.UserManager.Where(x => x.Account == account && x.Password == password).FirstOrDefault();  
            if( user != null)
            {
                var userApp = db.UserApp.Find(user.ID);  
                if( userApp == null)
                {
                    userApp = new UserApp { Name = "admin" };
                    db.UserApp.Add(userApp);
=======
            var user = db.UserManagers.Where(x => x.Account == account && x.Password == password).FirstOrDefault();  
            if( user != null)
            {
                var userApp = db.UserApps.Find(user.ID);  
                if( userApp == null)
                {
                    userApp = new UserApp { Name = "admin" };
                    db.UserApps.Add(userApp);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
                    db.SaveChanges();
                   
                }
                Session["userName"] = userApp.Name;
                return Json(true, JsonRequestBehavior.AllowGet);


            }
            return Json( false, JsonRequestBehavior.AllowGet);   
        }

        public PartialViewResult ListUser( int pageNumber , int pageSize  ,  string search)
        {
<<<<<<< HEAD
            var data = from u in db.UserManager
                       join userApp in db.UserApp on u.ID equals userApp.ID
=======
            var data = from u in db.UserManagers
                       join userApp in db.UserApps on u.ID equals userApp.ID
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
                       select new UserViewModel
                       {
                           ID = u.ID,
                           Account = u.Account,
                           Name = userApp.Name,
                           Phone = userApp.Phone,
                           Email = userApp.Email,
                           DateLogin = u.DateLogin
                       };  

            var pageCount = data.Count() % pageSize == 0 ? data.Count() % pageSize : data.Count() / pageSize + 1;
            ViewBag.pageCount = pageCount;
            ViewBag.pageNumber = pageNumber;  
            data.OrderBy(x => x.Account).Skip(pageNumber * pageSize - pageSize).Take(pageSize).ToList();
            return PartialView(data);
        
        }

        [HttpPost]
        public JsonResult AddOrEdit( int id , string name , string account , string password)
        {
            var userName = Session["userName"];  
            if( userName == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet); 
            }
            if( id ==0)
            {
                UserManager user = new UserManager { Account = account , Password = password, DateLogin = DateTime.Now };
                UserApp userApp = new UserApp { Name = name , CreateBy  = userName.ToString() , UpdateBy = userName.ToString() , CreateDate = DateTime.Now , UpdateDate = DateTime.Now , Status = 0  };
<<<<<<< HEAD
                db.UserApp.Add(userApp); 
                db.UserManager.Add(user);
=======
                db.UserApps.Add(userApp); 
                db.UserManagers.Add(user);
>>>>>>> 3eb0c03e64b88b477fc655f737684f75edd0f451
                db.SaveChanges();
                return Json(true , JsonRequestBehavior.AllowGet);
            }
            return Json( false , JsonRequestBehavior.AllowGet);  
        }
    }
}