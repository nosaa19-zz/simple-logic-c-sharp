using SimpleCode.Service;
using System;

namespace SimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            String input, output;
            MainController mainController = new MainController();
            do
            {
                Console.Write("# ");
                input = Console.ReadLine();
                output = mainController.GetAdvances().InheritanceCase01();
                Console.WriteLine(output);
                Console.WriteLine();
            }
            while (input.ToLower() != "exit");
        }
    }
}
