namespace SortingAlgorithms
{
    internal class Program
    {

        static Random randomGenerator = new Random();
        static List<double> listOfDoubles = new List<double>();

        static void Main(string[] args)
        {
            TenDoubles();
            MenuSystem mainmenu = new MenuSystem("Program");

            mainmenu.AddMenuItem("Randomise List of Doubles (10 Values)", "TenDoubles", typeof(Program));
            mainmenu.AddMenuItem("Print List of Doubles", "PrintListOfDoubles", typeof(Program));
            mainmenu.AddMenuItem("Perform a Bubble Sort", "PerformBubble", typeof(Program));

            mainmenu.RunForever();
            Console.ReadKey();

        }


        public static void PerformBubble()
        {
            Console.WriteLine("Performing Bubble Sort...");
            BubbleSort.Perform(listOfDoubles);
            Console.WriteLine("Sort Completed");
        }
    }
    }
}
