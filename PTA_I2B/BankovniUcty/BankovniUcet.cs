using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTA_I2B.BankovniUcty
{
    internal class BankovniUcet
    {
        public decimal Penize { get; private set; }
                                                   
         //Metody vklad a výběr pracují s metodou SET                                         
        public void Vklad(decimal kolik)
        {
            if (kolik > 0)
            {
                Penize += kolik;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Připsáno na účet {0:c}", kolik);
                Console.ResetColor();
            }
        }

        public void Vyber(decimal kolik)
        {
            if ((Penize - kolik >= 0) && (kolik > 0)) // && - logický AND
            {
                Penize -= kolik;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Výběr z účtu {0:c}", kolik);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nedostatek prostředků!");
                Console.ResetColor();
            }
        }

        //konstruktor
        public BankovniUcet(decimal penize = 0)
        {
            Penize = penize;
        }
    }
}
