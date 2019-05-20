using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSortApp
{
    public static class ArrayManager
    {
        public static int[] CriadorMatriz()
        {
            var rnd = new Random();
            var valor = rnd.Next(4, 10);
            int[] array = new int[valor];
            for (int i = 0; i < array.Length; i++)
            {
                var elemento = rnd.Next(0, 100);
                array[i] = elemento;
            }
            return array;            
        }
    }
}
