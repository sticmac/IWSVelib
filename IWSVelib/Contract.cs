using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSVelibLib
{
    public class Contract
    {
        private string name;
        private string country_code;

        public string Country_code { get => country_code; set => country_code = value; }
        public string Name { get => name; set => name = value; }
    }
}
