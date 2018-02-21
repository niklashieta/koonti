using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSEILYAXD
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Toyota = new Car();
            Toyota.merkki = "Toyota";
            Toyota.malli = "Camry";
            Toyota.enginesize =2.2;
            Toyota.weight = 1200+100*2.2;
            Toyota.topspeed =240;
            Toyota.accerelation =8.5;
            Toyota.quartermiletime =12.89;

            Car A = new Car();
            A.merkki = "Audi";
            A.malli = "A4";
            A.enginesize =1.8;
            A.weight = 1200+100*1.8;
            A.topspeed =210;
            A.accerelation =9.2;
            A.quartermiletime =13.21;


            Car o= new Car();
            o.merkki = "Opel";
            o.malli = "Astra";
            o.enginesize =2.0;
            o.weight = 1200+100*2.0;
            o.topspeed =200;
            o.accerelation =12;
            o.quartermiletime =22.12;

            Car n= new Car();
            n.merkki = "Nissan";
            n.malli = "Almera";
            n.enginesize =1.6;
            n.weight = 1200+100*1.6;
            n.topspeed =185;
            n.accerelation =9.3;
            n.quartermiletime =13.55;

            Car s= new Car();
            s.merkki = "SHITroen";
            s.malli = "Xara";
            s.enginesize =0.5;
            s.enginesize = 1200+100*0.5;
            s.topspeed =45;
            s.accerelation = 200;
            s.quartermiletime =21312312;


            Console.WriteLine("Tervetuloa kisaamaan hienoilla autoilla ");
            Console.WriteLine("\nAuton valinta\n");
            Console.WriteLine("[1]Toyota\n[2]Audi\n[3]Opel\n[4]Nissan\n[5]SHITroeen");
            int val = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            switch (val)
            {
                case 1:
                    Console.WriteLine("Valitsit TOYOTAN JIPPII");
                    Console.WriteLine(Toyota.ToString());
                    break;
                case 2:
                    Console.WriteLine("Valitsit AUDIN... ihan ok");
                    Console.WriteLine(A.ToString());
                    break;
                case 3:
                    Console.WriteLine("Painoit varmaan vaaraa nappulaa\nKoska valitsin OPEL");
                    Console.WriteLine(o.ToString());
                    break;
                case 4:
                    Console.WriteLine("Valitsin NISSAN hyva valinta");
                    Console.WriteLine(n.ToString());
                    break;
                case 5:
                    Console.WriteLine("MITA VITTUA VALITSIT SHITROENIN.......");
                    Console.WriteLine(s.ToString());
                    Console.WriteLine("Talla autolla ei ole viivoille mitaan asiaa...");
                    return;
                    break;
            }
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Nyt kun auto on valittu voidaan siirtya viivoille");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Tervetuloa Hallin lentokentalle\aja autosi lahtoviivalle");
            int gra0 = 0;
            int gra1 = 0;
            int gra2 = 0;
            int gra3 = 0;
            int gra4 = -3;
            

            for (int i = 0; i < 17; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                gra0++;
                gra1++;
                gra2++;
                gra3++;
                gra4++;
                Console.WriteLine("\n-------Viivat-------");
                Console.Write("Toyota    >");
                for (int h = 1; h <= gra0; h++)
                {
                    Console.Write("****");
                }
                Console.Write("\nAudi      >");
                for (int a = 1; a <= gra1; a++)
                {
                    Console.Write("**");
                }
                Console.Write("\nOpel      >");
                for (int b = 1; b <= gra2; b++)
                {
                    Console.Write("*");
                }
                Console.Write("\nNissan    >");
                for (int c = 1; c <= gra3; c++)
                {
                    Console.Write("***");
                }
                Console.Write("\nShietroen >");
                for (int d = 1; d <= gra4; d++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("TOYOTA VOITTI HAAALLLEEE LUUUJAAA!!!");








            /*   Console.WriteLine("Moi pojat!");
               Console.WriteLine("Miten kaikilla menee\tama softa ei tee yhtaan mitaan jarkevaa");
               Console.WriteLine("Anna onnen numerosi :3 >");
               int input = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Jarjestelman pitaa hetkenaikaa miettia lukuasi se on todella jannittava");
               System.Threading.Thread.Sleep(4000);
               Console.WriteLine("Numerosi on: " + input);
               System.Threading.Thread.Sleep(1000);
               int icon = 1;
               for (int i=0; i < input; i++)
               {
                   Console.WriteLine(icon);
                   System.Threading.Thread.Sleep(110);
                   icon++;
               }*/
        }
    }
}
