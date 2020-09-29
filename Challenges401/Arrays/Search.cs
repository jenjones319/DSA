﻿namespace Challenges401.Arrays
{
    class Search
    {
        public static int BiSearch(int value, int[] array)
        {
            int left = 0;
            int right = array.Length;
            int mid = array.Length / 2;

            while (value != array[mid])
            {
                if (value > array[mid])
                {
                    left = mid;
                }
                else if (value < array[mid])
                {
                    right = mid;
                }
                mid = ((right - left) / 2) + 2;
                if ((left == mid || right == mid) && array[mid] != value)
                {
                    return -1;
                }
            }

            return mid;
        }
    }
}
