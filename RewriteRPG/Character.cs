using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewriteRPG
{
    internal class Character
    {
        public string CharacterClass { get; set; }
        public string Name { get; set; }
        public int Cash { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int StatPoints { get; set; }
        public int CurrentHealth { get; set; }
        public int ManaPoints { get; set; }
        public bool RangedFighter { get; set; } = false;
        public int HPStones { get; set; }
        public int MPStones { get; set; }
        public int MaxManaPoints { get; set; }
        public int MaxHealth { get; set; }

        public Character() { }

    }

}
