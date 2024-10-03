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

            mainmenu.AddMenuItem("RANDOMISE LIST OF DOUBLES (10 VALUES)", "TenDoubles", typeof(Program));
            mainmenu.AddMenuItem("PRINT LIST OF DOUBLES", "PrintListOfDoubles", typeof(Program));
            mainmenu.AddMenuItem("PERFORM BUBBLE SORT ALGORITHM", "PerformBubble", typeof(Program));

            mainmenu.RunForever();
            Console.ReadKey();

        }


        public static void PerformBubble()
        {
            Console.WriteLine("\nPERFORMING BUBBLE SORT...");
            BubbleSort.Perform(listOfDoubles);
            Console.WriteLine("SORT COMPLETED");
        }

        public static void TenDoubles()
        {
            Console.WriteLine("\nPOPULATING LIST WITH RANDOM NUMBERS...");
            PopulateListWithRandomDoubles(10);
            Console.WriteLine("LIST POPULATED");
        }

        static void PopulateListWithRandomDoubles(int size)
        {
            listOfDoubles.Clear();

            for (int i = 0; i < size; i++)
            {
                double twoDigitDouble = Double.Parse(randomGenerator.NextDouble().ToString("0.00000"));
                listOfDoubles.Add(twoDigitDouble);
            }
        }

        public static void PrintListOfDoubles()
        {
            Console.WriteLine("\n\nLIST PRINT:\n");

            for (int i = 0; i < listOfDoubles.Count; i++)
            {
                Console.WriteLine("  " + i + "  " + listOfDoubles[i].ToString());
            }

            Console.WriteLine("\nEND \n");
        }
    }
}
