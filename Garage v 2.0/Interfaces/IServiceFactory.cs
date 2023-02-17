using Garage_v_2._0.Interfaces;

namespace Garage_v_2._0.Factories
{
    public interface IServiceFactory
    {
        public  IService CreateModel(string ServiceName);
    }
}
