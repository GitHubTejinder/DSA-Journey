# Day 1 - What is an Algorithm?

## 🎯 Key Takeaways

- An algorithm is a finite sequence of well-defined steps used to solve a problem or accomplish a task.
- Source code is written by humans, but computers execute machine code.
- Compilation is the process of translating source code into machine-executable code (or an intermediate representation, depending on the platform).
- An efficient algorithm minimizes resource usage such as execution time and memory, not just execution time.
- Big-O does not measure actual execution time. It describes how the amount of work grows as the input size increases.
- Binary Search is significantly faster than Linear Search because it eliminates half of the remaining search space after each comparison.
- Choosing the right algorithm often has a much greater impact on performance than choosing faster hardware.

---

## 💼 Connections to My Experience

- Every backend service is an algorithm that transforms input into output.
- Kafka consumers execute a sequence of well-defined steps to process incoming messages.
- Azure Functions follow deterministic workflows that are essentially algorithms.
- Production issues are often caused by inefficient algorithms or incorrect assumptions rather than syntax errors.
- Designing scalable software starts with choosing the right algorithm before optimizing infrastructure.

---

## ⚠️ Common Mistakes

- Thinking an algorithm only refers to complex mathematical problems.
- Believing faster hardware can always compensate for a poor algorithm.
- Assuming an algorithm only needs to produce the correct result without considering efficiency.
- Confusing source code with machine code.

---

## 🧠 Interview Nuggets

- Interviewers care about both correctness and efficiency.
- Always explain *why* you selected a particular algorithm.
- Mention possible alternatives and the trade-offs involved.
- A working solution is good; a scalable solution is better.

---

## ⭐ Mentor Notes

As a senior engineer, you've already been designing algorithms throughout your career—you just may not have called them algorithms. Every API workflow, event-processing pipeline, and business rule implementation is an algorithm. This course is about putting names and theory behind concepts you've already been applying in practice.

# Day 2 - Big-O Notation

## 🎯 Key Takeaways

- Time Complexity describes how the number of operations performed by an algorithm grows as the input size increases.
- Big-O focuses on the growth rate of an algorithm rather than actual execution time.
- Constant factors are ignored because they do not change the growth pattern of an algorithm.
- Sequential operations add their complexities (e.g., O(n) + O(n) = O(2n) = O(n)).
- Nested loops are not always O(n²); the complexity depends on how the inner loop scales with the input.
- Loops that repeatedly double or halve the input (e.g., i *= 2 or n /= 2) typically have O(log n) complexity.
- When combining complexities, the dominant growth rate determines the final Big-O (e.g., O(n + log n) = O(n)).
- Two algorithms with the same Big-O can still have different actual runtimes because of constant factors, implementation details, and hardware.

---

## 💼 Connections to My Experience

- Looking up a Bot using Dictionary<TKey, TValue> is generally much more efficient than scanning a List<Bot>.
- Database indexes exist to reduce the number of operations required to retrieve data.
- Optimizing an inefficient algorithm usually provides a greater performance improvement than upgrading hardware.
- Performance reviews of backend services should consider algorithmic complexity before infrastructure changes.
- Choosing appropriate collections in C# directly impacts the complexity of common operations.

---

## ⚠️ Common Mistakes

- Thinking Big-O measures milliseconds or seconds.
- Assuming every nested loop has O(n²) complexity.
- Forgetting to ignore constant factors.
- Multiplying the complexity of sequential loops instead of adding them.
- Assuming two O(n) algorithms always perform identically in practice.

---

## 🧠 Interview Nuggets

- Explain your reasoning before stating the final complexity.
- Mention whether loops are sequential or nested.
- Identify whether the inner loop depends on the input size.
- State the unsimplified complexity first (e.g., O(2n), O(n + log n)) and then simplify it.
- Interviewers usually care more about your thought process than arriving at the correct answer immediately.

---

## ⭐ Mentor Notes

