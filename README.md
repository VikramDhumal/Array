# 🎬 Complete Array Sorting Algorithms Tutorial
## Master Every Sorting Algorithm | Learn & Reflect: Software

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![YouTube](https://img.shields.io/badge/YouTube-Learn%20%26%20Reflect%3A%20Software-red.svg)](https://youtube.com/@LearnReflectSoftware)

---

## 📖 **Welcome to the Ultimate Sorting Algorithms Tutorial!**

> **This comprehensive guide covers ALL 12 major sorting algorithms used in programming interviews, computer science education, and real-world software development.**

**Perfect for:**
- 💼 **FAANG Company Interviews** (Google, Amazon, Meta, Apple, Netflix)
- 🎓 **Computer Science Students** learning algorithms
- 👨‍💻 **Software Engineers** preparing for technical interviews
- 👩‍🏫 **Programming Instructors** teaching sorting concepts

---

## 🎯 **What You'll Learn in This Tutorial**

### 📚 **Complete Algorithm Coverage**
- **4 Simple O(n²) Algorithms** - Perfect for learning fundamentals
- **3 Efficient O(n log n) Algorithms** - Industry standard solutions
- **3 Specialized Linear Time Algorithms** - For specific data types
- **2 Advanced/Hybrid Algorithms** - Real-world optimized solutions

### 🔍 **Deep Understanding**
- **Step-by-step implementations** with detailed code explanations
- **Time and space complexity analysis** for every algorithm
- **When to use each algorithm** in different scenarios
- **Interview tips and best practices** from industry experience
- **Live performance comparisons** with actual timing data

---

## 🏗️ **Section 1: Simple Sorting Algorithms (O(n²))**
*Perfect for understanding sorting fundamentals*

### 🫧 **1. Bubble Sort - The Teaching Classic**

**Concept:** Compare adjacent elements and swap if they're in wrong order. Largest elements "bubble up" to the end.

```csharp
static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    bool swapped;
    
    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;
        
        // Last i elements are already sorted
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                // Swap using C# tuple deconstruction
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                swapped = true;
            }
        }
        
        // Optimization: If no swaps, array is sorted
        if (!swapped) break;
    }
}
```

**📊 Complexity Analysis:**
- **Time:** O(n²) worst/average, O(n) best (already sorted)
- **Space:** O(1) - in-place sorting
- **Stable:** Yes - maintains relative order of equal elements

**💡 When to Use:**
- Teaching sorting concepts to beginners
- Small datasets where simplicity matters
- When you need a stable, in-place sort

**🎯 Interview Insight:** Interviewers often ask about optimizations. The `swapped` flag optimization is crucial!

---

### 🎯 **2. Selection Sort - Minimum Selection Strategy**

**Concept:** Find the minimum element and place it at the beginning. Repeat for remaining array.

```csharp
static void SelectionSort(int[] arr)
{
    int n = arr.Length;
    
    for (int i = 0; i < n - 1; i++)
    {
        // Find minimum element index
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
                minIndex = j;
        }
        
        // Swap only if needed
        if (minIndex != i)
            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
    }
}
```

**📊 Complexity Analysis:**
- **Time:** O(n²) all cases - always scans entire remaining array
- **Space:** O(1) - in-place sorting
- **Stable:** No - can change relative order of equal elements

**💡 When to Use:**
- When minimizing number of swaps is important (exactly n-1 swaps)
- Memory writes are expensive operations
- Simple implementation needed

**🎯 Interview Insight:** Highlight that it performs exactly n-1 swaps, making it efficient for scenarios where writes are costly.

---

### 📥 **3. Insertion Sort - Building Sorted Sequence**

**Concept:** Build the sorted array one element at a time by inserting each element in its correct position.

```csharp
static void InsertionSort(int[] arr)
{
    int n = arr.Length;
    
    for (int i = 1; i < n; i++)
    {
        int key = arr[i];  // Element to be positioned
        int j = i - 1;
        
        // Shift elements greater than key
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        
        // Insert key at correct position
        arr[j + 1] = key;
    }
}
```

**📊 Complexity Analysis:**
- **Time:** O(n²) worst, O(n) best (nearly sorted)
- **Space:** O(1) - in-place sorting
- **Stable:** Yes - maintains relative order

**💡 When to Use:**
- Small arrays (< 50 elements) - industry standard choice
- Nearly sorted data - performs excellently
- Online algorithms - can sort data as it arrives

**🎯 Interview Insight:** This is actually used in production! Many libraries use insertion sort for small subarrays in hybrid algorithms.

---

### 🔄 **4. Shell Sort - Gap-Based Optimization**

**Concept:** Perform insertion sort with decreasing gap sizes. Final pass with gap=1 is regular insertion sort.

```csharp
static void ShellSort(int[] arr)
{
    int n = arr.Length;
    
    // Start with large gap, then reduce
    for (int gap = n / 2; gap > 0; gap /= 2)
    {
        // Perform gapped insertion sort
        for (int i = gap; i < n; i++)
        {
            int temp = arr[i];
            int j;
            
            // Shift earlier gap-sorted elements
            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                arr[j] = arr[j - gap];
                
            arr[j] = temp;
        }
    }
}
```

**📊 Complexity Analysis:**
- **Time:** O(n log n) average, O(n^1.5) typical
- **Space:** O(1) - in-place sorting
- **Stable:** No - gaps can change relative order

**💡 When to Use:**
- Medium-sized arrays where O(n log n) is overkill
- When you need better than O(n²) but want simplicity
- Embedded systems with memory constraints

---

## ⚡ **Section 2: Efficient Sorting Algorithms (O(n log n))**
*Industry standard algorithms for large datasets*

### 🔄 **5. Merge Sort - Divide and Conquer Champion**

**Concept:** Divide array into halves, recursively sort each half, then merge the sorted halves.

```csharp
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

static void Merge(int[] arr, int left, int mid, int right)
{
    // Create temporary arrays for left and right subarrays
    int leftSize = mid - left + 1;
    int rightSize = right - mid;
    
    int[] leftArray = new int[leftSize];
    int[] rightArray = new int[rightSize];
    
    // Copy data to temporary arrays
    Array.Copy(arr, left, leftArray, 0, leftSize);
    Array.Copy(arr, mid + 1, rightArray, 0, rightSize);
    
    // Merge back into original array
    int i = 0, j = 0, k = left;
    
    while (i < leftSize && j < rightSize)
    {
        if (leftArray[i] <= rightArray[j])
            arr[k++] = leftArray[i++];
        else
            arr[k++] = rightArray[j++];
    }
    
    // Copy remaining elements
    while (i < leftSize) arr[k++] = leftArray[i++];
    while (j < rightSize) arr[k++] = rightArray[j++];
}
```

**📊 Complexity Analysis:**
- **Time:** O(n log n) all cases - guaranteed performance
- **Space:** O(n) - requires additional memory for merging
- **Stable:** Yes - maintains relative order

**💡 When to Use:**
- Large datasets where stability is required
- When guaranteed O(n log n) performance is needed
- Linked lists (no random access penalty)
- External sorting (sorting data that doesn't fit in memory)

**🎯 Interview Insight:** Emphasize the guaranteed O(n log n) performance - unlike QuickSort, it never degrades to O(n²).

---

### ⚡ **6. Quick Sort - The Speed Demon**

**Concept:** Choose a pivot, partition array so smaller elements are left of pivot, larger elements are right. Recursively sort partitions.

```csharp
static void QuickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        // Partition and get pivot position
        int pivotIndex = Partition(arr, low, high);
        
        // Recursively sort partitions
        QuickSort(arr, low, pivotIndex - 1);
        QuickSort(arr, pivotIndex + 1, high);
    }
}

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
```

**📊 Complexity Analysis:**
- **Time:** O(n log n) average, O(n²) worst case (rare)
- **Space:** O(log n) - recursive stack space
- **Stable:** No - partitioning can change relative order

**💡 When to Use:**
- General-purpose sorting - most popular choice
- Large random datasets
- When average-case performance matters most
- In-place sorting with good cache performance

**🎯 Interview Insight:** Discuss pivot selection strategies and how to avoid worst-case O(n²) behavior.

---

### 🏗️ **7. Heap Sort - The Consistent Performer**

**Concept:** Build a max heap, then repeatedly extract the maximum element and place it at the end.

```csharp
static void HeapSort(int[] arr)
{
    int n = arr.Length;
    
    // Build max heap
    for (int i = n / 2 - 1; i >= 0; i--)
        Heapify(arr, n, i);
    
    // Extract elements from heap one by one
    for (int i = n - 1; i > 0; i--)
    {
        // Move current root to end
        (arr[0], arr[i]) = (arr[i], arr[0]);
        
        // Heapify reduced heap
        Heapify(arr, i, 0);
    }
}

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
    
    // If largest is not root, swap and heapify affected sub-tree
    if (largest != rootIndex)
    {
        (arr[rootIndex], arr[largest]) = (arr[largest], arr[rootIndex]);
        Heapify(arr, heapSize, largest);
    }
}
```

**📊 Complexity Analysis:**
- **Time:** O(n log n) all cases - consistent performance
- **Space:** O(1) - in-place sorting
- **Stable:** No - heap operations can change relative order

**💡 When to Use:**
- Real-time systems requiring guaranteed O(n log n)
- Memory-constrained environments
- When worst-case performance matters

**🎯 Interview Insight:** Highlight that it guarantees O(n log n) unlike QuickSort, making it suitable for systems with strict timing requirements.

---

## 🚀 **Section 3: Specialized Linear Time Algorithms**
*Non-comparison based sorts for specific data types*

### 🔢 **8. Counting Sort - The Linear Time Marvel**

**Concept:** Count frequency of each element, then use counts to place elements in correct positions.

```csharp
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
        count[num - min]++;
    
    // Calculate cumulative count (positions)
    for (int i = 1; i < range; i++)
        count[i] += count[i - 1];
    
    // Build output array (reverse order for stability)
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        output[count[arr[i] - min] - 1] = arr[i];
        count[arr[i] - min]--;
    }
    
    // Copy back to original array
    Array.Copy(output, arr, arr.Length);
}
```

**📊 Complexity Analysis:**
- **Time:** O(n + k) where k is the range of input
- **Space:** O(k) for the counting array
- **Stable:** Yes - preserves relative order

**💡 When to Use:**
- Small integer ranges (k is not significantly larger than n)
- When linear time sorting is needed
- As a subroutine for other algorithms (like Radix Sort)

**🎯 Interview Insight:** This breaks the O(n log n) lower bound for comparison-based sorts! Explain why it's not always applicable.

---

### 📊 **9. Radix Sort - The Multi-Digit Specialist**

**Concept:** Sort by individual digits, starting from least significant digit, using counting sort for each digit.

```csharp
static void RadixSort(int[] arr)
{
    if (arr.Length == 0) return;
    
    // Find maximum to determine number of digits
    int max = arr[0];
    foreach (int num in arr)
        if (num > max) max = num;
    
    // Sort by each digit using counting sort
    for (int exp = 1; max / exp > 0; exp *= 10)
        CountingSortByDigit(arr, exp);
}

static void CountingSortByDigit(int[] arr, int exp)
{
    int[] output = new int[arr.Length];
    int[] count = new int[10]; // For digits 0-9
    
    // Count frequency of each digit
    foreach (int num in arr)
        count[(num / exp) % 10]++;
    
    // Calculate cumulative count
    for (int i = 1; i < 10; i++)
        count[i] += count[i - 1];
    
    // Build output array
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        output[count[(arr[i] / exp) % 10] - 1] = arr[i];
        count[(arr[i] / exp) % 10]--;
    }
    
    // Copy back to original
    Array.Copy(output, arr, arr.Length);
}
```

**📊 Complexity Analysis:**
- **Time:** O(d × n) where d is the number of digits
- **Space:** O(n + k) where k is the digit range (10 for decimal)
- **Stable:** Yes - maintains relative order

**💡 When to Use:**
- Sorting large integers or fixed-length strings
- When the number of digits is small
- Situations requiring stable sorting of numeric data

---

### 🪣 **10. Bucket Sort - The Distribution Strategy**

**Concept:** Distribute elements into buckets, sort each bucket individually, then concatenate.

```csharp
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
        buckets[i] = new List<int>();
    
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
            Array.Sort(bucketArray); // Use efficient sort for individual buckets
            
            foreach (int num in bucketArray)
                arr[index++] = num;
        }
    }
}
```

**📊 Complexity Analysis:**
- **Time:** O(n + k) average, O(n²) worst case
- **Space:** O(n + k) for buckets
- **Stable:** Yes (if underlying sort is stable)

**💡 When to Use:**
- Uniformly distributed data
- Floating-point numbers
- When input range is known and reasonable

---

## 🔧 **Section 4: Production-Ready Algorithm**

### 🎯 **11. Built-in Sort (.NET) - IntroSort Hybrid**

**Concept:** Hybrid algorithm combining QuickSort, HeapSort, and InsertionSort for optimal performance.

```csharp
// Simple usage - but incredibly sophisticated under the hood!
Array.Sort(arr);

// What it actually does:
// 1. QuickSort for general cases
// 2. HeapSort when QuickSort depth limit exceeded (avoids O(n²))
// 3. InsertionSort for small partitions (< 16 elements)
```

**📊 Complexity Analysis:**
- **Time:** O(n log n) worst case guaranteed
- **Space:** O(log n) average
- **Stable:** No (but Array.Sort has stable overloads)

**💡 When to Use:**
- Production code - always prefer this unless you have specific requirements
- When you need proven, optimized performance
- Most interview scenarios (mention you'd use this in real code)

---

## 📊 **Complete Algorithm Comparison Table**

| Algorithm | Best Case | Average Case | Worst Case | Stable | Space | Best Use Case |
|-----------|-----------|--------------|------------|--------|-------|--------------|
| **Bubble Sort** | O(n) | O(n²) | O(n²) | ✅ Yes | O(1) | 🎓 Learning/Teaching |
| **Selection Sort** | O(n²) | O(n²) | O(n²) | ❌ No | O(1) | 🔧 Minimal swaps needed |
| **Insertion Sort** | O(n) | O(n²) | O(n²) | ✅ Yes | O(1) | 📦 Small/nearly sorted arrays |
| **Shell Sort** | O(n log n) | O(n^1.5) | O(n²) | ❌ No | O(1) | ⚖️ Medium arrays |
| **Merge Sort** | O(n log n) | O(n log n) | O(n log n) | ✅ Yes | O(n) | 🏢 Large datasets, stability |
| **Quick Sort** | O(n log n) | O(n log n) | O(n²) | ❌ No | O(log n) | 🚀 General purpose |
| **Heap Sort** | O(n log n) | O(n log n) | O(n log n) | ❌ No | O(1) | ⏰ Guaranteed performance |
| **Counting Sort** | O(n + k) | O(n + k) | O(n + k) | ✅ Yes | O(k) | 🔢 Small integer ranges |
| **Radix Sort** | O(d × n) | O(d × n) | O(d × n) | ✅ Yes | O(n + k) | 📊 Multi-digit numbers |
| **Bucket Sort** | O(n + k) | O(n + k) | O(n²) | ✅ Yes | O(n + k) | 📈 Uniform distribution |
| **IntroSort** | O(n log n) | O(n log n) | O(n log n) | ❌ No | O(log n) | 🏭 Production code |

---

## 🎯 **Interview Strategy Guide**

### 🔑 **Key Questions to Ask Interviewers:**

1. **"What's the size of the input data?"**
   - Small (< 50): Consider Insertion Sort
   - Large: Quick Sort or Merge Sort

2. **"Is stability required?"**
   - Yes: Merge Sort, Counting Sort, Radix Sort
   - No: Quick Sort, Heap Sort are fine

3. **"What's the data type and range?"**
   - Small integers: Counting Sort or Radix Sort
   - General data: Comparison-based sorts

4. **"Are there memory constraints?"**
   - Yes: Heap Sort, Quick Sort (in-place)
   - No: Merge Sort is fine

5. **"Is this for production code?"**
   - Yes: Use built-in sorting functions
   - Interview: Implement the chosen algorithm

### 💡 **Interview Best Practices:**

1. **Always start with clarifying questions**
2. **Discuss time/space complexity before coding**
3. **Mention the production approach** (built-in sorts)
4. **Consider edge cases** (empty array, single element, duplicates)
5. **Test with examples** during implementation

---

## 🚀 **Quick Start - Run the Demo**

### **Prerequisites**
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

### **Installation & Usage**

```bash
# Clone the repository
git clone https://github.com/VikramDhumal/sorting-algorithms-masterclass.git
cd sorting-algorithms-masterclass

# Build and run
dotnet build
dotnet run --project Sort
```

### **Demo Examples to Try:**

**Small Array (Educational):**
```
Input: 64 34 25 12 22 11 90
Shows: All algorithms with clear performance differences
```

**Reverse Sorted (Worst Case):**
```
Input: 100 90 80 70 60 50 40 30 20 10  
Shows: How algorithms perform in worst-case scenarios
```

**Nearly Sorted (Best Case):**
```
Input: 10 20 15 30 25 40 35 50
Shows: How adaptive algorithms like Insertion Sort excel
```

**With Duplicates (Stability Test):**
```
Input: 5 2 8 2 9 1 5 4
Shows: Difference between stable and unstable sorts
```

---

## 👨‍💻 **About Learn & Reflect: Software**

This tutorial is brought to you by **Learn & Reflect: Software** - a YouTube channel dedicated to making complex programming concepts accessible through clear explanations and practical examples.

**📺 [Subscribe to Learn & Reflect: Software](https://youtube.com/@LearnReflectSoftware)**

### **More Content Coming Soon:**
- 🔗 **Data Structures Deep Dives** (Linked Lists, Trees, Graphs)
- 🧮 **Advanced Algorithms** (Dynamic Programming, Graph Algorithms)
- 💼 **System Design Fundamentals** (Scalability, Architecture Patterns)
- 🎯 **Interview Preparation Series** (Coding Patterns, Problem-Solving Strategies)

---

## ⭐ **Next Steps**

1. **🎥 Watch the full video tutorial** to see these algorithms in action
2. **💻 Clone and run the code** to experiment with different inputs  
3. **🎯 Practice implementing** each algorithm from scratch
4. **📚 Study the complexity analysis** until it becomes second nature
5. **🔥 Apply to interview problems** and real-world scenarios

**Don't forget to ⭐ star this repository if it helped you understand sorting algorithms!**

---

*"Understanding sorting algorithms isn't just about memorizing code - it's about developing algorithmic thinking that will serve you throughout your programming career."*

**- Learn & Reflect: Software**