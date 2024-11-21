using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewriteRPG.Items
{
    internal class Item : Stats, IComparable<Item>
    {
        public Item(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public string? ItemSlot { get; set; }
        public int ItemLevel { get; set; }
        public string Rarety { get; set; } = "poor";

        public int CompareTo(Item? other)
        {
            return this.Name.CompareTo(other.Name);
        }

    }

}
