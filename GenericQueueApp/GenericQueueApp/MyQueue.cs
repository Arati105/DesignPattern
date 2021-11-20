using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp
{
    public class MyQueue<T> : IQueue<T>
    {
        private LinkedList<T> _items = new LinkedList<T>();

        public int Count()
        {
            return _items.Count;
        }
        public T Dequeue()
        {
            var value = _items.First.Value;
            _items.RemoveFirst();
            return value;
        }
        public void Enqueue(T data)
        {
            _items.AddLast(data);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }


    }

   
}
