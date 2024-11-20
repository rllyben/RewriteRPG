using RewriteRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RewriteRPG
{
    internal class Utils
    {
        public static void RenderMenue(string[] options, int selectedIndex)
        {
            for (int count = 0; count < options.Length; count++)
            {
                if (count == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(options[count]);
                    Console.ResetColor();
                }
                else
                    Console.WriteLine(options[count]);
            }

        }
        public static int UpdateSelection(int currentSelection, ConsoleKey key, string[] options)
        {
            switch (key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    return currentSelection == 0 ? 0 : --currentSelection;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    return currentSelection == options.Length - 1 ? options.Length - 1 : ++currentSelection;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.D1:
                    return currentSelection = 0;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                case ConsoleKey.End:
                case ConsoleKey.Escape:
                    return currentSelection = options.Length - 1;
                default:
                    return currentSelection;
            }

        }
        public static void SaveHero(Hero hero)
        {
            string filePath = $"player_hero.json";
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string jsonData = JsonSerializer.Serialize(hero, options);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine($"Hero saved to {filePath}");
        }
        public static Hero LoadHero(string name)
        {
            string filePath = $"{name}_hero.json";

            if (!File.Exists(filePath))
            {
                throw new Exception("Hero not found!");
            }
            string jsonData = File.ReadAllText(filePath);

            Hero hero = JsonSerializer.Deserialize<Hero>(jsonData);

            foreach (var kvp in hero.EquiptItems)
            {
                // Find the item in the hero's inventory by item name
                var inventoryEntry = hero.Inventory.FirstOrDefault(entry => entry.Item.Name == kvp.Value.Name);
                if (inventoryEntry != null)
                {
                    hero.UnEquipItem(inventoryEntry);
                    hero.EquipItem(inventoryEntry);
                }

            }
            return hero;
        }

    }

}
