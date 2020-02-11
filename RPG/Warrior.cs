using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Warrior : GameCharacter
    {
        private string weaponType;

        public string WeaponType { get => weaponType; set => weaponType = value; }

        public Warrior(string name, int strength, int intelligence, string weaponType)
            : base (name, strength, intelligence)
        {
            this.weaponType = weaponType;
        }

        public override string Play()
        {
            return $"{name} (strength {strength}, int {intelligence}) {weaponType}";
        }
    }
}
