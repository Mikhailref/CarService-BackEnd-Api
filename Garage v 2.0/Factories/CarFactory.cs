using Garage_v_2._0.Interfaces;
using Garage_v_2._0.Models;

namespace Garage_v_2._0.Factories
{
    public class CarFactory : ICarFactory
    {
        public ICar CreateModel(string CarModel)
        {
            switch(CarModel)
            {
                case "Japan":
                    return new JapanCar();

                case "German":
                    return new GermanCar();

                default:
                    throw new ArgumentException("Invalid CarModel");
            }
        }
    }
}
