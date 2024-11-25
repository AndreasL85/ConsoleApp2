using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error '{e.Message}'");
            }
        }
    }
}
