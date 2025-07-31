using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by spaces:");
        string input = Console.ReadLine();
        int[] array = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

        Console.WriteLine("\nOriginal Array:");
        PrintArray(array);

        // Bubble Sort
        int[] bubbleSorted = (int[])array.Clone();
        BubbleSort(bubbleSorted);
        Console.WriteLine("\nBubble Sorted:");
        PrintArray(bubbleSorted);

        // Selection Sort
        int[] selectionSorted = (int[])array.Clone();
        SelectionSort(selectionSorted);
        Console.WriteLine("\nSelection Sorted:");
        PrintArray(selectionSorted);

        // Built-in Sort
        int[] builtInSorted = (int[])array.Clone();
        Array.Sort(builtInSorted);
        Console.WriteLine("\nBuilt-in Sorted:");
        PrintArray(builtInSorted);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[minIdx])
                    minIdx = j;
            int temp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}