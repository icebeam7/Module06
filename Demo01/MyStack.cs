using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01
{
    public class MyStack
    {
        private readonly int[] data;
        private int position = 0;

        public MyStack(int capacity)
        {
            data = new int[capacity];
            position = 0;
        }

        public void Push(int item)
        {
            data[position++] = item;
        }

        public int Pop()
        {
            int item = data[--position];
            return item;
        }

        public bool HasData()
        {
            return position > 0;
        }

        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
                data[i] = 0;

            position = 0;
        }
    }
}
