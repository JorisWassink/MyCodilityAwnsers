# Odd Occurrences In Array

## Problem Description
A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
**Example:**
- In array A such that:
  A[0] = 9  A[1] = 3  A[2] = 9
  A[3] = 3  A[4] = 9  A[5] = 7
  A[6] = 9

        the elements at indexes 0 and 2 have value 9,
        the elements at indexes 1 and 3 have value 3,
        the elements at indexes 4 and 6 have value 9,
        the element at index 5 has value 7 and is unpaired.



## Goal
Write a function that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.

## Algorithmic Approach
1. Iterate through array A
	- if the number has not occured yet, add it to a dictionary
	- if the number is already in that dictionary, add one occurance
2. Iterate through the dictionary
	- if the number of occurances for a certain number is odd, return that number


## Reflection
I approached the problem by attempting to find the element in the array that occurs an odd number of times. My first solution used nested loops to count occurrences and tracked ignored numbers to avoid redundant counting. While functionally correct, it was inefficient due to its O(n²) time complexity and unnecessary repeated iterations.

My second solution improved significantly by using two lists: one for possible candidates and another for values to ignore. This brought the complexity closer to O(n), and the logic became clearer. Each number was either added to or removed from the list of possibilities depending on whether it had already been seen, simulating XOR-like behavior using data structures.

After 5 tries, I reached a working and reasonably efficient version, but it still uses more memory than needed. The optimal solution would use bitwise XOR for O(n) time and O(1) space, which I learned after completing my implementation.

These iterations demonstrate my ability to debug, reflect, and improve solutions incrementally.
