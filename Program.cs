using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static string Name(string name)
        {
            string input = "Hello, " + name;
            return input;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string result = Name(name);
            
            Console.WriteLine(result);
        }
    }
}
