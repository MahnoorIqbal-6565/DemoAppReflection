using System;
using System.Reflection;
using DemoAppReflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Type type =typeof(SampleClass);

            Console.WriteLine($"Class Name: {type.Name}\n");

            //Displaying for Constructors
            Console.WriteLine("Constructors");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }
            Console.WriteLine();

            //Display Properties
            Console.WriteLine("Properties");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine();

            //Display metadata of utilizinhg the correct metadata the reflection method
            Console.WriteLine("Methods");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }


}

