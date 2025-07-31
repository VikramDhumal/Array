# Contributing to Sorting Algorithms Masterclass

Thank you for your interest in contributing to this educational project! ??

## ?? Table of Contents
- [Code of Conduct](#code-of-conduct)
- [How to Contribute](#how-to-contribute)
- [Development Setup](#development-setup)
- [Coding Standards](#coding-standards)
- [Pull Request Process](#pull-request-process)
- [Algorithm Implementation Guidelines](#algorithm-implementation-guidelines)

## ?? Code of Conduct

This project follows a simple code of conduct:
- Be respectful and constructive
- Focus on education and learning
- Welcome newcomers and help them learn
- Provide clear explanations for complex concepts

## ??? How to Contribute

### Types of Contributions Welcome:
- ?? **Bug fixes** - Fix issues in existing algorithms
- ?? **Documentation** - Improve explanations, add comments
- ? **New algorithms** - Add missing sorting algorithms
- ?? **Test cases** - Add edge cases and test scenarios
- ?? **UI improvements** - Enhance console output formatting
- ?? **Educational content** - Add interview tips, complexity analysis

### What NOT to contribute:
- Algorithms unrelated to sorting
- Complex GUI implementations (keep it console-based)
- Breaking changes without discussion

## ?? Development Setup

1. **Prerequisites:**
   - .NET 8.0 SDK or later
   - Git
   - Any IDE (Visual Studio, VS Code, Rider)

2. **Fork and Clone:**
   ```bash
   # Fork the repository on GitHub, then:
   git clone https://github.com/YOUR_USERNAME/sorting-algorithms-masterclass.git
   cd sorting-algorithms-masterclass
   ```

3. **Build and Test:**
   ```bash
   dotnet build
   dotnet run --project Sort
   ```

4. **Create a Branch:**
   ```bash
   git checkout -b feature/your-feature-name
   ```

## ?? Coding Standards

### C# Style Guidelines:
- Use **C# 12.0** features where appropriate
- Follow **PascalCase** for methods and classes
- Use **camelCase** for variables and parameters
- Include **XML documentation** for all public methods
- Add **inline comments** explaining algorithm logic

### Algorithm Documentation Format:
```csharp
/// <summary>
/// ALGORITHM_NAME - Brief Description
/// [PERFECT FOR] Use cases
/// [TIME] Time complexity | [SPACE] Space complexity | [STABLE] Yes/No
/// 
/// How it works:
/// 1. Step one explanation
/// 2. Step two explanation
/// 3. Step three explanation
/// 
/// [YOUTUBE TIP] Educational insight for viewers
/// </summary>
static void YourAlgorithm(int[] arr)
{
    // Implementation with clear comments
}
```

### Performance Guidelines:
- Include timing measurements
- Add complexity analysis in comments
- Verify correctness with `IsSorted()` check
- Handle edge cases (empty arrays, single elements)

## ?? Pull Request Process

1. **Before Starting:**
   - Check existing issues and PRs
   - Create an issue to discuss major changes
   - Ensure your contribution fits the educational scope

2. **Making Changes:**
   - Write clear, self-documenting code
   - Add comprehensive comments
   - Include complexity analysis
   - Test with various input sizes

3. **Submitting PR:**
   - Use descriptive commit messages
   - Reference related issues
   - Include testing notes
   - Update README if needed

4. **PR Template:**
   ```markdown
   ## Description
   Brief description of changes
   
   ## Type of Change
   - [ ] Bug fix
   - [ ] New algorithm
   - [ ] Documentation update
   - [ ] Performance improvement
   
   ## Testing
   - Tested with arrays of size: X, Y, Z
   - Edge cases tested: empty array, single element, duplicates
   - Performance verified: X ms for Y elements
   
   ## Educational Value
   - How does this help learners?
   - What interview concepts does it demonstrate?
   ```

## ?? Algorithm Implementation Guidelines

### Adding New Sorting Algorithms:

1. **Integration Points:**
   - Add to `DemonstrateAllSortingAlgorithms()` method
   - Include in complexity comparison table
   - Add to algorithm selection guide

2. **Required Elements:**
   ```csharp
   // 1. Comprehensive documentation
   /// <summary>
   /// [Complete documentation as shown above]
   /// </summary>
   
   // 2. Implementation
   static void YourSort(int[] arr)
   {
       // Clear, commented implementation
   }
   
   // 3. Helper methods if needed
   static void YourHelper(int[] arr, int param)
   {
       // Well-documented helper
   }
   ```

3. **Integration Example:**
   ```csharp
   ExecuteAndTimeSort("[TAG] ALGORITHM NAME", originalArray,
       arr => YourSort(arr),
       "Brief description of how it works.",
       "[CATEGORY] Practical tip or use case");
   ```

### Algorithm Categories:
- **[BASIC]** - O(n²) simple algorithms
- **[INTERMEDIATE]** - Improved O(n²) or specialized algorithms  
- **[ADVANCED]** - O(n log n) divide-and-conquer algorithms
- **[SPECIAL]** - Non-comparison algorithms
- **[HYBRID]** - Combined or adaptive algorithms

## ?? Educational Focus

Remember, this project is designed for:
- **Learning** - Help people understand algorithms
- **Interviews** - Prepare for technical interviews
- **Teaching** - Assist instructors and students
- **Reference** - Provide working examples

### When contributing, ask:
- Does this help someone learn sorting algorithms?
- Is the code clear and well-explained?
- Would this be useful in an interview context?
- Does it maintain the educational focus?

## ?? Getting Help

- ?? **Questions:** Create an issue with the "question" label
- ?? **Bug Reports:** Use the bug report template
- ?? **Feature Requests:** Discuss in issues first
- ?? **YouTube Channel:** Learn & Reflect: Software

## ?? Recognition

Contributors will be:
- Listed in the README
- Mentioned in YouTube videos (if applicable)
- Credited in code comments for major contributions

---

**Thank you for helping make this a valuable educational resource! ??**