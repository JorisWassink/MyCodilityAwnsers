# Cyclic Rotation

## Problem Description
An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place.
**Example:**
- The rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).

## Goal
Write a function that rotates array A K times.

## Algorithmic Approach
1. Repeat the following K times:
   - Create a new array B with the same length as A.
   - For each element in A (from end to start):
     - If the previous index is out of bounds (< 0), wrap to the last element.
     - Otherwise, shift the element one position to the right.
2. After each rotation, overwrite A with the new rotated array B.
3. After completing all K rotations, return the final array A.

## Code Logic
- A for-loop runs K times to perform the rotation step by step.
- In each rotation:
  - A new array B is created to store the rotated result.
  - A nested loop runs from the end of the array to the start:
    - For each index j, the element at position j in B is set to the value from A at (j - 1).
    - If (j - 1) is less than 0, the last element of A is used (wrap-around).
- After each full rotation, A is updated to the contents of B.
- After K rotations, the final rotated array A is returned.

## Reflection
The code handles the task correctly and efficiently. I did this puzzle on my first attempt.

## Time Complexity
- **O(K * N)** where N is the array size — due to nested loops.