using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace capstone_weak2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("\t\t\twelcome to Task manger");

            List<Task> Dasks = new List<Task>();

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("1. List tasks? ");
                Console.WriteLine("2. Add tasks? ");
                Console.WriteLine("3. delete tasks? ");
                Console.WriteLine("4. mark tasks complete ? ");
                Console.WriteLine("5. Quit ? ");
                var switcerh = Console.ReadLine();

                switch (switcerh)
                {
                    case "1":
                        foreach (Task item in Dasks)
                        {
                            item.PrintInfo();
                        }
                        break;

                    case "2":
                        Console.Write("please enter a task name? ");
                        string input1 = Console.ReadLine();
                        Console.WriteLine("please enter a discription of the task ? ");
                        string input2 = Console.ReadLine();
                        Console.WriteLine("enter a due DAte 00/00/000 please? ");
                        DateTime input3 = DateTime.Parse(Console.ReadLine());
                        Dasks.Add(new Task(input1, input2, input3));
                        break;

                    case "3":
                        for (int i = 0; i < Dasks.Count; i++)
                        {
                            Console.Write(i + 1 + ". ");
                            Dasks[i].PrintInfo();
                        }
                        Console.WriteLine("please select a number to delete ? ");
                        int input = int.Parse(Console.ReadLine());
                        Dasks.RemoveAt(input - 1);
                        break;

                    case "4":
                        Console.WriteLine("press zero to mark your task as finished ?");
                        int t = int.Parse(Console.ReadLine());
                        Dasks[t-1].TaskStatus = true;

                        break;
                    case "5":
                        repeat = false;
                        Console.WriteLine("tank you");
                        break;
                }
            }
        }
    }
}
