using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Lab6oop
{
    public class solution
    {
        int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                    result = i;
            }

            return result;
        }
        void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортування бульбашкою
        public int[] BubbleSortEtalon(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
            return array;
        }
        public int[] BubbleSortCorr(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
            return array;
        }
        public int[] BubbleSortWrong(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(ref array[j], ref array[j + 1]);
                }
                System.Threading.Thread.Sleep(100);
            }
            return array;
        }



        //сортування вибором
        public int[] SelectionSortEtalon(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSortEtalon(array, currentIndex + 1);
        }
        public int[] SelectionSortCorr(int[] arr, int currInd = 0)
        {
            if (currInd == arr.Length)
                return arr;

            var index = IndexOfMin(arr, currInd);
            if (index != currInd)
            {
                Swap(ref arr[index], ref arr[currInd]);
            }

            return SelectionSortCorr(arr, currInd + 1);
        }
        public int[] SelectionSortWrong(int[] arr, int currInd = 0)
        {
            if (currInd == arr.Length)
                return arr;

            var index = IndexOfMin(arr, currInd);
            if (index != currInd)
            {
                Swap(ref arr[index], ref arr[currInd]);
            }
            System.Threading.Thread.Sleep(100);
            return SelectionSortWrong(arr, currInd + 1);
        }
    }
}