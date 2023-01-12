using System.ComponentModel.Design;

namespace DTP_D17_hemtentamen
{
    internal class Program
    {
        static public string ReadCommand(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static public bool CommandString(string inputCommand, string expected)
        {
            string command = inputCommand.Trim();
            if (command == "") return false;
            else
            {
                string[] cmdWords = command.Split(' ');
                if (cmdWords[0] == expected) return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the todo list, write 'help' for help!");
            string command;
            do
            {
                command = Program.ReadCommand(">");
                if(Program.CommandString(command, "help"))
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