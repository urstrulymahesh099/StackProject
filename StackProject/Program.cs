using StackProject.LinkledlistProject;
using System;
using System.Collections.Generic;

namespace LinkledlistProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("click below options:\n1.Stacks");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Stacks stacks = new Stacks();
                        stacks.Push(10);
                        stacks.Push(20);
                        stacks.Push(30);
                        stacks.Peek();
                        stacks.Pop();
                        stacks.Display();
                        break;
                    default:
                        Console.WriteLine("try again ......");
                        break;
                }
            }
        }
    }
}
