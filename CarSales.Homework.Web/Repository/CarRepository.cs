using CarSales.Homework.Web.Models;
using CarSales.Homework.Web.ServiceContract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CarSales.Homework.Web.Repository
{
    public class CarRepository: ICarRepository
    {
        List<Car> cars = null;
        public CarRepository()
        {
            cars = new List<Car>(){
                new Car{CarID=1, Make="BMW", Model="500", Year="2010", PriceType="DAP", DapPrice="1000", ContactName="Ajeet",
                    Email ="at@mail.com",  DealerABN=null, Phone="0400000", Comments="Comments", Dealer=Car.dealer.FALSE},
                 new Car{
                    CarID=2, Make="SUZUKI", Model="VX", Year="2015", PriceType="EGC", EgcPrice="2000", ContactName=null,
                     Email ="ak@mail.com",  DealerABN="Dealer2", Phone=null, Comments="Comments2",Dealer=Car.dealer.TRUE},
                 new Car{
                    CarID=3, Make="TOYOTA", Model="Corolla", Year="2012", PriceType="POA",  ContactName="Pragya",
                     Email ="pt@mail.com",  DealerABN="Dealer3", Phone="0400003", Comments="Comments3",Dealer=Car.dealer.TRUE},
            };
        }
        public IEnumerable<Car> GetAllCarRepo()
        {
            return cars;
        }
        public Car GetCarDetailsRepo(int id)
        {
            return cars.Where(x => x.CarID == id).SingleOrDefault();
        }
        public void SaveFeedbackRepo(CarViewModel model)
        {
            string createText = "Name:" + model.Feedback.Name + ",Email:" + model.Feedback.Email +
                ",Message:" + model.Feedback.Message + ",Car:" + model.Car.Make + ",CarId:" + model.Car.CarID;
            File.WriteAllText(HttpContext.Current.Server.MapPath("~/App_Data/Feedback" +
                DateTime.Now.ToString("ddMMMyyyy") + DateTime.Now.ToString("hhmmss") + ".txt"), createText);

        }
    }
}