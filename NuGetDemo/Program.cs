using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace NuGetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string data = "{\"name\":\"Tom S.\",\"Age\":\"14\"}";
            Console.WriteLine(data);
            JArray array = new JArray();
            JValue text = new JValue("Manual Text");
            JValue date = new JValue(new DateTime(2000, 5, 23));
            array.Add(text);
            array.Add(date);
            Console.WriteLine(array.ToString());

            Employee employee = new Employee();
            employee.Id = 1;
            employee.name="mani";
            Console.WriteLine(JsonConvert.SerializeObject(employee));
        
        }
    }
}
