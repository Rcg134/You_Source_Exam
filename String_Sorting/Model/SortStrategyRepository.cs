// <copyright file="SortStrategyRepository.cs" company="Yousource">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace String_Sorting.Model
{
    using System;
    using System.Linq;

    public class SortStrategyRepository : ISortStrategyRepository
    {
        #region Bubble Sort
        public string BubbleSortStrategy(SortingModel input)
        {
            var arr = input.InputString.ToLower().Select(c => c.ToString()).ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return string.Concat(arr);
        }
        #endregion

        #region Merge Sort
        public string MergeSortStrategy(SortingModel input)
        {
            var arr = input.InputString.ToLower().Select(c => c.ToString()).ToArray();

            if (arr.Length <= 1)
            {
                return input.InputString;
            }

            return string.Concat(MergeSort(arr));

            string[] MergeSort(string[] array)
            {
                if (array.Length <= 1)
                {
                    return array;
                }

                int mid = array.Length / 2;
                string[] left = new string[mid];
                string[] right = new string[array.Length - mid];

                Array.Copy(array, 0, left, 0, mid);
                Array.Copy(array, mid, right, 0, array.Length - mid);

                return Merge(MergeSort(left), MergeSort(right));
            }

            string[] Merge(string[] left, string[] right)
            {
                string[] result = new string[left.Length + right.Length];
                int i = 0, j = 0, k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if (string.Compare(left[i], right[j]) <= 0)
                    {
                        result[k++] = left[i++];
                    }
                    else
                    {
                        result[k++] = right[j++];
                    }
                }

                while (i < left.Length)
                {
                    result[k++] = left[i++];
                }

                while (j < right.Length)
                {
                    result[k++] = right[j++];
                }

                return result;
            }
        }
        #endregion

        #region Quick Sort
        public string QuickSortStrategy(SortingModel input)
        {
            var arr = input.InputString.ToLower().Select(c => c.ToString()).ToArray();

            void QuickSort(string[] arr, int low, int high)
            {
                if (low < high)
                {
                    int pi = Partition(arr, low, high);
                    QuickSort(arr, low, pi - 1);
                    QuickSort(arr, pi + 1, high);
                }
            }

            int Partition(string[] arr, int low, int high)
            {
                string pivot = arr[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (string.Compare(arr[j], pivot) <= 0)
                    {
                        i++;
                        Swap(arr, i, j);
                    }
                }

                Swap(arr, i + 1, high);
                return i + 1;
            }

            void Swap(string[] arr, int i, int j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }

            QuickSort(arr, 0, arr.Length - 1);
            return string.Concat(arr);
        }
        #endregion
    }
}
