using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoConsoleApp
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " ma " + Cash + " zł.");
        }

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " mówi: " + amount + " nie jest poprawną kwotą.");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " mówi: " + "nie mam wystarczających środków, żeby dać Ci " + amount + " zł.");
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
                Console.WriteLine(Name + " mówi: " + "nie przyjmę " + amount + " zł.");
            else
                Cash += amount;
        }

    }

}
