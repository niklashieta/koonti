using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            lappari lap = new lappari();
            puhelin puh = new puhelin();
            tietokone kone = new tietokone();

            kone.Name = "tehomylly";
            kone.Type = "v.sata";
            kone.CPU = "Intel i7-7700k";
            kone.GPU = "Nvidia GTX 1080TI";
            kone.RAM = "kingston 16gb DDR4";
            kone.Storage = "Full SSD";
            kone.Strorageam = 913901293120391203;

            puh.Name = "Huawei";
            puh.Type = "P10";
            puh.CPU = "Kzasnzora v.2031";
            puh.Naytonkoko = "5.7tuuma";
            puh.Akku = 4990;
            puh.Resoluutio = 1920.1080;

            lap.Name = "HOOPEEE";
            lap.Type = "Zbook zyryzyyy";
            lap.CPU = "Intel Xeon";
            lap.GPU = "GTX 1080 SLI";
            lap.Akku = "89wh lithium";
            lap.Nayttores = 4210.2501;

            Console.WriteLine("Kalle elaintenystava esittelee teille tavaroitaan =)");
            Console.WriteLine("Kallen poytakone on imenyt seuraavat asiat: ");
            Console.WriteLine(kone.Name + " " + kone.Type + "\n"
                + kone.CPU + "  " + kone.GPU + " \n" + kone.RAM + "  " + kone.Storage + "  " + kone.Strorageam + "GB");
            Console.WriteLine("Kallen puhelin on: ");
            Console.WriteLine(puh.Name + " " + puh.Type + "\n" +
                puh.CPU + " Prosessori  " + puh.Naytonkoko + "  " + puh.Akku + "mAH " + puh.Resoluutio + "Pxl");
            Console.WriteLine("Kallen lappari on: ");
            Console.WriteLine(lap.Name + " " + lap.Type + " " + lap.CPU + " " + lap.GPU + " " + lap.Akku + " " + lap.Nayttores + "Pxl");
            Console.WriteLine("tassa oli kallen setup");
        }
    }
}