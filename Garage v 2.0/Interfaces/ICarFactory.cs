using Garage_v_2._0.Interfaces;

namespace Garage_v_2._0.Factories
{
    public interface ICarFactory
    {
        public ICar CreateModel(string CarModel);
    }
}
