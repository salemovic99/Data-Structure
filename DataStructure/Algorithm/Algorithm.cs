using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Algorithms
{
    static class Algorithm
    {
        public static int LeanerSearch(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            return -1;
        }
        public static void GetIndexOfElement(int[] arr, int value)
        {
            int index  = RecrsiveBinarySearch(arr,0, arr.Length - 1, value);
            if(index != -1)
            {
                Console.WriteLine($"Element {arr[index]} Found At index : " + index);
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
        }
        public static int BinarySearch(int[] arr, int value)
        {
            int left = 0;
            int right = arr.Length - 1 ;
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (arr[middle] == value)
                    return middle;

                if(value < arr[middle])
                {
                    right = middle - 1;
                }
                else if(value > arr[middle])   
                {
                    left = middle + 1;
                }
            }
            return -1;
        }

        //Binary Search using recrsive
        public static int RecrsiveBinarySearch(int[] arr, int left, int right, int value)
        {
            if (left <= right)
            {
                int middle = (left + right) / 2;

                if (arr[middle] == value)
                {
                    return middle;
                }
                if (value > arr[middle])
                {
                    return RecrsiveBinarySearch(arr, middle + 1, right, value);
                }
                else if (value < arr[middle])
                {
                    return RecrsiveBinarySearch(arr, left, middle - 1, value);
                }
            }
            return -1;
        }
    }
}
