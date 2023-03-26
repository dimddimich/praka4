using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praka4_1
{
    internal class Program
    {
        class Order // 2 задание
        {
            public int Weight { get; set; }
            public string Desc { get; set; }

            public Order(string desc, int weight)
            {
                Desc = desc;
                Weight = weight;
            }

            public void Use()
            {
                Console.WriteLine(Desc);
            }
        }

        class ServiceD
        {
            public int Weight { get; private set; }
            public ServiceD(int weight)
            {
                Weight = weight;
            }



            public void MakeDel(Order order)
            {
                if ((Weight + order.Weight) <= 100)
                {
                    Console.Write("Отправить: ");
                    Weight += order.Weight;
                    order.Use();
                }

                else
                {
                    Console.WriteLine("Ваша посылка много весит!");
                }
            }
        }
        static void Main(string[] args)
        {
            Order sneakers = new Order("тапки", 50);
            Order wheels = new Order("колеса", 40);
            ServiceD service1 = new ServiceD(30);

            service1.MakeDel(sneakers);
            service1.MakeDel(wheels);
            Console.ReadKey(true);
        }
    }
}