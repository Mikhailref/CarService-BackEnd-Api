using Garage_v_2._0.Utilities;
using Microsoft.AspNetCore.Mvc;
using Garage_v_2._0.Interfaces;
using Garage_v_2._0.Factories;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Garage_v_2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {

        // GET: api/<ServicesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ServicesController>/5
        [HttpGet("{ServiceType}")]
        public string GetService(string ServiceType)
        {
                IServiceFactory servicefactory = new ServiceFactory();
                IService service = servicefactory.CreateModel(ServiceType);
                string PriceOfService = service.GetPrice(ServiceType);

                string result=JSONcreation.CreateJSONservice(service, PriceOfService);
                return result;
                
        }

        // POST api/<ServicesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServicesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServicesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
