using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat();
            Bike bike = new Bike();
            boat.Name = "Yamaha";
            boat.Model = "1000";
            boat.Year = 2010;
            boat.Color = "Black";
            boat.Seat = 5;
            boat.Type = "Motorboat";
            bike.Name = "Tunturi";
            bike.Model = "StreetPower";
            bike.Year = 1942;
            bike.Color = "Rust";
            bike.Gear = false;
            Console.WriteLine(boat.ToString());
            Console.WriteLine(bike.ToString());
            Bike abike = new Bike();
            abike.Name = "Tunturi";
            abike.Model = "Owerpowerstreetpower";
            abike.Year = 2019;
            abike.Color = "Hot Pink";
            abike.Gear = true;
            abike.GeaN = "SHIMANOX230123XXX";
            Console.WriteLine(abike.ToString());
        }
    }
}