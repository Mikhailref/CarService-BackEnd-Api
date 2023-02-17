using Garage_v_2._0.Interfaces;
using Garage_v_2._0.Utilities;

namespace Garage_v_2._0.Models
{
    public class TestPreparation:IService
    {
        public int Id { get; set; }
        public string Name { get; set; } = "TEST";
        public string Description { get; set; }
        public float TimeOfWork { get; set; } = 0.5f;

        public string GetPrice(string ServiceType)
        {
            return ServicesDataBase.GetPrice(ServiceType);
        }
    }

    public class WheelAdjustment : IService
    {
        public int Id { get; set; }
        public string Name { get; set; } = "WheelAdjustment";
        public string Description { get; set; }
        public float TimeOfWork { get; set; } = 1.5f;

        public string GetPrice(string ServiceType)
        {
            return ServicesDataBase.GetPrice(ServiceType);
        }
    }

}
