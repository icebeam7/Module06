using System;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(5);
            stack.Push(5);
            stack.Push(-3);
            stack.Push(7);

            while(stack.HasData())
            {
                int item = stack.Pop();
                Console.WriteLine(item);
            }

            StringStack countries = new StringStack(5);
            countries.Push("Czech Republic");
            countries.Push("France");
            countries.Push("Mexico");

            while(countries.HasData())
            {
                Console.WriteLine(countries.Pop());
            }

            Console.ReadKey();
        }
    }
}
