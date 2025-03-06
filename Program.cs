using System;
using System.Reflection;
using DemoAppReflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Reflection
            Type type = typeof(SampleClass);
            object instance = Activator.CreateInstance(type);
        
            MethodInfo method = type.GetMethod("LoadData");

            if (method != null)
            {
                
                method.Invoke(instance, new object[] { 1 });
            }

            MethodInfo getDataMethod = type.GetMethod("GetData");

            if (getDataMethod != null)
            {
                string result = (string)getDataMethod.Invoke(instance, null);
                Console.WriteLine($"[Reflection Call] Data: {result}");
            }

            //Using Object call
            SampleClass obj = new SampleClass();
            obj.LoadData(1);
            string result1 = obj.GetData();
            Console.WriteLine($"[Direct Call] Data: {result1}");
        }

    }
}
