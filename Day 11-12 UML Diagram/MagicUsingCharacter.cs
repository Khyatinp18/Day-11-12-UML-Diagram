using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_12_UML_Diagram
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter()
        {

        }
        public MagicUsingCharacter(string _name, int _strenght, int _intelligence, int magicalEnergy)
        {
            Name = _name;
            Strength = _strenght;
            Intelligence = _intelligence;
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy : {MagicalEnergy}");
        }
    }
}
