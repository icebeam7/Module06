using System;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStore<int> store = new DataStore<int>();
            store.Data = 100;

            Console.WriteLine("Store value: " + store.Data);
            Console.WriteLine("Store type: " + store.Data.GetType().FullName);

            DataStore<string> countries = new DataStore<string>();
            countries.Data = "Czech Republic";

            Console.WriteLine("Countries value: " + countries.Data);
            Console.WriteLine("Countries type: " + countries.Data.GetType().FullName);

            Employee worker = new Employee();
            worker.Name = "Jan";
            worker.Salary = 1000;

            DataStore<Employee> company = new DataStore<Employee>();
            company.Data = worker;

            Console.WriteLine("Company value: " + company.Data);
            Console.WriteLine("Company type: " + company.Data.GetType().FullName);

            Console.ReadKey();
        }
    }
}
