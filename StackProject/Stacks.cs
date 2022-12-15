using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace LinkledlistProject
    {
        internal class Stacks/*Stack represents a last-in, first out collection of object. 
                          * It is used when you need a last-in, first-out access to items. When you add an item in the list,
                          * it is called pushing the item and when you remove it, it is called popping the item. This class comes under System.Collections namespace.*/
        {
            Node top;
            public Stacks()
            {
                this.top = null;
            }
            public void Push(int data)//Inserts an object at the top of the Stack.
            {
                Node node = new Node(data);
                if (top == null)
                {
                    node.next = null;
                }
                else
                {
                    node.next = this.top;// asigning top value to node.next
                }
                this.top = node;
                Console.WriteLine("{0} pushed to stack", data);
            }
            public void Display()
            {
                Node temp = this.top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
            public void Peek()//Returns the object at the top of the Stack without removing it.
            {
                if (this.top == null)
                {
                    Console.WriteLine("Stack is Empty");
                }
                else
                {
                    Console.WriteLine("{0} is in the top of stack", top.data);
                }
            }
            public void Pop()//Removes and returns the object at the top of the Stack.
            {
                if (this.top == null)
                {
                    Console.WriteLine("Stack is Empty deletion is nopt possible");
                }
                else
                {
                    Console.WriteLine("values popped is {0}", top.data);
                    top = top.next;
                }
            }
        }
    }
}

