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
