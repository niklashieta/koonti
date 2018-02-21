using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            ruoka ru = new ruoka();
            ruoka ruo = new ruoka();
            ruoka ruk = new ruoka();
            ruoka rua = new ruoka();
            ru.nimi = "maito";
            ruo.nimi = "jauhen lihaa";
            ruk.nimi = "ket zuppi";
            rua.nimi = "torakka";
            Console.WriteLine("jaakaappi sisaltaa: \n" + ru.nimi + "\n" + ruo.nimi + "\n" + ruk.nimi + "\n" + rua.nimi);
        }
    }
}