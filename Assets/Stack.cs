using System;
using System.Collections.Generic;
using System.Text;


namespace Stacks
{
    public class Stack<T>
    {
        List<T> contents = new List<T>();
        //constructer
        public Stack()
        {

        }

        //gets the number of items in stack
        public int Count
        {
            get { return contents.Count; }
        }

        //push method

        public void Push(T item)
        {
            contents.Add(item);
        }
        
        //pop method

        public T pop()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant pop from a stack");
            }
            else
            {
                //retrieve top of stack, remove and return

                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count - 1);
                return item;
            }
        }

        //Peekmethod

        public T Peek()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant peek from a stack");
            }
            else
            {
                return contents[contents.Count - 1];
            }
        }
    }
}

