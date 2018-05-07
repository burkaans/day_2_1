using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labdien, ievadiet savu dzimšanas gadu");
            String gads;
            gads = Console.ReadLine();
            Console.WriteLine("kurā mēnesī esat dzimis?");
            String menesis;
            menesis = Console.ReadLine();
            Console.WriteLine("un visbeidzot, dzimšanas datums");
            String diena;
            diena = Console.ReadLine();
            Console.WriteLine("Jūs esat dzimis " + gads + ". gada " + diena + ". " + menesis + "! Visu labu!");
            Console.WriteLine("bithub tests");


            Console.ReadLine();

        }
    }
}
