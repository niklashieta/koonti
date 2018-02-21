using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            tank leopard = new tank();
            tank kepard = new tank();
            tank kamikard = new tank();
            Console.WriteLine("LEOPARD 1337GRD");
            leopard._crewcount = 4;
            leopard.name = "kimmo";
            leopard.type = "Erittain raskaasti panssaroitu kulkuneuvo";
            Console.WriteLine("nopeus " + leopard.speed);
            Console.WriteLine("crewcount: " + leopard.crewcount);
            Console.WriteLine("nimi: " + leopard.name);
            Console.WriteLine("tyyppi: " + leopard.type);
            leopard.accerelateto(20);
            Console.WriteLine("painetaampas leopardin kaasupoljin pohjasta lapi... ");
            Console.WriteLine("nopeus " + leopard.speed);
            Console.WriteLine("VIHOLLISIA!!! JARRUT POHJAAN!!");
            leopard.slowto(0);
            Console.WriteLine("nopeus: " + leopard.speed);
            Console.WriteLine("\nKEPARD 69-dd");
            kepard._crewcount = 6;
            kepard.name = "jorma";
            kepard.type = "Erittain raskaasti panssaroitu kulkuneuvo joka kulkee taysia";
            Console.WriteLine("nopeus " + kepard.speed);
            Console.WriteLine("crewcount: " + kepard.crewcount);
            Console.WriteLine("nimi: " + kepard.name);
            Console.WriteLine("tyyppi: " + kepard.type);
            kepard.accerelateto(70);
            Console.WriteLine("runtataampas kepardin kaasu kohti kaakkoa... ");
            Console.WriteLine("nopeus " + kepard.speed);
            Console.WriteLine("JUMALAUTA PEURA!!!! JARRUT POHJAAN!!");
            kepard.slowto(12);
            Console.WriteLine("nopeus: " + kepard.speed);
            Console.WriteLine("\nKAMIKARD 420-blazzeyit");
            kamikard._crewcount = 2;
            kamikard.name = "zorgos";
            kamikard.type = "Panssaroimaton kulkuneuvo joka kulkee sata kaks sataa";
            Console.WriteLine("nopeus " + kamikard.speed);
            Console.WriteLine("crewcount: " + kamikard.crewcount);
            Console.WriteLine("nimi: " + kamikard.name);
            Console.WriteLine("tyyppi: " + kamikard.type);
            kamikard.accerelateto(200);
            Console.WriteLine("Kokeillaan kamikardin kaasupoljinta hellasti... ");
            Console.WriteLine("nopeus " + kamikard.speed);
            Console.WriteLine("APUA PUU!! JARRUT POHJAAN!!");
            kamikard.slowto(20);
            Console.WriteLine("nopeus: " + kamikard.speed);



        }
    }
}