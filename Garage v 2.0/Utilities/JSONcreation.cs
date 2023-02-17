using Garage_v_2._0.Interfaces;
using Newtonsoft.Json;

namespace Garage_v_2._0.Utilities
{
    public static class JSONcreation
    {
        public static string CreateJSONservice (IService service, string Input)
        {
            string json = JsonConvert.SerializeObject(service);
            json = json.Insert(json.Length - 1, ", \"Price\":\"" + Input+ "\"");
            return json;

        }

        public static string CreateJSONcar(ICar car, string Input)
        {
            string json = JsonConvert.SerializeObject(car);
            json = json.Insert(json.Length - 1, ", \"Price\":\"" + Input + "\"");
            return json;
        }
    }
}
