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
            Console.WriteLine($"Class Name:{type.Name}\n\n");

            //Displaying for Constructors

            Console.WriteLine("Constructors");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }
            Console.WriteLine();


            //Display metadata of utilizing the correct metadata the reflection method
           
            Console.WriteLine("Properties");
            PropertyInfo[] properties=type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine();

            //Display snout the metadata of the data

            Console.WriteLine("Methods");

            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
                ParameterInfo[] parameters = method.GetParameters();
                foreach(ParameterInfo parameter in parameters)
                {
                    Console.WriteLine(parameter.Name, parameter.ParameterType);
                }
            }
            Console.WriteLine();

            
        }
    }


}

