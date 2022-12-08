using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{

    public static class TestExtension
    {
        public static  T ExtensionSum<T> (this IEnumerable<T> items, IAdder<T> adder) 
        {
            T count = adder.Zero;
            
            foreach (var item in items)
            {
                count = adder.Add(count,item);
            }
            return count;
        }   
    }
    
    public interface IAdder<T>
    {
        T Zero { get; }

        T Add(T a, T b);
    }
    
    public class Int32Adder : IAdder<Int32>
    {
        public int Zero { get { return 0; } }

        public int Add(int a, int b) { return a + b; }
    }
    public class FloatAdder : IAdder<float>
    {
        
        public float Zero { get { return 0; } }

        public float Add(float a, float b) { return a + b; }
    }
    public class StringAdder : IAdder<string>
    {
        
        public string Zero { get { return default; } }

        public string Add(string a, string b) { return a + b; }
    }
}