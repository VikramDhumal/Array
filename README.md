# ?? Complete Sorting Algorithms Masterclass

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![YouTube](https://img.shields.io/badge/YouTube-Learn%20%26%20Reflect%3A%20Software-red.svg)](https://youtube.com/@LearnReflectSoftware)

## ?? **Overview**

A comprehensive C# console application demonstrating **ALL major sorting algorithms** used in:
- ?? **Programming Interviews** (FAANG companies)
- ?? **Computer Science Education** 
- ?? **Real-world Software Development**

Perfect for interview preparation, learning algorithms, and teaching sorting concepts!

## ? **Features**

### ?? **12 Sorting Algorithms Covered**
- **Simple O(n²) Algorithms:** Bubble, Cocktail Shaker, Selection, Insertion, Shell Sort
- **Efficient O(n log n) Algorithms:** Merge, Quick, Heap Sort
- **Non-Comparison Algorithms:** Counting, Radix, Bucket Sort
- **Production Algorithm:** Built-in .NET IntroSort

### ?? **Key Features**
- ? **Performance Timing** for each algorithm
- ?? **Complexity Analysis** with detailed comparisons
- ?? **Algorithm Visualization** through console output
- ?? **Comprehensive Documentation** with interview tips
- ? **Input Validation** and error handling
- ?? **Professional Console UI** with clear formatting

### ?? **Educational Content**
- **Step-by-step explanations** for each algorithm
- **Time and space complexity** analysis
- **When to use each algorithm** guidance
- **Interview preparation tips** and best practices
- **Practice problems** recommendations

## ?? **Quick Start**

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

## ?? **Algorithm Comparison**

| Algorithm | Best Case | Average Case | Worst Case | Stable | Space |
|-----------|-----------|--------------|------------|--------|-------|
| Bubble Sort | O(n) | O(n²) | O(n²) | YES | O(1) |
| Selection Sort | O(n²) | O(n²) | O(n²) | NO | O(1) |
| Insertion Sort | O(n) | O(n²) | O(n²) | YES | O(1) |
| Merge Sort | O(n log n) | O(n log n) | O(n log n) | YES | O(n) |
| Quick Sort | O(n log n) | O(n log n) | O(n²) | NO | O(log n) |
| Heap Sort | O(n log n) | O(n log n) | O(n log n) | NO | O(1) |
| Counting Sort | O(n + k) | O(n + k) | O(n + k) | YES | O(k) |
| Radix Sort | O(d × n) | O(d × n) | O(d × n) | YES | O(n + k) |

## ?? **Algorithm Selection Guide**

| Use Case | Recommended Algorithm |
|----------|----------------------|
| ?? Learning/Teaching | Bubble Sort, Selection Sort, Insertion Sort |
| ?? Small arrays (< 50) | Insertion Sort |
| ?? General purpose | Quick Sort, Merge Sort |
| ??? Guaranteed O(n log n) | Merge Sort, Heap Sort |
| ?? Memory constrained | Heap Sort, Quick Sort |
| ?? Stability required | Merge Sort, Counting Sort, Radix Sort |
| ?? Integer ranges | Counting Sort, Radix Sort |
| ?? Production code | Built-in Sort (IntroSort hybrid) |

## ?? **YouTube Series**

This project is part of the **"Learn & Reflect: Software"** YouTube channel series on algorithms and data structures.

**?? [Watch the Complete Tutorial](https://youtube.com/@LearnReflectSoftware)**

### **Video Topics Covered:**
- Algorithm implementation walkthroughs
- Performance analysis and benchmarking
- Interview question preparation
- Real-world applications
- Code optimization techniques

## ?? **Interview Preparation**

### **Key Topics to Master:**
- ? **Time/Space Complexity Analysis**
- ?? **Algorithm Selection Criteria**
- ?? **Stability Requirements**
- ?? **Edge Case Handling**
- ?? **Production Considerations**

### **Practice Problems:**
- ?? Merge K Sorted Arrays
- ?? Kth Largest Element
- ?? Sort Colors (Dutch Flag Problem)
- ?? Wiggle Sort
- ? External Sorting for Large Files

## ??? **Project Structure**

```
sorting-algorithms-masterclass/
?
??? Sort/
?   ??? Program.cs          # Main application with all algorithms
?   ??? Sort.csproj         # Project configuration
?
??? README.md               # This file
??? LICENSE                 # MIT License
??? .gitignore             # Git ignore patterns
??? CONTRIBUTING.md         # Contribution guidelines
```

## ?? **Contributing**

Contributions are welcome! Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on:
- Code of conduct
- Development setup
- Pull request process
- Algorithm implementation guidelines

### **Ways to Contribute:**
- ?? Bug fixes and improvements
- ?? Documentation enhancements
- ? New sorting algorithm implementations
- ?? Additional test cases
- ?? UI/UX improvements

## ?? **License**

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## ????? **Author**

**Learn & Reflect: Software**
- ?? [YouTube Channel](https://youtube.com/@LearnReflectSoftware)
- ?? [GitHub Profile](https://github.com/yourusername)

## ?? **Acknowledgments**

- Inspired by classic computer science algorithms
- Built for educational purposes and interview preparation
- Optimized for .NET 8 and modern C# features

## ?? **Roadmap**

- [ ] Add visualization graphics for algorithms
- [ ] Implement sorting for custom objects
- [ ] Add parallel sorting algorithms
- [ ] Create interactive web version
- [ ] Add performance benchmarking suite
- [ ] Implement external sorting algorithms

---

### ?? **Perfect for:**
- ?? Computer Science Students
- ?? Software Engineering Interviews
- ????? Programming Instructors
- ?? Algorithm Enthusiasts

**? Star this repository if it helped you ace your interviews!**