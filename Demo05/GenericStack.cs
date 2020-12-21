using System;
using System.Collections.Generic;
using System.Text;

namespace Demo05
{
    public class GenericStack<T>
    {
        private readonly T[] data;
        private int position = 0;

        public GenericStack(int capacity)
        {
            data = new T[capacity];
            position = 0;
        }

        public void Push(T item)
        {
            data[position++] = item;
        }

        public T Pop()
        {
            T item = data[--position];
            return item;
        }

        public bool HasData()
        {
            return position > 0;
        }

        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
                data[i] = default(T);

            position = 0;
        }
    }
}
