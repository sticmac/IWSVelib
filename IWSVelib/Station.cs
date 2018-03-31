using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSVelibLib
{
    public class Station
    {
        private string name;
        private string address;
        private int available_bikes;
        private int bike_stands;

        public string Name { get => name.ToUpper(); set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Available_bikes { get => available_bikes; set => available_bikes = value; }
        public int Bike_stands { get => bike_stands; set => bike_stands = value; }
    }
}