Don't memorize Big-O values. Learn to estimate the number of operations performed by the algorithm, and the complexity will naturally follow. Every time you write a loop, pause for a moment and ask yourself: "How does the number of operations change if the input size doubles?" If you build that habit, complexity analysis will eventually become second nature.

# Day 3 - Space Complexity & Complete Algorithm Analysis

## 🎯 Key Takeaways

- Every algorithm has two major costs:
  - Time Complexity → How the number of operations grows as input size increases.
  - Space Complexity → How the extra memory usage grows as input size increases.

- Space Complexity focuses mainly on additional memory allocated by the algorithm (auxiliary space).

- Creating a few variables does not depend on input size, so it is considered constant space: O(1).

Example:
int max;
int left;
int right;

Whether the input has 10 elements or 10 million elements, these variables remain constant.

- Creating additional data structures that grow with input size usually results in O(n) space.

Example:
Creating a new array with the same size as the input.

- In-place algorithms modify the existing data structure instead of creating additional copies.

Example:
Reverse Array using swapping:
Time: O(n)
Space: O(1)

- Extra memory usage is not always bad. Sometimes we intentionally use more memory to improve performance, readability, or safety.

- The best algorithm depends on constraints. There is rarely a universally perfect solution.

- Optimizing software is about understanding trade-offs:
  - Speed
  - Memory
  - Maintainability
  - Data safety

---

## 💼 Connections to My Experience

- Caching systems like Redis use additional memory to reduce lookup time.

- Database indexes consume additional storage but make queries much faster.

- Dictionary<TKey, TValue> uses more memory than a simple List<T>, but provides faster lookups.

- Creating copies of data can be useful when immutability or preserving original state is important.

- Large-scale systems often intentionally duplicate data to improve performance.

Examples:
  - Caches
  - Read replicas
  - Materialized views

These are all examples of time vs space trade-offs.

---

## ⚠️ Common Mistakes

- Thinking lower space complexity is always better.

Wrong:
"Always choose O(1) space."

Correct:
"Choose based on system requirements."

---

- Counting input data as extra space.

Example:

int FindMax(int[] nums)

nums is input.

The extra variable:

int max

is auxiliary space.

---

- Assuming every Dictionary has O(n) space without considering unique values.

Better explanation:

Space = O(k)

where k = number of unique elements.

Worst case:
k = n

Therefore:
O(n)

---

- Forgetting recursion uses memory.

Recursive calls consume stack space.

---

## 🧠 Interview Nuggets

- Always analyze both time and space complexity.

A strong answer:

"This solution runs in O(n) time because every element is visited once. It uses O(1) extra space because only a fixed number of variables are created."

---

- Explain trade-offs.

Instead of saying:

"This solution is better because it uses less memory."

Say:

"This solution reduces memory usage, but it modifies the input. If preserving original data is required, using extra memory may be preferable."

---

- For HashMap/Dictionary solutions:

Mention:

"Average lookup is O(1), but we are trading additional memory for faster access."

---

- Optimization depends on constraints:
  - Small input → simpler solution may be acceptable.
  - Large input → better complexity matters more.
  - Memory-limited systems → reduce allocations.

---

## 📝 Revision Questions

1. What is the difference between Time Complexity and Space Complexity?

2. Why is creating one variable O(1) space?

3. Why is creating another array usually O(n) space?

4. What does "in-place algorithm" mean?

5. Why might an O(n) space solution be better than an O(1) space solution?

6. How does caching demonstrate a time vs space trade-off?

7. What is the difference between O(n) and O(k) space for a Dictionary?

---

## ⭐ Mentor Notes

Do not think of optimization as only reducing time or reducing memory.

Good engineers ask:

"What constraint am I optimizing for?"

Sometimes spending more memory gives a better system.

Sometimes saving memory is more important.

The goal is not to write the algorithm with the smallest Big-O values everywhere. The goal is to understand the trade-offs and choose the right approach for the situation.
