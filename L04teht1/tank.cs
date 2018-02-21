using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class tank
    {
        int min = 2;
        int max = 6;
        public string name { get; set; }
        public string type { get; set; }
        public int _crewcount;
        public int crewcount
        {
            get { return _crewcount; }
            set
            {
                if (_crewcount < min)
                {

                    _crewcount = min;
                }
                if (_crewcount > max)
                {
                    _crewcount = max;
                }
            }


        }

        public float _speed;
        public float speed
        {

            get { return _speed; }
            set
            {
                _speed = 0;
            }
        }
        readonly float maxspeed = 100;
        public void accerelateto(float n)
        {
            _speed = (int)n;
            if (_speed > maxspeed)
            {
                _speed = maxspeed;
            }
        }
        public void slowto(float i)
        {
            _speed = (int)i;
            if (_speed < 0) { _speed = 0; }
        }
    }
}