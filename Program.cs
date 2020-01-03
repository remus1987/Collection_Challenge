using System;
using System.Collections.Generic;
using System.Linq;

//Add a method Array_List_Dictionary_Get_Total(int a, b, c, d, e)
//Create some code to take in 5 numbers as input. Take those numbers, add 5, and put into an Array
//Iterate over the array, extract the numbers, square the numbers, and add to a List. Iterate over the list, subtract 10, add to a Dictionary<int,int>
//Iterate over dictionary and return sum. Return the answer

namespace Collection_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection_Methods cc = new Collection_Methods();
            Console.WriteLine(cc.ArrayListDictionaryGetTotal(1,2,3,4,5)); // should be 280
            Console.WriteLine(cc.ArrayListDictGetT_2(1,2,3,4,5));
            Console.WriteLine(cc.ArrayListDictGetT_2(1,4,9,16,25)); // should be 1604

        }
    }
    class Collection_Methods
    {
        public int ArrayListDictionaryGetTotal(int a, int b, int c, int d, int e)
        {
            List<int> ls = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            var result = 0;

            a += 5;
            b += 5;
            c += 5;
            d += 5;
            e += 5;
            int[] num = { a,b,c,d,e };

            for (int i = 0; i < num.Length; i++)
            {
                var item = num[i] * num[i];
                ls.Add(item);
            }
            for (int i = 0; i < ls.Count; i++)
            {
                var item2 = ls[i] - 10;
                dict.Add(i, item2);
            }

            return dict.Values.Sum();
        }

        // 2. Second solution with Lists:
        public int ArrayListDictGetT_2(int a , int b, int c, int d, int e)
        {
            var myArray = new int[] { a+5, b+5, c+5, d+5, e+5 };
            var myList = new List<int>();
            var myList2 = new List<int>();
            foreach (var item in myArray)
            {
                myList.Add(item * item);
            }
            foreach (var item in myList)
            {
                myList2.Add(item - 10);
            }
            return myList2.Sum();
        }

    }
}
