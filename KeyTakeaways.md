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

# Day 4 - Arrays

## 🎯 Key Takeaways

- An Array is a fundamental data structure that stores elements in contiguous memory locations.

- Arrays provide fast access using indexes because the memory address of any element can be calculated directly.

Example:

Address = Base Address + (Index × Element Size)

Because of this:

Array Read by Index:
Time Complexity: O(1)

---

- Searching an unsorted array requires checking elements one by one.

Example:

Find 7:

[3, 5, 2, 8, 7]

The array does not know where value 7 exists.

Worst case:
Check every element.

Time Complexity: O(n)

---

- Array insertion depends on the position.

Insert at end:

Usually:
O(1)

Insert at beginning/middle:

Elements need to shift.

Example:

Before:
[2,3,4,5]

Insert 1:

Shift:
[_,2,3,4,5]

After:
[1,2,3,4,5]

Time Complexity: O(n)

---

- Array deletion also requires shifting elements.

Example:

Before:
[1,2,3,4]

Remove 2:

Temporary:
[1,_,3,4]

Shift:
[1,3,4]

Time Complexity: O(n)

---

- Static arrays have a fixed size.

Example:

int[] nums = new int[10];

Size cannot automatically increase.

---

- Dynamic arrays solve this limitation.

Example:

List<int>

Internally:
- Uses an array.
- Tracks Count and Capacity.
- Creates a bigger array when capacity is full.
- Copies old elements into the new array.

---

- List<T>.Add()

Usually:
O(1)

When resize happens:
O(n)

Overall:
Amortized O(1)

---

- Array solutions commonly involve:

1. Traversal
2. Index manipulation
3. Maintaining state
4. Two pointers
5. In-place modification

---

## 💼 Connections to My Experience

- C# arrays provide fast index-based access because they use contiguous memory.

- List<T> is not a completely different structure; it is a dynamic array built on top of an internal array.

- Choosing between Array and List<T> depends on requirements:

Array:
- Fixed size
- Lower overhead
- Good when size is known

List<T>:
- Flexible size
- Easier insertion/removal at end
- Handles resizing automatically

---

- Similar ideas exist in system design:

Pre-allocated resources:
- Faster access
- Less flexibility

Dynamic allocation:
- More flexible
- Additional management cost

---

- Understanding memory layout helps explain performance differences in real applications.

---

## ⚠️ Common Mistakes

- Thinking array access is O(1) because "the computer is fast".

Correct reason:

The address is mathematically calculated using the index.

---

- Thinking insertion is always O(1).

Insertion depends on location.

End:
Usually O(1)

Beginning:
O(n)

---

- Forgetting that arrays cannot actually shrink.

Removing an element usually means:
- shifting values
- ignoring unused space
- or creating a new array

---

- Assuming lower memory usage is always better.

Example:

Running Sum

Extra Array:

Time: O(n)
Space: O(n)

Benefits:
Preserves original data.

In-place:

Time: O(n)
Space: O(1)

Benefits:
Uses less memory.

Both can be correct depending on requirements.

---

## 🧠 Interview Nuggets

- Always explain why an operation has its complexity.

Weak answer:

"Array access is O(1)."

Strong answer:

"Array access is O(1) because arrays store elements continuously in memory, so the address can be calculated directly from the index."

---

- For array traversal:

One pass usually means:

Time: O(n)

---

- Multiple sequential passes:

Example:

for loop

+

another for loop


O(n + n)

=

O(2n)

=

O(n)

---

- For additional arrays:

Input size n:

Create result[n]

Space:

O(n)

---

- For fixed variables:

int left;
int right;
int count;

Space:

O(1)

---

- Two Pointer Pattern:

Use multiple indexes to process arrays efficiently.

Examples:

left/right pointers:

Used for:
- reversing arrays
- removing elements
- searching pairs

---

## 📝 Revision Questions

1. Why is array index access O(1)?

2. Why does searching an unsorted array take O(n)?

3. Why is inserting at the beginning expensive?

4. What happens internally when List<T> capacity is full?

5. Difference between Count and Capacity?

6. Why is List<T>.Add() called amortized O(1)?

7. When would you prefer using extra memory instead of modifying an array in-place?

8. Why does nums[nums[i]] still take O(1) time?

9. What problem does the two pointer pattern solve?

---

## ⭐ Mentor Notes

Arrays look simple, but they introduce the most important ideas in problem solving:

- accessing data efficiently
- moving through data
- managing memory
- modifying data safely

Many advanced structures are built on top of these same ideas.

Mastering arrays is not about memorizing operations.

It is about understanding the trade-offs:

Fast access vs expensive modification.

Fixed memory vs dynamic growth.

Saving memory vs preserving data.

The same trade-offs appear later in:
- Linked Lists
- HashMaps
- Trees
- Databases
- Distributed Systems

# Day 6 - Two Pointers Recognition

## 🎯 Core Idea

Use two indexes to process data efficiently by eliminating unnecessary work.

Goal:

Brute Force: O(n²) → Optimized: O(n)

Every pointer movement should have a reason.

---

## 🔍 When To Use Two Pointers

### 1. Sorted Array + Pair Search

Signals:
- Find pair
- Target sum
- Closest sum

Pattern:

left → ← right

Example:
- Two Sum II

Logic:

sum too small → left++

sum too large → right--

---

### 2. Compare From Both Ends

Signals:
- Reverse
- Palindrome
- Symmetric comparison

Pattern:

left → ← right

Examples:
- Reverse String
- Valid Palindrome

---

### 3. Modify Array In-place

Signals:
- Remove elements
- Move elements
- Remove duplicates

Pattern:

fast = explorer/scanner

slow = builder/result position

Examples:
- Move Zeroes
- Remove Duplicates

---

## ⏱️ Complexity

Usually:

Time: O(n)

Reason:
Each element is processed at most once.

Space: O(1)

Reason:
Only pointer variables are used.

---

## 🧠 Important Mindsets

### Opposite Direction

left starts beginning

right starts end

Used when processing both sides.

---

### Same Direction

fast:
Finds useful values

slow:
Builds result area


Do not memorize slow meaning.

Examples:

Move Zeroes:
slow = next non-zero position

Remove Duplicates:
slow = last unique position

---

## ⚠️ Common Mistakes

❌ Two pointers does not mean O(n²)

Two moving indexes:
O(n)

Nested loops:
O(n²)


---

❌ Do not force Two Pointers everywhere.

Frequency/counting problems:

Usually HashMap.

---

❌ Do not move pointers randomly.

Pointer movement should eliminate possibilities.

---

## ✅ Problems Completed

344. Reverse String

Pattern:
Opposite pointers


125. Valid Palindrome

Pattern:
Opposite pointers + skipping


167. Two Sum II

Pattern:
Sorted + pair search


283. Move Zeroes

Pattern:
Same direction pointers


26. Remove Duplicates

Pattern:
Same direction + sorted array


---

## ⭐ Key Line To Remember

Two Pointers is not about having two variables.

It is about using two positions to reduce unnecessary work.
