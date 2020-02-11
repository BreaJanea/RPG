﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy)
            : base (name, strength, intelligence)
        {
            this.magicalEnergy = magicalEnergy;
        }

        public override string Play()
        {
            return base.Play() + $"{name} (strength{strength}, int{intelligence}) {magicalEnergy} ";
        }
    }
}
