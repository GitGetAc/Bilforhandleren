using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    internal class UI
    {
        BilButikk Bilsortiment {get; set;}
        Bil KjøptBil { get; set;}

        public UI()
        {
            Bilsortiment = new();
        }


        public void PersistentMenu()
        {
            int choice;

            do
            {
                Console.Clear();

                choice = ShowMenu();

                switch (choice)
                {
                    case 1: FinnBilÅrsrange(); break;
                    case 2: FinnBilKilometerStand(); break;
                    case 3: Kjøpe(); break;
                    case 4: Quit(); break;
                    default: Console.WriteLine("1-4!"); break;
                }

            } while (choice != 4);
        }

        public int ShowMenu()
        {
            Bilsortiment.BilListePrintInfo();
            Console.WriteLine("1. Finn bil etter årsrange");
            Console.WriteLine("2. Finn bil etter kilometerstand");
            Console.WriteLine("3. Kjøpe");
            Console.WriteLine("4. Quit");
            return Convert.ToInt16(Console.ReadLine());
        }

        public void FinnBilÅrsrange()
        {
            Console.WriteLine("Årsrange? Fra - til");
            int årsrangemin = Convert.ToInt32(Console.ReadLine()!);
            int årsrangemax = Convert.ToInt32(Console.ReadLine()!);

            foreach (var item in Bilsortiment.biler)
            {
                if(item.Årsmodell >= årsrangemin && item.Årsmodell <= årsrangemax)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadLine();
        }

        public void FinnBilKilometerStand()
        {
            Console.WriteLine("Kilometerstand?");
            int kilometermin = Convert.ToInt32(Console.ReadLine()!);
            int kilometermax = Convert.ToInt32(Console.ReadLine()!);

            foreach (var item in Bilsortiment.biler)
            {
                if(item.KilometerStand >= kilometermin && item.KilometerStand <= kilometermax)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadLine();
        }

        public void Kjøpe()
        {
            Console.WriteLine("Hvilken bil vil du kjøpe?");
            string BilNavn = Console.ReadLine()!;

            foreach (var bil in Bilsortiment.biler)
            {
                if (bil.Merke == BilNavn)
                {
                    KjøptBil = bil;
                    Bilsortiment.biler.Remove(bil);
                    break;
                }
            }
                Console.WriteLine($"Du kjøpte {KjøptBil.Merke} bilen fra forhandleren.\n");
                Console.WriteLine(KjøptBil.ToString());
                Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("Exciting...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
