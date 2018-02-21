using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03teht1
{
    class his
    {
        int min = 1;
        int max = 5;
        public int _kerros;
        public int kerros
        {
            get { return _kerros; }
            set
            {
                _kerros = 1;
            }
        }
        public void ylos(float n)
        {
            _kerros = (int)n;
            if (_kerros < min) { _kerros = min; }
            if (_kerros > max) { _kerros = max; }
        }
        public void alas(float i)
        {
            _kerros = (int)i;
            if (_kerros < min) { _kerros = min; }
            if (_kerros > max) { _kerros = max; }
        }
    }
}
