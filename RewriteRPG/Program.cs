using RewriteRPG.Characters;

namespace RewriteRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new("Hyroka");
            while (StartMenue());
        }
        public static void PrintTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\u0009Myria Console RPG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
        }
        public static bool StartMenue()
        {
            int selection = 0;
            string[] menueOptions = { "Stats", "Adventure", "Shop", "Inventorry", "Save and Exit" };
            ConsoleKey selectionSwitch;

            do
            {
                PrintTitle();
                Console.WriteLine(" Start Menue");
                Utils.RenderMenue(menueOptions, selection);

                selectionSwitch = Console.ReadKey().Key;
                selection = Utils.UpdateSelection(selection, selectionSwitch, menueOptions);

            } while (selectionSwitch != ConsoleKey.Enter && selectionSwitch != ConsoleKey.Escape);

            switch (selection)
            {
                case 0: Hero.MyHero.PrintAllStats(); break;
                case 1: break;
                case 2: Shop(); break;
                case 3: break;
                case 4: return false;
            }
            return true;
        }
        public static void MainMenue()
        {
            int selection = 0;
            string[] menueOptions = { "Stats", "Start Menue", "Shop", "Inventorry", "Close", "Save and Exit" };
            ConsoleKey selectionSwitch;

            do
            {
                PrintTitle();
                Console.WriteLine(" Main Menue");
                Utils.RenderMenue(menueOptions, selection);

                selectionSwitch = Console.ReadKey().Key;
                selection = Utils.UpdateSelection(selection, selectionSwitch, menueOptions);

            } while (selectionSwitch != ConsoleKey.Enter && selectionSwitch != ConsoleKey.Escape);

            switch (selection)
            {
                case 0: Hero.MyHero.PrintAllStats(); break;
                case 1: break;
                case 2: Shop(); break;
                case 3: break;
                case 4: break;
                case 5: Thread.CurrentThread.Abort(); break;
            }

        }
        internal static void Shop()
        {
            PrintTitle();
            Console.WriteLine("The shop is currently unavailable!");
            Thread.Sleep(1000);
        }

    }

}
