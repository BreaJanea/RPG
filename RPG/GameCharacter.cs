using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class GameCharacter
    {
        protected string name;
        protected int strength;
        protected int intelligence;

        public string Name { get => name; set => name = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
        }

        public virtual string Play()
        {
            return $"{name} (strenght {strength}, int {intelligence})";
        }
    }
}
