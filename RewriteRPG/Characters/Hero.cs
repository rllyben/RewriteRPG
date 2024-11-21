using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RewriteRPG.Exceptions;
using RewriteRPG.Items;

namespace RewriteRPG.Characters
{
    internal class InventoryEntry : IComparable<InventoryEntry>
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public InventoryEntry(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }

        public int CompareTo(InventoryEntry? other)
        {
            return this.Item.Name.CompareTo(other.Item.Name) ;
        }

    }
    internal class Hero
    {
        public static Hero MyHero;
        public List<InventoryEntry> Inventory { get; set; }
        public Dictionary<string, Item> EquiptItems { get; set; }
        public Character Character { get; set; } = new();
        public Stats CurrentStats { get; set; } = new();
        public Stats CurrentItemStats { get; set; } = new();
        public Hero(string name) 
        {
            CurrentStats = new Stats();
            CurrentItemStats = new Stats();
            Character = new Character();

            Character.Name = name;
            Character.Level = 1;
            MyHero = this;
        }

        public override string ToString()
        {
            return Character.Name;
        }
        public float GetAvtionSpeed()
        {
            return CurrentItemStats.ActionSpeed; 
        }
        public int GetLevel() 
        {
            return Character.Level;
        }
        public int GetDefence()
        {
            return CurrentStats.Defense + CurrentItemStats.Defense;
        }
        public int GetMagicalDefence()
        {
            return CurrentStats.MagicalDefense + CurrentItemStats.MagicalDefense;
        }
        public int GetMinPhysicalDamage()
        {
            return CurrentStats.MinDamage + CurrentItemStats.MinDamage;
        }
        public int GetMaxPhysicalDamage()
        {
            return CurrentStats.MaxDamage + CurrentItemStats.MaxDamage;
        }
        public int GetRandomMinPysicalDamage()
        {
            Random rnd = new();
            int damage = (rnd.Next((CurrentStats.MinDamage + CurrentItemStats.MinDamage), (CurrentStats.MaxDamage + CurrentItemStats.MaxDamage + 1)));
            return damage;
        }
        public int GetMinMagicalDamage()
        {
            return CurrentStats.MinMagicalDamage + CurrentItemStats.MinMagicalDamage;
        }
        public int GetMaxMagicalDamage()
        {
            return CurrentStats.MaxMagicalDamage + CurrentItemStats.MaxMagicalDamage;
        }
        public int GetRandomMagicalDamage()
        {
            Random rnd = new();
            int damage = (rnd.Next((CurrentStats.MinMagicalDamage + CurrentItemStats.MinMagicalDamage), (CurrentStats.MaxMagicalDamage + CurrentItemStats.MaxMagicalDamage + 1)));
            return damage;
        }
        public int GetAim()
        {
            return CurrentStats.Aim + CurrentItemStats.Aim;
        }
        public int GetEvation()
        {
            return CurrentStats.Evasion + CurrentItemStats.Evasion;
        }
        public void GetHPStones(int amount)
        {
            Character.HPStones += amount;
        }
        public void GetMPStones(int amount)
        {
            Character.MPStones += amount;
        }
        public void UseHPStone()
        {
            Character.HPStones--;
            Character.CurrentHealth += (Character.MaxHealth / 20);
        }
        public void UseMPStone()
        {
            Character.MPStones--;
            Character.ManaPoints += (Character.MaxManaPoints / 20);
        }
        public void PrintAllStats()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n\t{this.ToString()}   Level: {GetLevel()}");
            Console.ResetColor();
            Console.WriteLine($"\n\tHP: {Character.CurrentHealth} / {Character.MaxHealth}        MP: {Character.ManaPoints} / {Character.MaxManaPoints}" +
                              $"\n\tDamage: {GetMinPhysicalDamage()} ~ {GetMaxPhysicalDamage()}" +
                              $"\n\tMagical Damage: {GetMinMagicalDamage()} ~ {GetMaxMagicalDamage()}" +
                              $"\n\tEvation: {GetEvation()}" +
                              $"\n\tAim: {GetAim()}" +
                              $"\n\tDefance: {GetDefence()}" +
                              $"\n\tMagical Defance: {GetMagicalDefence()}" +
                              $"\n\tAction Speed: {GetAvtionSpeed()}\n" +
                              $"\n\nFree Statpoints: {Character.StatPoints}");
            Console.WriteLine();
            Console.ReadKey();
        }
        public void EquipItem(InventoryEntry item)
        {
            if (item == null || item.Quantity < 1)
                throw new NonOfThatItemException("Does not have that item!");
            if (item.Item.ItemLevel > Character.Level)
                throw new LevelToLowException("Character Level is to low!");
            if (item.Item.ItemSlot == null)
                throw new NonEquipableItemException("Item is not Equipable!");
            if (EquiptItems.ContainsKey(item.Item.ItemSlot) && EquiptItems[item.Item.ItemSlot] != null && item.Item.ItemLevel <= Character.Level)
                UnEquipItem(item);


        }
        public void UnEquipItem(InventoryEntry item)
        {

        }

    }

}
