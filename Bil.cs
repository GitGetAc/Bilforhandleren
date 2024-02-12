using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    internal class Bil
    {
        private string PMerke;
        private int PÅrsmodell;
        private string PRegistreringsNummer;
        private int PKilometerStand;

        public Bil(string merke, int årsmodell, string registreringsNummer, int kilometerstand)
        {
            Merke = merke;
            Årsmodell = årsmodell;
            RegistreringsNummer = registreringsNummer;
            KilometerStand = kilometerstand;
        }

        public string Merke { get => PMerke; set => PMerke = value; }
        public int Årsmodell { get => PÅrsmodell; set => PÅrsmodell = value; }
        public string RegistreringsNummer { get => PRegistreringsNummer; set => PRegistreringsNummer = value; }
        public int KilometerStand { get => PKilometerStand; set => PKilometerStand = value; }


        public override string ToString()
        {
            return $"{Merke} {Årsmodell} {RegistreringsNummer} {KilometerStand}";
        }
    }
}