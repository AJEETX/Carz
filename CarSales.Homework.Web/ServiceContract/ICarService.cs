using CarSales.Homework.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Homework.Web.ServiceContract
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCarSvc();
        Car GetCarDetailSvc(int id);
        void SaveFeedbackSvc(CarViewModel model);
    }
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCarRepo();
        Car GetCarDetailsRepo(int id);
        void SaveFeedbackRepo(CarViewModel model);
    }
}
