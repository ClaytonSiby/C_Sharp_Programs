using System;

namespace LanguageBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Clayton";
            Console.WriteLine($"How old are you, {name}? >> ");
            string age = Console.ReadLine();
            Console.WriteLine($"So {name} you're {Convert.ToInt32(age)} years old.");
        }
    }
}
