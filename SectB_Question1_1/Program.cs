namespace SectB_Question1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Structure of a C# Program Demo!");


            string name = "";

            while (true)
            {
                Console.Write("Enter your name: ");

                name = Console.ReadLine();

                if (String.IsNullOrEmpty(name))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Hello, {name}!\n");

            Console.WriteLine("Program Structure Demonstrated:\n1. using System : imports functionality\n2. namespace : organizes code\n3. class Program : container for code\n4. Main() : entry point of program\n5. Comments : explain the logic and documentation");
        }
    }
}
