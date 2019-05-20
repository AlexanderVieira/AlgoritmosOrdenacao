using System;

namespace MergeSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = ArrayManager.CriadorMatriz();
            var newArray = MergeSort.mergeSort(array);
            Console.Write("\n Vetor ordenado com Merge Sort: [" + string.Join(",", newArray) + "]");
            Console.ReadLine();
        }
    }
}