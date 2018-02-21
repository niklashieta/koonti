using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class vahv
    {
        int min = -50;
        int max = 50;
        public int _vol;
        public int vol
        {
            get { return _vol; }
            set
            {
                _vol = -50;
            }
        }
        public void saato(float n)
        {
            _vol = (int)n;
            if (_vol < min) { _vol = min; }
            if (_vol > max) { _vol = max; }
        }
    }
}