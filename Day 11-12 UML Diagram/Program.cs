using System;

namespace Day_11_12_UML_Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gamecharacter = new GameCharacter[]
            {
               new Warrior("King", 20, 30, "Sword"),
               new Warrior("Knight", 22, 12, "Spear"),
               new Wizard("Max", 13, 9, 10, 16),
               new Wizard("Joe", 30, 19, 10, 7),
               new Wizard("Moe", 13, 8, 10, 16)

            };

            foreach (var character in gamecharacter)
            {
                character.Play();
                Console.WriteLine();
            }

        }
    }
}
