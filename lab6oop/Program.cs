using Lab6oop;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;
using System.Text;

namespace Lab_6
{
    class Program
    {
        static bool IsArrayEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                        return false;
                }
                return true;
            }
            return false;
        }
        static void CopyArray(int[] arr, ref int[] arr1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
        }
        const int num = 1000; //константа щоб числа були > 0 при обрахуванні мілісекунд
        public delegate int[] BubbleSortDel(int[] arr);
        public delegate int[] SelectionSort(int[] arr, int zero = 0);
        static void Main()
        {
           
            Random rnd= new Random();
            int[] arr = new int[rnd.Next(1, 100)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=rnd.Next(1,100);
            }
            int[] arr1 =new int[arr.Length];
            CopyArray(arr,ref arr1);
            //int[] arr = { 35, 6576, 867, 34, 34, 2, 5, 4, 7, 82 };
            solution sol1 = new solution();
            BubbleSortDel etalonDelegate = new BubbleSortDel(sol1.BubbleSortEtalon);
            BubbleSortDel studentDelegate = new BubbleSortDel(sol1.BubbleSortWrong);
            Console.WriteLine("Початковий масив: {0}", string.Join(", ", arr));
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---");
     //Console.WriteLine("Вiдсортований масив: {0}", string.Join(", ", sol1.BubbleSortEtalon(arr)));
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Вiдсортований масив(etalon): {0}", string.Join(", ", sol1.BubbleSortEtalon(arr)));
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
     //   Console.WriteLine(ts);
     //string time = ts.ToString();
     //time = time.Substring(6);
            double millisec = ts.TotalMinutes * 60 * num;
            Console.WriteLine(millisec + "ms");
            sw.Restart();
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---");
            sw.Start();
            Console.WriteLine("Вiдсортований масив(stud): {0}", string.Join(", ", sol1.BubbleSortWrong(arr1)));
            sw.Stop();
            TimeSpan ts1 = sw.Elapsed;
            double millisecStud = ts1.TotalMinutes * 60 * num;
            Console.WriteLine(millisecStud + "ms");

            if (millisecStud >= millisec / 5.0 - 200 && millisecStud <= 5 * millisec + 200)
            Console.WriteLine("Час збiгається");
                else
            Console.WriteLine("Час не збiгається");
            if (IsArrayEqual(arr, arr1))
                Console.WriteLine("Масиви спiвпадають");
            else
            Console.WriteLine("Масиви не спiвпадають");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---");
        }
    }
}
      