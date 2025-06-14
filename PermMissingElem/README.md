# Perm Missing Element

## Problem Description
An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.


**Example:**
given array A such that:
  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5

the function should return 4, as it is the missing element.

## Goal
Write a function that, given an array A, returns the value of the missing element.

## Algorithmic Approach
1. Convert the Array to an ArrayList.
2. Use the built in Sorting method to sort the list.
3. Iterate through the List, as soon as the value no longer matches the index, there is a missing Element


## Reflection
The code handles the task correctly and efficiently, I once again solved this problem first try.