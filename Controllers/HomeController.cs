using Clinic_Management_System.models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_Management_System.Controllers
{

    public class HomeController : Controller
    {
        private readonly WebDbcontext _Db;
        public HomeController(WebDbcontext Db)
        {
            _Db = Db;
        }
        public IActionResult Index()
        {
            var datalist = _Db.DataModels.ToList();
            return View("datalist");
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(DataModel model)
        {
            _Db.DataModels.Add(model);
            _Db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _Db.DataModels.Where(x => x.Id == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Edit(DataModel model)
        {
            var data = _Db.DataModels.Where(x => x.Id == model.Id).FirstOrDefault();
            if (data != null)
            {

                data.Name = model.Name;
                data.email = model.email;
                data.Number = model.Number;
                data.Date = model.Date;
                _Db.SaveChanges();
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var data = _Db.DataModels.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data = _Db.DataModels.Where(x => x.Id == id).FirstOrDefault();
            _Db.DataModels.Remove(data);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

        }
