using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod8_1302213022
{
    internal class config
    {
        public int treshold { get; set;} = 25000000;
        public int low_fee { get; set; } = 6500;
        public int hight_fee { get; set; } = 1500;
        public string enggres { get; set; } = "en";
        public string indo { get; set; } = "id";

        

    }
}
