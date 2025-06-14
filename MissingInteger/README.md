# MissingInteger

## Problem Description
Given an array `A` of integers, find the smallest positive integer (greater than 0) that does not occur in `A`.

## Algorithmic Approach
1. Convert the array to a list and sort it.
2. Initialize a counter starting from 1.
3. Iterate through the sorted list:
   - If an element is smaller than the counter, skip it.
   - If it matches the counter, increment the counter.
   - If it’s larger than the counter, return the counter.
4. After the loop, return the counter.

## Code Logic
- List is used for sorting.
- All elements smaller than the current expected number are ignored.
- First missing number is returned immediately when a gap is found.
- If no gaps, the next number after the last is returned.

## Reflection
This was my first attempt. The code solved the task correctly without issues.

## Time Complexity
- **Time:** O(N log N) (due to sorting)  

