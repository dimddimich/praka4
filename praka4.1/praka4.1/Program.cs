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
    internal class programma
    {
        class Spell // 1 задание
        {
            public int Mana { get; private set; }
            public string Effect { get; set; }


            public Spell(int mana, string effect)
            {
                Mana = mana; Effect = effect;

            }

            public void Use()
            {


                Console.WriteLine(Effect);
            }
        }

        class Magician
        {
            public string Name { get; private set; }
            public int Mana { get; private set; }

            public Magician(string name, int mana)
            {
                Name = name;
                Mana = mana;
            }

            public void CastSpell(Spell spell)
            {
                if (Mana >= spell.Mana)
                {
                    Console.Write($"{Name} колдует! ");
                    spell.Use();
                    Mana -= spell.Mana;
                }

                if (Mana < spell.Mana)
                {
                    Console.WriteLine("Для использования: " + spell.Effect
                    + ", не хватает: " + Mana + " маны. Хлебните зелья!");

                }
            }
        }
        static void Main(string[] args)
        {
            Spell alohomora = new Spell(60, "Замок открывается!");
            Spell vingardiumLeviosa = new Spell(60, "Предмет поднимается в воздух!");
            Magician garryPotter = new Magician("Гарри Поттер", 100);
            garryPotter.CastSpell(alohomora);
            garryPotter.CastSpell(vingardiumLeviosa);

            Console.ReadKey(true);
        }
    }
}