using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_12_UML_Diagram
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string _name, int _strenght, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strenght;
            Intelligence = _intelligence;
            WeaponType = _weaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type : {WeaponType}");
        }
    }

}
