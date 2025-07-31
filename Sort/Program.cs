using System;
using System.Diagnostics;
using System.Text;

/// <summary>
/// Complete Array Sorting Algorithms Masterclass
/// 
/// This comprehensive program demonstrates ALL major sorting algorithms used in:
/// • Programming Interviews (FAANG companies)
/// • Computer Science Education
/// • Real-world Software Development
/// 
/// Each algorithm includes detailed explanations, complexity analysis, and practical tips.
/// 
/// Target: .NET 8, C# 12.0
/// Author: Learn & Reflect: Software
/// YouTube Channel: Educational Programming Content
/// </summary>
class Program
{
    static void Main()
    {
        try
        {
            // Set console encoding to support Unicode characters
            Console.OutputEncoding = Encoding.UTF8;
            
            // Display welcome message and channel branding
            DisplayWelcomeMessage();
            
            // Get user input with validation
            int[] originalArray = GetUserInput();
            if (originalArray.Length == 0)
            {
                Console.WriteLine("No valid input provided. Exiting program.");
                return;
            }

            Console.WriteLine($"\n{new string('=', 80)}");
            Console.WriteLine(">> ORIGINAL ARRAY:");
            Console.WriteLine($"{new string('=', 80)}");
            PrintArray(originalArray);

            // Demonstrate all sorting algorithms with timing
            DemonstrateAllSortingAlgorithms(originalArray);
            
            // Display comprehensive comparison and learning resources
            DisplayComplexityTable();
            DisplayLearningResources();
            
            Console.WriteLine("\n>> Thanks for watching 'Learn & Reflect: Software'!");
            Console.WriteLine(">> Don't forget to LIKE and SUBSCRIBE for more programming content!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] An error occurred: {ex.Message}");
        }
    }

    /// <summary>
    /// Displays welcome message with YouTube channel branding
    /// </summary>
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine($"{new string('#', 80)}");
        Console.WriteLine("#                                                                              #");
        Console.WriteLine("#                    >> COMPLETE SORTING ALGORITHMS GUIDE <<                  #");
        Console.WriteLine("#                         ** Learn & Reflect: Software **                     #");
        Console.WriteLine("#                    >> Master Every Sorting Algorithm <<                     #");
        Console.WriteLine("#                                                                              #");
        Console.WriteLine($"{new string('#', 80)}");
        
        Console.WriteLine("\n>> Welcome to the Complete Sorting Algorithms Masterclass!");
        Console.WriteLine(">> This program covers ALL sorting techniques you need to know:");
        Console.WriteLine();
        
        Console.WriteLine(">> COMPARISON-BASED SORTS:");
        Console.WriteLine("   • Bubble Sort (O(n²)) - [BASIC] Beginner friendly");
        Console.WriteLine("   • Cocktail Shaker Sort (O(n²)) - [BASIC] Bubble sort optimization");
        Console.WriteLine("   • Selection Sort (O(n²)) - [BASIC] Simple selection-based");
        Console.WriteLine("   • Insertion Sort (O(n²)) - [BASIC] Efficient for small/nearly sorted arrays");
        Console.WriteLine("   • Shell Sort (O(n^1.5)) - [INTERMEDIATE] Gap-based insertion sort");
        Console.WriteLine("   • Merge Sort (O(n log n)) - [ADVANCED] Stable divide-and-conquer");
        Console.WriteLine("   • Quick Sort (O(n log n)) - [ADVANCED] Fast in-place sorting");
        Console.WriteLine("   • Heap Sort (O(n log n)) - [ADVANCED] Consistent performance");
        Console.WriteLine();
        
        Console.WriteLine(">> NON-COMPARISON SORTS:");
        Console.WriteLine("   • Counting Sort (O(n+k)) - [SPECIAL] Integer sorting");
        Console.WriteLine("   • Radix Sort (O(d×n)) - [SPECIAL] Multi-digit integer sorting");
        Console.WriteLine("   • Bucket Sort (O(n+k)) - [SPECIAL] Distribution-based sorting");
        Console.WriteLine();
        
        Console.WriteLine(">> PRODUCTION READY:");
        Console.WriteLine("   • Built-in Sort (.NET) - [HYBRID] IntroSort algorithm");
        Console.WriteLine();
        
