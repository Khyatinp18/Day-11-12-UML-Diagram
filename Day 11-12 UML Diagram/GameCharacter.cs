using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_12_UML_Diagram
{
    abstract class GameCharacter
    {
       
        public string Name { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

       



        public virtual void Play()
        {
            Console.WriteLine($"Character Name: {Name}");
            Console.WriteLine($"Character Strength: {Strength}");
            Console.WriteLine($"Character Intelligence: {Intelligence}");
        }
    }
}
