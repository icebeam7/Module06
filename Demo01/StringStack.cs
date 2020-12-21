using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01
{
    public class StringStack
    {
        private readonly string[] data;
        private int position = 0;

        public StringStack(int capacity)
        {
            data = new string[capacity];
            position = 0;
        }

        public void Push(string item)
        {
            data[position++] = item;
        }

        public string Pop()
        {
            string item = data[--position];
            return item;
        }

        public bool HasData()
        {
            return position > 0;
        }

        public void Clear()
        {
            for (int i = 0; i < data.Length; i++)
                data[i] = string.Empty;

            position = 0;
        }
    }
}
