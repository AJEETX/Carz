using CarSales.Homework.Web.ServiceContract;
using System.Collections.Generic;
using CarSales.Homework.Web.Models;
namespace CarSales.Homework.Web.Service
{
    public class CarService : ICarService
    {
        readonly ICarRepository _ICarRepository;
        public CarService(ICarRepository ICarRepository)
        {
            _ICarRepository = ICarRepository;
        }
        public IEnumerable<Car> GetAllCarSvc()
        {
            return _ICarRepository.GetAllCarRepo();
        }
        public Car GetCarDetailSvc(int id)
        {
            return _ICarRepository.GetCarDetailsRepo(id);
        }
        public void SaveFeedbackSvc(CarViewModel model)
        {
            _ICarRepository.SaveFeedbackRepo(model);
        }
    }
}