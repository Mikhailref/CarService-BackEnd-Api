using Garage_v_2._0.Interfaces;

namespace Garage_v_2._0.Models
{
    public class GermanCar:ICar
    {
        public string Model { get; set; }
        public int Year { get; set; }
    }

    public class JapanCar : ICar
    {
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
