using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSEILYAXD
{
    class Car
    {
        public string merkki;
        public string malli;
        public double enginesize;
        public double topspeed;
        public double accerelation;
        public double quartermiletime;
        public double weight;
        public int Speed;
        public override string ToString()
        {
            return "\n" + merkki + "\n" + malli +
                "\nMoottorin koko on: " + enginesize + " Litraa\n"
                + "huiput " + topspeed + "km/h"
                + "\nkiihtyvyys on " + accerelation + "sec 0-100"
                + "\nvarttimaili aika " + quartermiletime + "sec"
                + "\npaino on " + weight + "Kg\n";
                
        }
    }
}
