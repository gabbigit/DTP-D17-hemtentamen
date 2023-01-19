using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Collections.Generic;

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

        internal class TodoItem
        {
            public int status;
            public int priority;
            public string task;


            public TodoItem(int status, int priority, string task)
            {
                this.status = status;
                this.priority = priority;
                this.task = task;
            }

        }

     
        internal class Todo
        {
            public static List<TodoItem> todoList = new List<TodoItem>();

            public const int Active = 1;
            public const int Waiting = 2;
            public const int Completed = 3;
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
                    Console.Write("Add a new todo item to the list: ");
                    Console.Write("Priority?");
                    int priority = Int32.Parse(Console.ReadLine());
                    Console.Write("Task?");
                    string task = Console.ReadLine();
                    Console.Write("Status of the task?");
                    int status = Int32.Parse(Console.ReadLine());
                    List<TodoItem> todoList = new List<TodoItem>();
                    todoList.Add(new TodoItem(status,priority,task));
                    Console.WriteLine($"Added todo item: {priority} {status} {task}");
                    
                    
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