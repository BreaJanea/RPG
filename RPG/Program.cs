using System;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!");
            Console.WriteLine();
            Warrior warrior1 = new Warrior("Tnarg the Barbarian", 9, 16, "Axe");
            Warrior warrior2 = new Warrior("Knicaid the Fighter", 16, 15, "Longwood");
            Warrior warrior3 = new Warrior("Grant the Vikin", 16, 15, "Spear");
            Wizard wizard = new Wizard("Lady Witherell the Wizard", 18, 1, 5);
            Wizard wizard2 = new Wizard("Pearl the Magician", 17, 12, 4);


            List<GameCharacter> character = new List<GameCharacter>();
            character.Add(warrior1);
            character.Add(warrior2);
            character.Add(warrior3);
            character.Add(wizard);
            character.Add(wizard2);

            foreach (GameCharacter gc in character)
            {
                Console.WriteLine(gc.Play());
            }
        }
    }
}
