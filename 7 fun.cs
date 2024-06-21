using System;

class Program
{
    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];

        Array.Copy(arr1, 0, mergedArray, 0, arr1.Length);
        Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);

        return mergedArray;
    }

    static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        int[] mergedArray = MergeArrays(array1, array2);

        Console.WriteLine("Merged Array:");
        foreach (int num in mergedArray)
        {
            Console.Write(num + " ");
        }
    }
}





