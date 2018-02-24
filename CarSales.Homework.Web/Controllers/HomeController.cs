using CarSales.Homework.Web.Models;
using CarSales.Homework.Web.ServiceContract;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CarSales.Homework.Web.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        readonly ICarService _ICarService;
        public HomeController(ICarService ICarService)
        {
            _ICarService = ICarService;
        }
        [Route("{index}")]
        public ActionResult Index()
        {
            IEnumerable<Car> cars = null;
            try
            {
                cars = _ICarService.GetAllCarSvc();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View(cars);
        }

        public ActionResult NotFound()
        {
            return View("NotFound");
        } 
            [Route("{Details/id?:int}")]
        public ActionResult Details(int id=1)
        {
            var model = new CarViewModel();
            try
            {
                model.Car = _ICarService.GetCarDetailSvc(id);
                if (model.Car == null)
                    return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View(model);
        }
        [Route("{Feedback}")]
        public ActionResult Feedback(CarViewModel model)
        {
            try
            {
                _ICarService.SaveFeedbackSvc(model);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View();
        }
    }
}