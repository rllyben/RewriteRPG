using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewriteRPG
{
    internal class Stats : Attributes
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Defense { get; set; }
        public int MinMagicalDamage { get; set; }
        public int MaxMagicalDamage { get; set; }
        public int MagicalDefense { get; set; }
        public int MaxHealth { get; set; }
        public float ActionSpeed { get; set; } = 0.5F;
        public float CritChance { get; set; }
        public float BlockChance { get; set; }
        public int MaxManaPoints { get; set; }
        public int Evasion { get; set; }
        public int Aim { get; set; }

        public Stats() { }

    }

}
