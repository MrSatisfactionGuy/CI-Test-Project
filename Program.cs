using CI_Test_Project.Classes;

namespace CI_Test_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a Calculator!");

            string stringEIns = string.Empty;
            string stringZwei = string.Empty;

            Console.WriteLine("Gebe erste Zahl ein:");
            stringEIns = Console.ReadLine();
            Console.WriteLine("Gebe zweite Zahl ein:");
            stringZwei = Console.ReadLine();

            int eins = int.Parse(stringEIns);
            int zwei = int.Parse(stringZwei);

            Add add = new Add();

            int res = add.Sum(eins, zwei);
            Console.WriteLine(res);
        }
    }
}
