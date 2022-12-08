using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Int32Adder int32Adder = new Int32Adder();
            List<int> numbers= new List<int>{1, 2, 3, 4,};
            int summ = numbers.ExtensionSum(int32Adder);
            Console.WriteLine(summ);
            
            FloatAdder floatAdder = new FloatAdder();
            List<float> floatNumbers= new List<float>{1.2f, 2.5f, 3.5f, 4.5f,};
            float floatSumm = floatNumbers.ExtensionSum(floatAdder);
            Console.WriteLine(floatSumm);

            StringAdder stringAdder = new StringAdder();
            List<string> words = new List<string> {"1", "2", "3", "4"};
            string text = words.ExtensionSum(stringAdder);
            Console.WriteLine(text);


            Console.WriteLine(Average(2,3));
            
            float Average(uint firstNumber, uint secondNumber)
            {
                return (firstNumber + secondNumber) / 2f;
            }


        }

      
        
    }
}