        Console.WriteLine(">> Perfect for: Interviews • Learning • Teaching • Reference");
        Console.WriteLine(">> Each algorithm shows: Implementation • Performance • Use Cases");
        Console.WriteLine();
    }

    /// <summary>
    /// Gets user input with enhanced validation and suggestions
    /// </summary>
    /// <returns>Array of integers from user input</returns>
    static int[] GetUserInput()
    {
        Console.WriteLine(">> ARRAY INPUT:");
        Console.WriteLine("Enter array elements separated by spaces");
        Console.WriteLine(">> Try these examples:");
        Console.WriteLine("   Small array: 64 34 25 12 22 11 90");
        Console.WriteLine("   Reverse sorted: 100 90 80 70 60 50 40 30 20 10");
        Console.WriteLine("   Nearly sorted: 10 20 15 30 25 40 35 50");
        Console.WriteLine("   Duplicates: 5 2 8 2 9 1 5 4");
        Console.WriteLine();
        
        while (true)
        {
            try
            {
                Console.Write("Your input: ");
                string? input = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("[INFO] No input provided.");
                    return Array.Empty<int>();
                }

                // Parse and validate input
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] array = new int[parts.Length];
                
                for (int i = 0; i < parts.Length; i++)
                {
                    array[i] = int.Parse(parts[i]);
                }

                if (array.Length > 100)
                {
                    Console.WriteLine("[WARNING] Large arrays may take longer with O(n²) algorithms.");
                    Console.WriteLine("[TIP] For demo purposes, consider using smaller arrays (< 50 elements).");
                }

                if (array.Length < 5)
                {
                    Console.WriteLine("[TIP] Larger arrays better demonstrate performance differences!");
                }

                return array;
            }
            catch (FormatException)
            {
                Console.WriteLine("[ERROR] Invalid input! Please enter only integers separated by spaces.");
                Console.WriteLine("[EXAMPLE] 64 34 25 12 22 11 90");
            }
            catch (OverflowException)
            {
                Console.WriteLine("[ERROR] Number too large! Please enter smaller integers.");
            }
        }
    }

    /// <summary>
    /// Demonstrates all sorting algorithms with enhanced presentation
    /// </summary>
    /// <param name="originalArray">The original array to sort</param>
    static void DemonstrateAllSortingAlgorithms(int[] originalArray)
    {
        Console.WriteLine($"\n{new string('=', 80)}");
        Console.WriteLine(">> SORTING ALGORITHMS DEMONSTRATION");
        Console.WriteLine($"{new string('=', 80)}");
        
        // Simple O(n²) Algorithms - Great for Learning
        Console.WriteLine("\n>> SECTION 1: SIMPLE ALGORITHMS (O(n²)) - LEARNING FUNDAMENTALS");
        
        ExecuteAndTimeSort("[BUBBLE] BUBBLE SORT", originalArray, 
            arr => BubbleSort(arr),
            "Classic beginner algorithm. Repeatedly swaps adjacent elements.",
            "[EDUCATIONAL] Teaching tool, rarely used in practice");

        ExecuteAndTimeSort("[COCKTAIL] COCKTAIL SHAKER SORT", originalArray,
            arr => CocktailShakerSort(arr),
            "Bidirectional bubble sort. Sorts from both ends simultaneously.",
            "[OPTIMIZED] Slight improvement over bubble sort");

        ExecuteAndTimeSort("[SELECT] SELECTION SORT", originalArray,
            arr => SelectionSort(arr),
            "Finds minimum element and places it at the beginning each iteration.",
            "[EFFICIENT] Minimizes number of swaps (exactly n-1)");

        ExecuteAndTimeSort("[INSERT] INSERTION SORT", originalArray,
            arr => InsertionSort(arr),
            "Builds sorted array one element at a time by inserting each element.",
            "[PRACTICAL] Excellent for small or nearly sorted arrays");

        ExecuteAndTimeSort("[SHELL] SHELL SORT", originalArray,
            arr => ShellSort(arr),
            "Gap-based insertion sort. Reduces gap size in each iteration.",
            "[IMPROVED] Better than O(n²) - around O(n^1.5) performance");

        // Efficient O(n log n) Algorithms - Industry Standard
        Console.WriteLine("\n>> SECTION 2: EFFICIENT ALGORITHMS (O(n log n)) - INDUSTRY STANDARD");
        
        ExecuteAndTimeSort("[MERGE] MERGE SORT", originalArray,
            arr => MergeSort(arr, 0, arr.Length - 1),
            "Divide-and-conquer algorithm. Stable with guaranteed O(n log n).",
            "[STABLE] Stable, predictable, preferred for linked lists");

        ExecuteAndTimeSort("[QUICK] QUICK SORT", originalArray,
            arr => QuickSort(arr, 0, arr.Length - 1),
            "Fast in-place sorting with pivot partitioning strategy.",
            "[FAST] Generally fastest for random data, cache-friendly");

        ExecuteAndTimeSort("[HEAP] HEAP SORT", originalArray,
            arr => HeapSort(arr),
            "Uses binary heap data structure for consistent O(n log n).",
            "[CONSISTENT] Consistent performance, in-place, not stable");

        // Non-Comparison Algorithms - Specialized but Super Fast
        Console.WriteLine("\n>> SECTION 3: NON-COMPARISON ALGORITHMS - SPECIALIZED SPEED");
        
        if (CanUseCountingSort(originalArray))
        {
            ExecuteAndTimeSort("[COUNT] COUNTING SORT", originalArray,
                arr => CountingSort(arr),
                "Counts frequency of each element. Works for limited integer ranges.",
                "[LINEAR] Linear time O(n+k) for small ranges");
        }
        else
        {
            Console.WriteLine("\n[COUNT] COUNTING SORT: >> Skipped (requires non-negative integers with small range)");
        }

        if (Array.TrueForAll(originalArray, x => x >= 0))
        {
            ExecuteAndTimeSort("[RADIX] RADIX SORT", originalArray,
                arr => RadixSort(arr),
                "Sorts by individual digits using counting sort as subroutine.",
                "[DIGITS] Excellent for integers, O(d×n) complexity");
        }
        else
        {
            Console.WriteLine("\n[RADIX] RADIX SORT: >> Skipped (requires non-negative integers)");
        }

        if (CanUseBucketSort(originalArray))
        {
            ExecuteAndTimeSort("[BUCKET] BUCKET SORT", originalArray,
                arr => BucketSort(arr),
                "Distributes elements into buckets, then sorts each bucket.",
                "[DISTRIBUTION] Average O(n+k), good for uniformly distributed data");
        }
        else
        {
            Console.WriteLine("\n[BUCKET] BUCKET SORT: >> Skipped (optimized for smaller ranges)");
        }

        // Production Algorithm
        Console.WriteLine("\n>> SECTION 4: PRODUCTION READY - WHAT PROFESSIONALS USE");
        
        ExecuteAndTimeSort("[BUILTIN] BUILT-IN SORT (.NET)", originalArray,
            arr => Array.Sort(arr),
            "Hybrid IntroSort: QuickSort + HeapSort + InsertionSort combination.",
            "[PRODUCTION] Production choice - optimized, tested, maintained");
    }

    /// <summary>
    /// Enhanced execution with better formatting and insights
    /// </summary>
    static void ExecuteAndTimeSort(string algorithmName, int[] originalArray, Action<int[]> sortMethod, 
                                   string description, string practicalTip)
    {
        int[] arrayToSort = (int[])originalArray.Clone();
        
        Console.WriteLine($"\n{new string('-', 70)}");
        Console.WriteLine($">> {algorithmName}");
        Console.WriteLine($"{new string('-', 70)}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Practical Tip: {practicalTip}");
        
        // Measure performance
        Stopwatch stopwatch = Stopwatch.StartNew();
        sortMethod(arrayToSort);
        stopwatch.Stop();
        
        // Display timing with better formatting
        string timeDisplay = stopwatch.ElapsedMilliseconds > 0 
            ? $"{stopwatch.ElapsedMilliseconds} ms" 
            : $"{stopwatch.ElapsedTicks} ticks";
            
        Console.WriteLine($"Execution time: {timeDisplay}");
        Console.WriteLine($"Result: ");
        PrintArray(arrayToSort);
        
        // Verify correctness with visual indicator
        if (IsSorted(arrayToSort))
        {
            Console.WriteLine("[SUCCESS] Array successfully sorted!");
        }
        else
        {
            Console.WriteLine("[ERROR] Array not properly sorted!");
        }
    }

    #region Sorting Algorithms

    /// <summary>
    /// BUBBLE SORT - The Classic Beginner Algorithm
    /// [PERFECT FOR] Teaching sorting concepts
    /// [TIME] O(n²) all cases | [SPACE] O(1) | [STABLE] Yes
    /// 
    /// How it works:
    /// 1. Compare adjacent elements
    /// 2. Swap if they're in wrong order
    /// 3. After each pass, largest element "bubbles up"
    /// 4. Repeat until no swaps needed
    /// 
    /// [YOUTUBE TIP] Great for visualizing how sorting works step-by-step!
    /// </summary>
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            
            // Last i elements are already in place
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap using modern C# tuple deconstruction
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }
            
            // Optimization: If no swaps, array is sorted
            if (!swapped)
                break;
        }
    }

    /// <summary>
    /// COCKTAIL SHAKER SORT - Bidirectional Bubble Sort
    /// [PERFECT FOR] Understanding algorithm optimizations
    /// [TIME] O(n²) worst, O(n) best | [SPACE] O(1) | [STABLE] Yes
    /// 
    /// How it works:
    /// 1. Bubble sort in both directions alternately
    /// 2. Forward pass bubbles largest to end
    /// 3. Backward pass bubbles smallest to beginning
    /// 4. Reduces number of passes needed
    /// 
    /// [YOUTUBE TIP] Shows how small optimizations can improve algorithms!
    /// </summary>
    static void CocktailShakerSort(int[] arr)
    {
        bool swapped = true;
        int start = 0;
        int end = arr.Length - 1;

        while (swapped)
        {
            swapped = false;

            // Forward pass
            for (int i = start; i < end; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }

            if (!swapped) break;

            end--;
            swapped = false;

            // Backward pass
            for (int i = end - 1; i >= start; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }

            start++;
        }
    }

    /// <summary>
    /// SELECTION SORT - Minimum Selection Strategy
    /// [PERFECT FOR] Understanding selection-based algorithms
    /// [TIME] O(n²) all cases | [SPACE] O(1) | [STABLE] No
    /// 
    /// How it works:
    /// 1. Find minimum element in unsorted portion
    /// 2. Swap it with first unsorted element
    /// 3. Move boundary of sorted portion
    /// 4. Repeat until all elements sorted
    /// 
    /// [YOUTUBE TIP] Minimizes writes (only n-1 swaps) - good for expensive write operations!
    /// </summary>
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            // Find minimum element index in remaining array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            
            // Swap only if needed
            if (minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }

    /// <summary>
    /// INSERTION SORT - Building Sorted Sequence
    /// [PERFECT FOR] Small arrays, nearly sorted data, online algorithms
    /// [TIME] O(n²) worst, O(n) best | [SPACE] O(1) | [STABLE] Yes
    /// 
    /// How it works:
    /// 1. Start with first element (considered sorted)
    /// 2. Take next element and insert in correct position
    /// 3. Shift larger elements to make room
    /// 4. Expand sorted portion by one element
    /// 
    /// [YOUTUBE TIP] Industry choice for small arrays (< 50 elements) due to low overhead!
    /// </summary>
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];  // Element to be positioned
            int j = i - 1;
            
            // Shift elements greater than key one position ahead
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            
            // Insert key at correct position
            arr[j + 1] = key;
        }
    }

    /// <summary>
    /// SHELL SORT - Gap-Based Insertion Sort
    /// [PERFECT FOR] Medium-sized arrays, when O(n log n) is overkill
    /// [TIME] O(n log n) average | [SPACE] O(1) | [STABLE] No
    /// 
    /// How it works:
    /// 1. Start with large gap (array_length/2)
    /// 2. Perform insertion sort on elements gap distance apart
    /// 3. Reduce gap and repeat
    /// 4. Final pass with gap=1 is regular insertion sort
    /// 
    /// [YOUTUBE TIP] Great middle ground between simple and complex algorithms!
    /// </summary>
    static void ShellSort(int[] arr)
    {
        int n = arr.Length;
        
        // Start with large gap, then reduce
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            // Perform insertion sort for elements gap distance apart
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j;
                
                // Shift earlier gap-sorted elements up
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                {
                    arr[j] = arr[j - gap];
                }
                
                arr[j] = temp;
            }
        }
    }

    /// <summary>
    /// MERGE SORT - Divide and Conquer Champion
    /// [PERFECT FOR] Large datasets, stability required, linked lists
    /// [TIME] O(n log n) all cases | [SPACE] O(n) | [STABLE] Yes
    /// 
    /// How it works:
    /// 1. Divide array into two halves
    /// 2. Recursively sort both halves
    /// 3. Merge the sorted halves
    /// 4. Guaranteed O(n log n) performance
    /// 
    /// [YOUTUBE TIP] Used in production for large datasets due to predictable performance!
    /// </summary>
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Avoid overflow: (left + right) / 2 can overflow
            int mid = left + (right - left) / 2;
            
            // Recursively sort both halves
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            
            // Merge the sorted halves
            Merge(arr, left, mid, right);
        }
    }

    /// <summary>
    /// Helper method for MergeSort - The Merging Magic
    /// </summary>
    static void Merge(int[] arr, int left, int mid, int right)
    {
        // Calculate sizes of subarrays
        int leftSize = mid - left + 1;
        int rightSize = right - mid;
        
        // Create temporary arrays
        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];
        
        // Copy data to temporary arrays
        Array.Copy(arr, left, leftArray, 0, leftSize);
        Array.Copy(arr, mid + 1, rightArray, 0, rightSize);
        
        // Merge temporary arrays back into arr[left..right]
        int i = 0, j = 0, k = left;
        
        // Compare elements and merge in sorted order
        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] <= rightArray[j])
            {
                arr[k] = leftArray[i];
                i++;
            }
            else
            {
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }
        
        // Copy remaining elements
        while (i < leftSize)
        {
            arr[k] = leftArray[i];
            i++;
            k++;
        }
        
        while (j < rightSize)
        {
            arr[k] = rightArray[j];
            j++;
            k++;
        }
    }

    /// <summary>
    /// QUICK SORT - The Speed Demon
    /// [PERFECT FOR] Large random datasets, when average case performance matters
    /// [TIME] O(n log n) average, O(n²) worst | [SPACE] O(log n) | [STABLE] No
    /// 
    /// How it works:
    /// 1. Choose pivot element
    /// 2. Partition: smaller elements left, larger elements right
    /// 3. Recursively sort both partitions
    /// 4. In-place sorting with excellent cache performance
    /// 
    /// [YOUTUBE TIP] Most popular sorting algorithm in practice due to speed!
    /// </summary>
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Partition and get pivot position
            int pivotIndex = Partition(arr, low, high);
            
            // Recursively sort elements before and after partition
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    /// <summary>
    /// Helper method for QuickSort - Lomuto Partition Scheme
    /// </summary>
    static int Partition(int[] arr, int low, int high)
    {
        // Choose rightmost element as pivot
        int pivot = arr[high];
        int i = low - 1;  // Index of smaller element
        
        for (int j = low; j < high; j++)
        {
            // If current element <= pivot
            if (arr[j] <= pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        
        // Place pivot in correct position
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        
        return i + 1;
    }

    /// <summary>
    /// HEAP SORT - The Consistent Performer
    /// [PERFECT FOR] Real-time systems, when worst-case O(n log n) is required
    /// [TIME] O(n log n) all cases | [SPACE] O(1) | [STABLE] No
    /// 
    /// How it works:
    /// 1. Build max heap from array
    /// 2. Extract maximum (root) and place at end
    /// 3. Heapify reduced heap
    /// 4. Repeat until heap is empty
    /// 
    /// [YOUTUBE TIP] Guarantees O(n log n) unlike QuickSort's worst case O(n²)!
    /// </summary>
    static void HeapSort(int[] arr)
    {
        int n = arr.Length;
        
        // Build max heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
        
        // Extract elements from heap one by one
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            (arr[0], arr[i]) = (arr[i], arr[0]);
            
            // Heapify reduced heap
            Heapify(arr, i, 0);
        }
    }

    /// <summary>
    /// Helper method for HeapSort - Maintains heap property
    /// </summary>
    static void Heapify(int[] arr, int heapSize, int rootIndex)
    {
        int largest = rootIndex;
        int leftChild = 2 * rootIndex + 1;
        int rightChild = 2 * rootIndex + 2;
        
        // Find largest among root and children
        if (leftChild < heapSize && arr[leftChild] > arr[largest])
            largest = leftChild;
            
        if (rightChild < heapSize && arr[rightChild] > arr[largest])
            largest = rightChild;
        
        // If largest is not root
        if (largest != rootIndex)
        {
            (arr[rootIndex], arr[largest]) = (arr[largest], arr[rootIndex]);
            
            // Recursively heapify affected sub-tree
            Heapify(arr, heapSize, largest);
        }
    }

    /// <summary>
    /// COUNTING SORT - The Linear Time Marvel
    /// [PERFECT FOR] Small integer ranges, when comparison is expensive
    /// [TIME] O(n + k) where k is range | [SPACE] O(k) | [STABLE] Yes
    /// 
    /// How it works:
    /// 1. Count frequency of each element
    /// 2. Calculate cumulative counts (positions)
    /// 3. Place elements at calculated positions
    /// 4. Non-comparison based algorithm
    /// 
    /// [YOUTUBE TIP] Breaks the O(n log n) barrier for comparison-based sorts!
    /// </summary>
    static void CountingSort(int[] arr)
    {
        if (arr.Length == 0) return;
        
        // Find range of input
        int min = arr[0], max = arr[0];
        foreach (int num in arr)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
        
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];
        
        // Count frequency of each element
        foreach (int num in arr)
        {
            count[num - min]++;
        }
        
        // Calculate cumulative count (positions)
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }
        
        // Build output array in reverse to maintain stability
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }
        
        // Copy back to original array
        Array.Copy(output, arr, arr.Length);
    }

    /// <summary>
    /// RADIX SORT - The Multi-Digit Specialist
    /// [PERFECT FOR] Sorting integers, strings of fixed length
    /// [TIME] O(d × n) where d is digits | [SPACE] O(n + k) | [STABLE] Yes
    /// 
    /// How it works:
    /// 1. Sort by least significant digit first
    /// 2. Use counting sort for each digit
    /// 3. Move to next digit
    /// 4. Continue until most significant digit
    /// 
    /// [YOUTUBE TIP] Excellent for sorting large integers faster than comparison sorts!
    /// </summary>
    static void RadixSort(int[] arr)
    {
        if (arr.Length == 0) return;
        
        // Find maximum to determine number of digits
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max) max = num;
        }
        
        // Sort by each digit using counting sort
        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSortByDigit(arr, exp);
        }
    }

    /// <summary>
    /// Helper for RadixSort - Counting sort by specific digit
    /// </summary>
    static void CountingSortByDigit(int[] arr, int exp)
    {
        int[] output = new int[arr.Length];
        int[] count = new int[10]; // For digits 0-9
        
        // Count frequency of each digit
        foreach (int num in arr)
        {
            count[(num / exp) % 10]++;
        }
        
        // Calculate cumulative count
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }
        
        // Build output array
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[(arr[i] / exp) % 10] - 1] = arr[i];
            count[(arr[i] / exp) % 10]--;
        }
        
        // Copy back to original
        Array.Copy(output, arr, arr.Length);
    }

    /// <summary>
    /// BUCKET SORT - The Distribution Strategy
    /// [PERFECT FOR] Uniformly distributed data, floating point numbers
    /// [TIME] O(n + k) average | [SPACE] O(n + k) | [STABLE] Yes
    /// 
    /// How it works:
    /// 1. Create buckets for different ranges
    /// 2. Distribute elements into buckets
    /// 3. Sort each bucket individually
    /// 4. Concatenate sorted buckets
    /// 
    /// [YOUTUBE TIP] Excellent when input is uniformly distributed!
    /// </summary>
    static void BucketSort(int[] arr)
    {
        if (arr.Length <= 1) return;
        
        // Find min and max
        int min = arr[0], max = arr[0];
        foreach (int num in arr)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
        
        // Create buckets
        int bucketCount = Math.Min(arr.Length, max - min + 1);
        var buckets = new List<int>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<int>();
        }
        
        // Distribute elements into buckets
        foreach (int num in arr)
        {
            int bucketIndex = Math.Min((num - min) * bucketCount / (max - min + 1), bucketCount - 1);
            buckets[bucketIndex].Add(num);
        }
        
        // Sort each bucket and concatenate
        int index = 0;
        foreach (var bucket in buckets)
        {
            if (bucket.Count > 0)
            {
                int[] bucketArray = bucket.ToArray();
                Array.Sort(bucketArray); // Use built-in sort for individual buckets
                
                foreach (int num in bucketArray)
                {
                    arr[index++] = num;
                }
            }
        }
    }

    #endregion

    #region Helper Methods

    /// <summary>
    /// Enhanced array printing with better formatting
    /// </summary>
    static void PrintArray(int[] arr)
    {
        if (arr.Length <= 15)
        {
            Console.WriteLine($"   [{string.Join(", ", arr)}]");
        }
        else if (arr.Length <= 50)
        {
            Console.WriteLine($"   [{string.Join(", ", arr[0..10])} ... {string.Join(", ", arr[^5..])}]");
            Console.WriteLine($"   >> Array length: {arr.Length} elements");
        }
        else
        {
            Console.WriteLine($"   [{string.Join(", ", arr[0..5])} ... {string.Join(", ", arr[^5..])}]");
            Console.WriteLine($"   >> Array length: {arr.Length} elements (showing first 5 and last 5)");
        }
    }

    /// <summary>
    /// Determines if counting sort is efficient for given array
    /// </summary>
    static bool CanUseCountingSort(int[] arr)
    {
        if (arr.Length == 0) return false;
        
        int min = arr[0], max = arr[0];
        foreach (int num in arr)
        {
            if (num < 0) return false; // Negative numbers complicate the demo
            if (num < min) min = num;
            if (num > max) max = num;
        }
        
        return (max - min + 1) <= 1000; // Reasonable range
    }

    /// <summary>
    /// Determines if bucket sort is suitable
    /// </summary>
    static bool CanUseBucketSort(int[] arr)
    {
        if (arr.Length == 0) return false;
        
        int min = arr[0], max = arr[0];
        foreach (int num in arr)
        {
            if (num < 0) return false;
            if (num < min) min = num;
            if (num > max) max = num;
        }
        
        return (max - min + 1) <= 500; // Suitable range for demo
    }

    /// <summary>
    /// Verifies array is properly sorted
    /// </summary>
    static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }
        return true;
    }

    /// <summary>
    /// Enhanced complexity comparison table with ASCII-compatible formatting
    /// </summary>
    static void DisplayComplexityTable()
    {
        Console.WriteLine($"\n{new string('=', 90)}");
        Console.WriteLine(">> COMPREHENSIVE ALGORITHM COMPARISON TABLE");
        Console.WriteLine($"{new string('=', 90)}");
        
        Console.WriteLine("+--------------------+-------------+--------------+-------------+---------+--------------+");
        Console.WriteLine("| Algorithm          | Best Case   | Average Case | Worst Case  | Stable  | Space        |");
        Console.WriteLine("+--------------------+-------------+--------------+-------------+---------+--------------+");
        Console.WriteLine("| [BUBBLE] Bubble    | O(n)        | O(n²)        | O(n²)       | YES     | O(1)         |");
        Console.WriteLine("| [COCKTAIL] Shaker  | O(n)        | O(n²)        | O(n²)       | YES     | O(1)         |");
        Console.WriteLine("| [SELECT] Selection | O(n²)       | O(n²)        | O(n²)       | NO      | O(1)         |");
        Console.WriteLine("| [INSERT] Insertion | O(n)        | O(n²)        | O(n²)       | YES     | O(1)         |");
        Console.WriteLine("| [SHELL] Shell      | O(n log n)  | O(n^1.5)     | O(n²)       | NO      | O(1)         |");
        Console.WriteLine("| [MERGE] Merge      | O(n log n)  | O(n log n)   | O(n log n)  | YES     | O(n)         |");
        Console.WriteLine("| [QUICK] Quick      | O(n log n)  | O(n log n)   | O(n²)       | NO      | O(log n)     |");
        Console.WriteLine("| [HEAP] Heap        | O(n log n)  | O(n log n)   | O(n log n)  | NO      | O(1)         |");
        Console.WriteLine("| [COUNT] Counting   | O(n + k)    | O(n + k)     | O(n + k)    | YES     | O(k)         |");
        Console.WriteLine("| [RADIX] Radix      | O(d × n)    | O(d × n)     | O(d × n)    | YES     | O(n + k)     |");
        Console.WriteLine("| [BUCKET] Bucket    | O(n + k)    | O(n + k)     | O(n²)       | YES     | O(n + k)     |");
        Console.WriteLine("+--------------------+-------------+--------------+-------------+---------+--------------+");
        
        Console.WriteLine("\n>> ALGORITHM SELECTION GUIDE:");
        Console.WriteLine("+---------------------+------------------------------------------------------+");
        Console.WriteLine("| Use Case            | Recommended Algorithm                                |");
        Console.WriteLine("+---------------------+------------------------------------------------------+");
        Console.WriteLine("| Learning/Teaching   | Bubble Sort, Selection Sort, Insertion Sort         |");
        Console.WriteLine("| Small arrays < 50   | Insertion Sort                                       |");
        Console.WriteLine("| General purpose     | Quick Sort, Merge Sort                               |");
        Console.WriteLine("| Guaranteed O(n log n) | Merge Sort, Heap Sort                                |");
        Console.WriteLine("| Memory constrained  | Heap Sort, Quick Sort                                |");
        Console.WriteLine("| Stability required  | Merge Sort, Counting Sort, Radix Sort               |");
        Console.WriteLine("| Integer ranges      | Counting Sort, Radix Sort                            |");
        Console.WriteLine("| Production code     | Built-in Sort (IntroSort hybrid)                     |");
        Console.WriteLine("+---------------------+------------------------------------------------------+");
    }

    /// <summary>
    /// Learning resources and next steps for YouTube viewers
    /// </summary>
    static void DisplayLearningResources()
    {
        Console.WriteLine($"\n{new string('=', 80)}");
        Console.WriteLine(">> CONTINUE YOUR LEARNING JOURNEY");
        Console.WriteLine($"{new string('=', 80)}");
        
        Console.WriteLine(">> LEARN & REFLECT: SOFTWARE CHANNEL CONTENT:");
        Console.WriteLine("   • Data Structures Deep Dives");
        Console.WriteLine("   • Algorithm Analysis & Optimization");
        Console.WriteLine("   • Interview Preparation Series");
        Console.WriteLine("   • System Design Fundamentals");
        Console.WriteLine("   • Practical Programming Tutorials");
        Console.WriteLine();
        
        Console.WriteLine(">> NEXT STEPS TO MASTER SORTING:");
        Console.WriteLine("   1. Implement each algorithm from scratch");
        Console.WriteLine("   2. Analyze performance with different data sets");
        Console.WriteLine("   3. Visualize algorithms step-by-step");
        Console.WriteLine("   4. Test with edge cases (empty, single element, duplicates)");
        Console.WriteLine("   5. Practice coding in interviews without IDE");
        Console.WriteLine();
        
        Console.WriteLine(">> INTERVIEW PREPARATION TIPS:");
        Console.WriteLine("   • Always discuss time/space complexity");
        Console.WriteLine("   • Ask about data characteristics (size, range, duplicates)");
        Console.WriteLine("   • Consider stability requirements");
        Console.WriteLine("   • Think about edge cases");
        Console.WriteLine("   • Mention production considerations");
        Console.WriteLine();
        
        Console.WriteLine(">> RECOMMENDED PRACTICE PROBLEMS:");
        Console.WriteLine("   • Merge K Sorted Arrays");
        Console.WriteLine("   • Kth Largest Element");
        Console.WriteLine("   • Sort Colors (Dutch Flag Problem)");
        Console.WriteLine("   • Wiggle Sort");
        Console.WriteLine("   • External Sorting for Large Files");
    }

    #endregion
}