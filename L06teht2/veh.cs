using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06teht2
{
    class Veh
    {
        public string Name;
        public string Model;
        public int Year;
        public string Color;
    }
    class Bike : Veh
    {
        public bool Gear;
        public string GeaN;
        public override string ToString()
        {
            return "Bike info\n" + "Name: " + Name + " Model: " + Model + " Year: " + Year + " Color: " + Color + " Gears: " + Gear + " GearsType: " + GeaN + "\n";
        }
    }
    class Boat : Veh
    {
        public int Seat;
        public string Type;
        public override string ToString()
        {
            return "Boat info\n" + "Name: " + Name + " Model: " + Model + " Year: " + Year + " Color: " + Color + " Seats: " + Seat + " BoatType: " + Type + "\n";
        }
    }
}