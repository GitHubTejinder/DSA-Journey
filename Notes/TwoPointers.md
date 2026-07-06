# Two Pointers Pattern

## 🎯 What is Two Pointers?

Two Pointers is a technique where we use two indexes/pointers to process a collection efficiently.

Instead of checking every possible combination, we move pointers intelligently based on conditions.

The goal is usually:
- Reduce unnecessary iterations
- Avoid nested loops
- Improve brute force solutions

Example:

Brute Force:
O(n²)

Two Pointers:
O(n)

---

## 🔍 How To Recognize Two Pointer Problems

Do not memorize problems.

Look for signals.

---

## Signal 1 - Sorted Array + Pair Search

Common keywords:

- Find pair
- Two numbers
- Target sum
- Closest sum

Example:

Input:

[2,7,11,15]

Target = 9

Because the array is sorted:

If sum is too small:
move left pointer

If sum is too large:
move right pointer

Examples:

- Two Sum II
- 3Sum

---

## Signal 2 - Compare From Both Ends

Common keywords:

- Palindrome
- Reverse
- Symmetric comparison

Pattern:

left →        ← right

Examples:

- Reverse String
- Valid Palindrome

---

## Signal 3 - Modify Array In-Place

Common keywords:

- Remove elements
- Move elements
- Remove duplicates

Usually use:

Fast pointer:
- Scans the array

Slow pointer:
- Tracks where the next valid element should go

Pattern:

slow →
fast →

Examples:

- Remove Element
- Move Zeroes
- Remove Duplicates From Sorted Array

---

## Signal 4 - Avoid Checking Every Pair

If the first idea is:

for loop
    inside another for loop

Ask:

Can two pointers remove unnecessary checks?

Example:

Brute Force:

O(n²)

Optimized:

O(n)

---

# Types of Two Pointers

## 1. Opposite Direction

Pointers start from both ends.

Pattern:

left →              ← right

Used for:

- Reversing
- Palindrome checking
- Sorted pair search

Pseudo code:

int left = 0;
int right = nums.Length - 1;

while(left < right)
{
    if(condition)
        left++;
    else
        right--;
}

---

## 2. Same Direction

Both pointers move forward.

Pattern:

slow →
fast →

Usually:

Fast:
Finds/explores elements

Slow:
Stores the position for valid elements

Pseudo code:

int slow = 0;

for(int fast = 0; fast < nums.Length; fast++)
{
    if(condition)
    {
        nums[slow] = nums[fast];
        slow++;
    }
}

---

# ⏱️ Complexity

## Time Complexity

Usually:

O(n)

Reason:

Even though there are two pointers, each element is processed at most once.

Example:

left moves 5 times

right moves 5 times

Total movement:

10

Not:

5 × 5

---

## Space Complexity

Usually:

O(1)

Because only fixed variables are created:

- left
- right
- slow
- fast

Memory does not increase with input size.

---

# Problems Completed

## 344. Reverse String

Signal:

Need to swap first element with last element.

Pattern:

Opposite direction pointers

Approach:

- Swap left and right characters
- Move inward

Complexity:

Time: O(n)

Space: O(1)

---

## 125. Valid Palindrome

Signal:

Need to compare first and last valid characters.

Pattern:

Opposite direction pointers

Approach:

- Start from both ends
- Skip invalid characters
- Compare valid characters
- Move inward

Complexity:

Time: O(n)

Space: O(1)

---

## 167. Two Sum II

Signal:

- Sorted array
- Need pair
- Target value

Pattern:

Opposite direction pointers

Approach:

sum = numbers[left] + numbers[right]

If sum too small:
left++

If sum too large:
right--

Complexity:

Time: O(n)

Space: O(1)

---

# ⚠️ Common Mistakes

## Mistake 1

Thinking two pointers means O(n²)

Wrong.

Two pointers:

Each pointer moves through the data once.

O(n)


Nested loops:

For every element, scan again.

O(n²)

---

## Mistake 2

Creating extra memory unnecessarily.

Example:

Palindrome:

Creating another cleaned string:

Space:
O(n)

Better:

Skip characters while moving pointers.

Space:
O(1)

---

## Mistake 3

Moving pointers without a reason.

Every movement should eliminate some possibilities.

Example:

Two Sum II:

Sum too high:
Move right because we need smaller value.

Sum too low:
Move left because we need larger value.

---

# 🧠 Interview Checklist

Before solving, ask:

1. Am I comparing values from two positions?

2. Is the input sorted?

3. Do I need to find a pair?

4. Am I removing/moving elements in-place?

5. Am I trying every combination using nested loops?

If yes:

Consider Two Pointers.

---

# ⭐ Main Idea

Two Pointers is not about creating two variables.

It is about using information from two positions to eliminate unnecessary work.

Every pointer movement should have a reason.
