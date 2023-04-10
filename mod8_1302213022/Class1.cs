using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mod8_1302213022
{
    internal class Class1
    {
        static void Main()
        {
            string uang = Console.ReadLine();

            string json = "{}";
            try
            {
                json = File.ReadAllText(@"D:\smester 4\kontruksi peerangkat lunak\prima ganteng\mod8_1302213022\mod8_1302213022\bank_tranfer_config.json");
            }
            catch(FileNotFoundException)
            { 
                
            }
            config config = JsonConverter.DeserializeObject<config>(json);
            if (config.enggres == "en")
            {
                 Console.WriteLine ("please insert the amount of money");
                 
                 Console.WriteLine(uang);
            }
            else if (config.indo == "id")
            {
                Console.WriteLine  ("masukan uang anda");
                
                Console.WriteLine(uang);
            }
            if (uang <= config.low_fee ||uang == config.)


        }
    }
}
