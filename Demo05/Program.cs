using System;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> stack = new GenericStack<int>(5);
            stack.Push(5);
            stack.Push(-3);
            stack.Push(7);

            while (stack.HasData())
            {
                int item = stack.Pop();
                Console.WriteLine(item);
            }

            GenericStack<string> countries = new GenericStack<string>(5);
            countries.Push("Czech Republic");
            countries.Push("France");
            countries.Push("Mexico");

            while (countries.HasData())
            {
                Console.WriteLine(countries.Pop());
            }

        }
    }
}
