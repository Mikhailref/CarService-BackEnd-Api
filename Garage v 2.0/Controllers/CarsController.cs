using Garage_v_2._0.Factories;
using Garage_v_2._0.Interfaces;
using Garage_v_2._0.Utilities;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Garage_v_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CarsController>/5
        [HttpGet("{CarModel}")]
        public string Get(string CarModel)
        {
            ICarFactory carfactory = new CarFactory();
            ICar car = carfactory.CreateModel(CarModel);

            //add GetPrice method to the model of each car
            string PriceOfCar=CarsDataBase.GetPrice(CarModel);

            string result=JSONcreation.CreateJSONcar(car, PriceOfCar);    
            return result;
            
        }

        // POST api/<CarsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
