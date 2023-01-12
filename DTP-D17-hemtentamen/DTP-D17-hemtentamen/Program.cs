using System.ComponentModel.Design;

namespace DTP_D17_hemtentamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the todo list, write 'help' for help!");
            string command;
            
            do
            {
                Console.Write(">");
                command = Console.ReadLine();
                if(command == "help")
                {
                    Console.WriteLine("help - display this help text");
                    Console.WriteLine("quit - quit the program");
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
            while (command != "quit");   
        }
    }
}