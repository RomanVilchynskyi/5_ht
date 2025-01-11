using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ht
{
    internal class Arr : IOutput2, ICalc, ICalc2
    {
        private int[] arr_;
        public Arr(int[] arr)
        {
            arr_ = arr;
        }

        public int CountDistinct()
        {
            return arr_.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return arr_.Count(x => x == valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return arr_.Count(x => x > valueToCompare);
        }

        public int Less(int valueToCompare)
        {
            return arr_.Count(x => x < valueToCompare);
        }

        public void Show()
        {
            /*Console.WriteLine("Arr:");*/
            foreach (var item in arr_)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            /*Console.WriteLine(info);*/
            Console.WriteLine("Array:");
            foreach (var item in arr_)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void ShowEven()
        {
            Console.WriteLine("Even numbers:");
            foreach (var item in arr_)
            {
                if (item % 2 == 0) 
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd numbers:");
            foreach (var item in arr_)
            {
                if (item % 2 != 0) 
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
