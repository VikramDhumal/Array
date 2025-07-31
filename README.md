# 🚀 Complete Sorting Algorithms Masterclass

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![YouTube](https://img.shields.io/badge/YouTube-Learn%20%26%20Reflect%3A%20Software-red.svg)](https://youtube.com/@LearnReflectSoftware)

## 🎯 **Overview**

A comprehensive C# console application demonstrating **ALL major sorting algorithms** used in:
- 💼 **Programming Interviews** (FAANG companies)
- 🎓 **Computer Science Education** 
- 🏢 **Real-world Software Development**

Perfect for interview preparation, learning algorithms, and teaching sorting concepts!

## ⭐ **Features**

### 🔢 **12 Sorting Algorithms Covered**
- **Simple O(n²) Algorithms:** Bubble, Cocktail Shaker, Selection, Insertion, Shell Sort
- **Efficient O(n log n) Algorithms:** Merge, Quick, Heap Sort
- **Non-Comparison Algorithms:** Counting, Radix, Bucket Sort
- **Production Algorithm:** Built-in .NET IntroSort

### 🚀 **Key Features**
- ⏱️ **Performance Timing** for each algorithm
- 📊 **Complexity Analysis** with detailed comparisons
- 👀 **Algorithm Visualization** through console output
- 📖 **Comprehensive Documentation** with interview tips
- ✅ **Input Validation** and error handling
- 🎨 **Professional Console UI** with clear formatting

### 📚 **Educational Content**
- **Step-by-step explanations** for each algorithm
- **Time and space complexity** analysis
- **When to use each algorithm** guidance
- **Interview preparation tips** and best practices
- **Practice problems** recommendations

## 🚀 **Quick Start**

### **Prerequisites**
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Any IDE (Visual Studio, VS Code, Rider) or command line

### **Installation & Usage**

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/sorting-algorithms-masterclass.git
   cd sorting-algorithms-masterclass
   ```

2. **Build the project:**
   ```bash
   dotnet build
   ```

3. **Run the application:**
   ```bash
   dotnet run --project Sort
   ```

4. **Follow the prompts:**
   - Enter array elements separated by spaces
   - Watch all algorithms sort your data with performance metrics!

### **Example Usage**
```
Enter array elements separated by spaces:
64 34 25 12 22 11 90

>> ORIGINAL ARRAY:
[64, 34, 25, 12, 22, 11, 90]

[BUBBLE] BUBBLE SORT:
Description: Classic beginner algorithm. Repeatedly swaps adjacent elements.
Execution time: 15 ticks
Result: [11, 12, 22, 25, 34, 64, 90]
[SUCCESS] Array successfully sorted!
```

## 📊 **Algorithm Deep Dive**

### 🟡 **Simple Algorithms (Perfect for Learning)**

#### Bubble Sort - O(n²)
```
How it works:
1. Compare adjacent elements
2. Swap if they're in wrong order  
3. Largest element "bubbles up" after each pass
4. Repeat until no swaps needed

Best for: Teaching sorting concepts
```

#### Selection Sort - O(n²)
```
How it works:
1. Find minimum element in unsorted portion
2. Swap it with first unsorted element
3. Move boundary of sorted portion
4. Repeat until all sorted

Best for: Minimizing number of swaps
```

#### Insertion Sort - O(n²)
```
How it works:
1. Start with first element (considered sorted)
2. Take next element, insert in correct position
3. Shift larger elements to make room
4. Expand sorted portion

Best for: Small arrays, nearly sorted data
```

### 🟢 **Efficient Algorithms (Industry Standard)**

#### Merge Sort - O(n log n)
```
How it works:
1. Divide array into two halves
2. Recursively sort both halves
3. Merge the sorted halves
4. Guaranteed O(n log n) performance

Best for: Large datasets, stability required
```

#### Quick Sort - O(n log n) average
```
How it works:
1. Choose pivot element
2. Partition: smaller left, larger right
3. Recursively sort both partitions
4. In-place sorting with excellent cache performance

Best for: General purpose, random data
```

#### Heap Sort - O(n log n)
```
How it works:
1. Build max heap from array
2. Extract maximum (root), place at end
3. Heapify reduced heap
4. Repeat until heap is empty

Best for: Consistent performance guarantee
```

### 🟦 **Specialized Algorithms (Linear Time)**

#### Counting Sort - O(n + k)
```
How it works:
1. Count frequency of each element
2. Calculate cumulative counts (positions)
3. Place elements at calculated positions
4. Non-comparison based algorithm

Best for: Small integer ranges
```

#### Radix Sort - O(d × n)
```
How it works:
1. Sort by least significant digit first
2. Use counting sort for each digit
3. Move to next digit
4. Continue until most significant digit

Best for: Multi-digit integers
```

## 📈 **Algorithm Comparison**

| Algorithm | Best Case | Average Case | Worst Case | Stable | Space | Use Case |
|-----------|-----------|--------------|------------|--------|-------|----------|
| **Bubble Sort** | O(n) | O(n²) | O(n²) | ✅ YES | O(1) | 🎓 Learning |
| **Cocktail Sort** | O(n) | O(n²) | O(n²) | ✅ YES | O(1) | 🎓 Teaching optimizations |
| **Selection Sort** | O(n²) | O(n²) | O(n²) | ❌ NO | O(1) | 🔧 Minimal swaps |
| **Insertion Sort** | O(n) | O(n²) | O(n²) | ✅ YES | O(1) | 📦 Small/nearly sorted |
| **Shell Sort** | O(n log n) | O(n^1.5) | O(n²) | ❌ NO | O(1) | ⚖️ Medium arrays |
| **Merge Sort** | O(n log n) | O(n log n) | O(n log n) | ✅ YES | O(n) | 🏢 Large datasets |
| **Quick Sort** | O(n log n) | O(n log n) | O(n²) | ❌ NO | O(log n) | 🚀 General purpose |
| **Heap Sort** | O(n log n) | O(n log n) | O(n log n) | ❌ NO | O(1) | ⏰ Real-time systems |
| **Counting Sort** | O(n + k) | O(n + k) | O(n + k) | ✅ YES | O(k) | 🔢 Integer ranges |
| **Radix Sort** | O(d × n) | O(d × n) | O(d × n) | ✅ YES | O(n + k) | 📊 Multi-digit numbers |

## 🎯 **Algorithm Selection Guide**

| 💼 Use Case | 🏆 Recommended Algorithm | 📝 Why? |
|-------------|-------------------------|---------|
| 🎓 Learning/Teaching | Bubble Sort, Selection Sort, Insertion Sort | Easy to understand and visualize |
| 📦 Small arrays (< 50) | Insertion Sort | Low overhead, efficient for small data |
| 🚀 General purpose | Quick Sort, Merge Sort | Best overall performance |
| ⏰ Guaranteed O(n log n) | Merge Sort, Heap Sort | Predictable performance |
| 💾 Memory constrained | Heap Sort, Quick Sort | In-place sorting |
| 🔄 Stability required | Merge Sort, Counting Sort, Radix Sort | Maintains relative order |
| 🔢 Integer ranges | Counting Sort, Radix Sort | Linear time for specific data types |
| 🏢 Production code | Built-in Sort (IntroSort hybrid) | Optimized, tested, maintained |

## 🎥 **YouTube Series**

This project is part of the **"Learn & Reflect: Software"** YouTube channel series on algorithms and data structures.

**📺 [Watch the Complete Tutorial](https://youtube.com/@LearnReflectSoftware)**

### **🎬 Video Topics Covered:**
- 📋 Algorithm implementation walkthroughs
- 📊 Performance analysis and benchmarking
- 💼 Interview question preparation
- 🏢 Real-world applications
- 🔧 Code optimization techniques

## 💼 **Interview Preparation**

### **🔑 Key Topics to Master:**
- ⏱️ **Time/Space Complexity Analysis**
- 🎯 **Algorithm Selection Criteria**
- 🔄 **Stability Requirements**
- 🔍 **Edge Case Handling**
- 🏢 **Production Considerations**

### **💡 Common Interview Questions:**
1. **"Sort an array of integers"** → Quick Sort or Merge Sort
2. **"Sort with limited memory"** → Heap Sort or in-place Quick Sort
3. **"Sort strings by length"** → Stable sort (Merge Sort)
4. **"Sort colors (0,1,2)"** → Counting Sort or Dutch Flag
5. **"Find Kth largest element"** → Quick Select or Heap

### **🎯 Practice Problems:**
- 🔗 Merge K Sorted Arrays
- 🏆 Kth Largest Element
- 🌈 Sort Colors (Dutch Flag Problem)
- 📈 Wiggle Sort
- 💾 External Sorting for Large Files

## 🗂️ **Project Structure**

```
sorting-algorithms-masterclass/
│
├── Sort/
│   ├── Program.cs          # Main application with all algorithms
│   └── Sort.csproj         # Project configuration
│
├── .github/workflows/
│   └── dotnet.yml          # CI/CD pipeline
│
├── README.md               # This comprehensive guide
├── CONTRIBUTING.md         # Contribution guidelines
├── LICENSE                 # MIT License
└── .gitignore             # Git ignore patterns
```

## 🤝 **Contributing**

Contributions are welcome! Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on:
- Code of conduct
- Development setup
- Pull request process
- Algorithm implementation guidelines

### **🚀 Ways to Contribute:**
- 🐛 Bug fixes and improvements
- 📖 Documentation enhancements
- ➕ New sorting algorithm implementations
- 🧪 Additional test cases
- 🎨 UI/UX improvements

## 📄 **License**

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 **Author**

**Learn & Reflect: Software**
- 📺 [YouTube Channel](https://youtube.com/@LearnReflectSoftware)
- 🐙 [GitHub Profile](https://github.com/VikramDhumal)

## 🙏 **Acknowledgments**

- Inspired by classic computer science algorithms
- Built for educational purposes and interview preparation
- Optimized for .NET 8 and modern C# features

## 🗺️ **Roadmap**

- [ ] Add visualization graphics for algorithms
- [ ] Implement sorting for custom objects
- [ ] Add parallel sorting algorithms
- [ ] Create interactive web version
- [ ] Add performance benchmarking suite
- [ ] Implement external sorting algorithms

---

### 🎯 **Perfect for:**
- 🎓 Computer Science Students
- 💼 Software Engineering Interviews
- 👩‍🏫 Programming Instructors
- 🔬 Algorithm Enthusiasts

**⭐ Star this repository if it helped you ace your interviews!**

---

### 📱 **Quick Demo Examples for YouTube**

**Example 1 - Small Array:**
```
Input: 64 34 25 12 22 11 90
Shows: All algorithm performance comparison
```

**Example 2 - Reverse Sorted:**
```
Input: 100 90 80 70 60 50 40 30 20 10
Shows: Worst-case scenarios for some algorithms
```

**Example 3 - Nearly Sorted:**
```
Input: 10 20 15 30 25 40 35 50
Shows: Best-case scenarios (Insertion Sort shines!)
```

**Example 4 - Duplicates:**
```
Input: 5 2 8 2 9 1 5 4
Shows: Stability differences between algorithms