using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Wizard : GameCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int spellNumber)
            : base (name, strength, intelligence)
        {
            this.spellNumber = spellNumber;
        }

        public override string Play()
        {
            return $"{name} (strength {strength}, int {intelligence}) {spellNumber} spells";
        }
    }
}
