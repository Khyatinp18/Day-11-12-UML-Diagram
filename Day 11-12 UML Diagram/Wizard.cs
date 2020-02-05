using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_12_UML_Diagram
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string _name, int _strenght, int _intelligence, int _magicalEnergy, int _spellNumber)
        {
            Name = _name;
            Strength = _strenght;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
            SpellNumber = _spellNumber;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number : {SpellNumber}");
        }
    }
}
