using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;

namespace HW4
{
    internal class Program
    {
        //-Write a C# method to find the largest value from three integer values.
        static int MaxNum(int num1, int num2, int num3)
        {
            int result = 0;
            if (num1 > num2 && num1 > num3)
            {
                result = num1;
            }
            if (num2 > num1 && num2 > num3)
            {
                result = num2;
            }
            if (num3 > num1 && num3 > num2)
            {
                result = num3;
            }
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second number");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input third number");
            var num3 = int.Parse(Console.ReadLine());

            int result = MaxNum(num1, num2, num3);
            Console.WriteLine($"Max number is : {result}");
        }

        //_______________________

        //-Write a C# method to find the lowest value from three integer values.
        static int MinNum(int num4, int num5, int num6)
        {
            int result = 0;
            if (num4<num5 && num4<num6)
            {
                result = num4;
            }
            if (num5<num4 && num5<num6)
            {
                result = num5;
            }
             if (num6 < num4 && num6 < num5)
                {
                    result = num6;
                }
                return result;
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Input first number");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second number");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input third number");
            var num3 = int.Parse(Console.ReadLine());

            int result = MinNum(num1, num2, num3);
            Console.WriteLine($"Min number is : {result}");
}

        //_______________________

        //- Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
        //   Test Data:
        //    Input first integer:
        //   15
        //   Input second integer:
        //  12
        //  Sample Output
        //  15
        // не можу зрозуміти, чому не працює, якщо значення більше 20 (((

        static int NearValue(int FirstInt, int SecondInt)
        {
            int Value = 20;
            int Output = 0;

            if (Value - FirstInt < Value - SecondInt)
            {
                Output = FirstInt;
            }
            else if (Value - FirstInt > Value - SecondInt)
            {
                Output = SecondInt;
            }
            else if (FirstInt == SecondInt)
            {
                Output = 0;
            }
            return Output;

        }
        static void Main2(string[] args)
        {
            Console.WriteLine("Input first number");
            var FirstInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer");
            var SecondInt = int.Parse(Console.ReadLine());

            int Output = NearValue(FirstInt, SecondInt);

            Console.WriteLine($"Sample Output : {Output}");

        }



        //_______________
        // -Write a C# method to compute the sum of all the elements of an array of integers
        static void Main3(string[] args)
        {
            int[] elements = new int[] { 1, 2, 3, 4, 5 };
            var summ = 0;
            for (int i = 0; i<elements.Length; i++)             
            {
                summ += elements[i];
            }
                Console.WriteLine($"Sum is {summ}");
        }

        static void SumArray(int summary)
        {
            int[] elements = new int[] { 1, 2, 3, 4, 5 };
            int summ = 0;
            foreach (int i in elements)
            {
                summ += elements[i];
            }
}


        //________
        // - Write a C# method to get the larger value from array

        static void Main4(string[] args)
        {
            int[] numb = new int[] { 110, 22, 34, 444, 57, 6 };
            int large = numb.Max();

            {
                Console.WriteLine($"the larger value from array {large}");
            }
        }

        static void LargeValue(int arrays)
        {
            int[] numb = new int[] { };
            int large = numb.Max();
        }


    }
}
