using Garage_v_2._0.Interfaces;
using Garage_v_2._0.Models;

namespace Garage_v_2._0.Factories
{
    public class ServiceFactory : IServiceFactory
    {
        public  IService CreateModel(string ServiceName)
        {
            switch (ServiceName )
            {
                case "test preparation":
                    return new TestPreparation();

                case "wheel adjustment":
                    return new WheelAdjustment ();

                default:
                    throw new ArgumentException("Invalid Service type");
            }

        }
    }

    public class newServiceFactory : IServiceFactory
    {
        public IService CreateModel(string ServiceName)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
