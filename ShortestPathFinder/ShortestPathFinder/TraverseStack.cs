using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathFinder
{
    internal class TraverseStack
    {
        private List<City> stack = new List<City>();
        private int top;
        private int max;

        public TraverseStack()
        {
            stack = new List<City>();
            top = -1;
            max = 10;
        }

        public void push(City element)
        {
            if (isFull() == false)
            {
                stack.Add(element);
                top++;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public City pop()
        {
            City city = new City();

            if (isEmpty() == false)
            {
                city = stack[top];
                stack.RemoveAt(top);
                top--;
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
            return city;
        }

        public bool isFull()
        {
            if (stack.Count == max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<City> getStack()
        {
            return this.stack;
        }
    }
}

