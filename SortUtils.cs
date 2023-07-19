using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name11
{
    /**
 * Утилиты для сортировки массива
 */
    public class SortUtils
    {


        /**
         * Сортировка выбором
         *
         *  0 1 2 3 4
         *  =========
         *  5 4 1 0 1
         *
         *
         *
         * @param array массив
         */
        public static void directSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int saveIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[saveIndex])
                    {
                        saveIndex = j;
                    }
                }
                if (i != saveIndex)
                {
                    int buf = array[i];
                    array[i] = array[saveIndex];
                    array[saveIndex] = buf;
                }
            }
        }


        public static void quickSort(int[] array)
        {
            quickSort(array, 0, array.Length - 1);
        }

        public static void quickSort(int[] array, int start, int end)
        {
            int left = start;
            int right = end;
            int middle = array[(start + end) / 2];

            do
            {
                while (array[left] < middle)
                {
                    left++;
                }

                while (array[right] > middle)
                {
                    right--;
                }

                if (left <= right)
                {
                    if (left < right)
                    {
                        int buf = array[left];
                        array[left] = array[right];
                        array[right] = buf;
                    }
                    left++;
                    right--;
                }
            }
            while (left <= right);

            if (left < end)
            {
                quickSort(array, left, end);
            }

            if (start < right)
            {
                quickSort(array, start, right);
            }
        }

        public static void screening (int[] array, int size, int root){
            int max = root;
            int leftChild = 2 * root + 1;
            int rightChild = 2 * root + 2;
            if (leftChild < size && array[leftChild] > array[max]){
                max = leftChild;
            }
            if (rightChild < size && array[rightChild] > array[max]){
                max = rightChild;
            }
            if (max != root){
                int temp = array[root];
                array[root] = array[max];
                array[max] = temp;
                screening (array, size, max);
            }

        }

        public static void pyramSort (int[] array){
            for(int i = array.Length / 2 - 1; i>=0; i-- ){
                screening(array, array.Length, i);
            }

             for(int i = array.Length - 1; i>=0; i-- ){
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                screening(array, i, 0);
            }
        }

    }
}
