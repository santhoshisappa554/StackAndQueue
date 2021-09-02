using System;
using System.Collections.Generic;
using System.Text;
//using System;


namespace Queues
{
    public class Queues<T>
    {
        List<T> contents = new List<T>();
        //constructer
        public Queues()
        {

        }

        //gets the number of items in stack
        public int Count
        {
            get { return contents.Count; }
        }

        //enqueue method add item to the queue
        public void Enqueue(T item)
        {
            contents.Add(item);
        }
        //dequeue method removes ront item from queue and returns it

        public T Dequeue()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Cant remove from Queue");
            }
            else
            {
                //retrive front of queue, remove and return in front of it
                T item = contents[0];
                contents.RemoveAt(0);
                return item;
            }
        }
      
    }
}

