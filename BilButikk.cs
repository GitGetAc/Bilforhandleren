using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    internal class BilButikk
    {
        public List<Bil> biler;

        public BilButikk()
        {
            biler = new List<Bil>();
            LeggeTilBiler();
        }

        private void LeggeTilBiler()
        {
            Bil bil1 = new("Ford", 1980, "rtrre123", 233322);
            Bil bil2 = new("Toyota", 1955, "cxrre23", 153322);
            Bil bil3 = new("Nissan", 1999, "858fff", 322);
            Bil bil4 = new("Mazda", 1985, "345jjf", 233453322);
            Bil bil5 = new("Suzuki", 2010, "rtrre123", 3322);

            biler.Add(bil1);
            biler.Add(bil2);
            biler.Add(bil3);
            biler.Add(bil4);
            biler.Add(bil5);
        }

        public void BilListePrintInfo()
        {
            foreach(Bil bil in biler)
            {
                Console.WriteLine(bil.ToString());
            }
            Console.WriteLine("");
        }

    }
}
