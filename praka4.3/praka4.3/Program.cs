using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praka_4_3
{
    internal class programma
    {

        class Orcs
        {
            public int Gold { get; set; }
            public int Quantity { get; set; }
            public Orcs(int gold, int quantity)
            {
                Gold = gold;
                Quantity = quantity;
            }
            public void inc()
            {
                Quantity++;
                Gold += 2;
                if (Quantity > 5)
                {
                    Gold += 2 * (Quantity - 5);

                }
                Console.WriteLine("Получено " + Gold + " золота");
            }

        }

        static void Main(string[] args)
        {
            Orcs army = new Orcs(0, 1);
            for (int i = 1; i < 20; i++)
            {
                army.inc();
            }
            Console.ReadKey(true);
        }
    }
}
