using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 49, 38, 65, 97, 76, 13, 27 };
            sort1(array, 0, array.Length - 1);
            var str = "";
            foreach (var item in array)
            {
                str += item + ",";
            }
            Console.WriteLine(str);
            Console.ReadKey();


        }


        public static int initRank(int[] list, int begin, int end)
        {
            int value = list[begin];

            while (begin < end)
            {
                if (list[end] >= value && begin < end)
                {
                    end--;
                }
                list[begin] = list[end];
                if (begin < end && list[begin] <= value)
                {
                    begin++;
                }
                list[end] = list[begin];
            }
            list[begin] = value;
            return begin;
        }


        public static void sort1(int[] array, int begin, int end)
        {
            if (begin >= end)
            {
                return;
            }
            int index = initRank(array, begin, end);
            initRank(array, begin, index - 1);
            initRank(array, index + 1, end);
        }
    }
}
