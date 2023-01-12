﻿using System.ComponentModel.Design;

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

        static public bool HasArgument(string inputCommand, string expected)
        {
            string command = inputCommand.Trim();
            if (command == "") return false;
            else
            {
                string[] cmdWords = command.Split(' ');
                if (cmdWords.Length < 2) return false;
                if (cmdWords[1] == expected) return true;
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
                if (Program.CommandString(command, "help"))
                {
                    Console.WriteLine("help - display this help text");
                    Console.WriteLine("load /file/ - load a todo list");
                    Console.WriteLine("quit - quit the program");

                }
                else if (Program.CommandString(command, "load"))
                { 
                    //NYI: load file.lis - Usage: load /file/
                    Console.WriteLine("load file.lis");
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