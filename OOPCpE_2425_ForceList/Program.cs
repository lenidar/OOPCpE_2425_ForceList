using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOPCpE_2425_ForceList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myList = { };

            DisplayArray(myList);

            myList = AddToList(myList, 2);
            DisplayArray(myList);

            myList = AddToList(myList, 8);
            DisplayArray(myList);

            myList = AddToList(myList, 12);
            DisplayArray(myList);

            Console.WriteLine(ValueContain(myList, 2).ToString());
            Console.WriteLine(ValueContain(myList, 420).ToString());

            Console.WriteLine(FindValue(myList, 2).ToString());
            Console.WriteLine(FindValue(myList, 420).ToString());


            myList = AddToList(myList, 7);
            myList = AddToList(myList, 4);
            myList = AddToList(myList, 13);
            myList = AddToList(myList, 6);
            myList = AddToList(myList, 4);
            myList = AddToList(myList, 20);
            myList = AddToList(myList, 6);
            DisplayArray(myList);
            myList = RemoveValue(myList, 13);
            DisplayArray(myList);

            DisplayArray(FindAllValue(myList, 4));
            myList = RemoveIndex(myList, 4);
            DisplayArray(myList);
            myList = RemoveAllValue(myList, 6);
            DisplayArray(myList);
        }

        static int[] AddToList(int[] arr,int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int x = 0; x < arr.Length; x++)
                newArr[x] = arr[x];

            newArr[newArr.Length - 1] = value;

            return newArr;
        }

        static void DisplayArray(int[] arr)
        {
            Console.WriteLine($"Current Length of array is {arr.Length}");
            Console.WriteLine("Content are as follow:");
            foreach (int a in arr)
                Console.Write($"{a}\t");

            Console.WriteLine();
        }

        static bool ValueContain(int[] arr, int value)
        {
            foreach(int a in arr)
                if (a == value)
                    return true;

            return false;
        }

        static int FindValue(int[] arr, int value)
        {
            for (int x = 0; x < arr.Length; x++)
                if (arr[x] == value)
                    return x;

            return -1;
        }

        static int[] RemoveValue(int[] arr, int value)
        {
            int[] newArr = new int[arr.Length - 1];
            int indexToRemove = FindValue(arr, value);

            for (int x = 0; x < indexToRemove; x++)
                newArr[x] = arr[x];

            for (int x = indexToRemove + 1; x < arr.Length; x++)
                newArr[x - 1] = arr[x];

            return newArr;
        }

        static int[] FindAllValue(int[] arr, int value)
        {
            int[] result = { };
            for (int x = 0; x < arr.Length; x++)
                if (arr[x] == value)
                    result = AddToList(result, x);

            return result;
        }

        static int[] RemoveIndex(int[] arr, int index)
        {
            int[] newArr = new int[arr.Length - 1];

            for (int x = 0; x < index; x++)
                newArr[x] = arr[x];

            for (int x = index + 1; x < arr.Length; x++)
                newArr[x - 1] = arr[x];

            return newArr;
        }

        static int[] RemoveAllValue(int[] arr, int value)
        {
            while(ValueContain(arr, value))
                arr = RemoveValue(arr, value);

            return arr;
        }
    }
}
