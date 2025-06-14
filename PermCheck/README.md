# PermCheck

## Problem Description
A non-empty array A consisting of N integers is given.
A permutation is a sequence containing each element from 1 to N once, and only once.

**Example:**
Array A such that:
    A[0] = 4
    A[1] = 1
    A[2] = 3
    A[3] = 2

is a permutation, but array A such that:
    A[0] = 4
    A[1] = 1
    A[2] = 3

is not a permutation, because value 2 is missing.


## Goal
Write a function that, given an array A, returns 1 if array A is a permutation and 0 if it is not.

## Algorithmic Approach
1. Create a boolean array to track seen values.
2. Iterate through the input:
   - If a value is outside the expected range or already seen, return 0.
   - Otherwise, mark it as seen and increment a counter.
3. If all values from 1 to N are seen exactly once, return 1.

## Code Logic
- A boolean array of size `N + 1` is used (with index 0 unused).
- Try/catch is used to handle out-of-bounds values (though not ideal for performance).
- If any duplicate or invalid value is found, return 0.
- After the loop, if `completed == list.Length`, it’s a valid permutation.

## Reflection
This was my first attempt. The code works as intended and solves the problem correctly.

## Time Complexity
- **Time:** O(N)