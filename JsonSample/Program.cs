using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace JsonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone { Name = "kevin", Number = "1234567890" };

            // convert to json string
            Console.WriteLine("convert to Json string:");
            string strJson = JsonConvert.SerializeObject(phone,Formatting.Indented);
            Console.WriteLine(strJson);
            Console.WriteLine();

            //convert json string to object
            Console.WriteLine("convert from Json string:");
            var p = JsonConvert.DeserializeObject<Phone>(strJson);
            Console.WriteLine(p.Name+" : "+ p.Number);
            Console.WriteLine();

            //Json array
            Console.WriteLine("Json array:");
            List<Phone> phones = new List<Phone>();
            phones.Add(phone);
            phones.Add(phone);
            phones.Add(phone);

            strJson = JsonConvert.SerializeObject(phones, Formatting.Indented);
            Console.WriteLine(strJson);
            Console.WriteLine();

            Console.Read();

        }
        public class Phone
        {
            public string Name { get; set; }
            public string Number { get; set; }
        }
    }
}
