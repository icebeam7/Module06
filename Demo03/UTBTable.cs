using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Newtonsoft.Json;

namespace Demo03
{
    public class UTBTable<T> 
         // where T : Student, new() // only student and derived instances
        //where T : struct // only primitive values or structs
        // where T : class // only classes
        // where T : new() // only classes with parameterless constructor
    {
        public List<T> Data;
        private string name;

        public UTBTable(string name)
        {
            this.name = name;
            this.Data = new List<T>();
        }

        public void Add(T item)
        {
            Data.Add(item);
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(Data);
            File.WriteAllText(name + ".txt", json);
        }

        public void Read()
        {
            string json = File.ReadAllText(name + ".txt");
            Data = JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
