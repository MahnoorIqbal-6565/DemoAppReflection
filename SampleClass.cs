using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppReflection
{
    public class SampleClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SampleClass() { }
        public SampleClass(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }
}
