# Frog Jump One

## Problem Description
A small frog wants to get to the other side of a river. The frog is initially located on one bank of the river (position 0) and wants to get to the opposite bank (position X+1). Leaves fall from a tree onto the surface of the river.
**Example:**
You are given integer X = 5 and array A such that:
  A[0] = 1
  A[1] = 3
  A[2] = 1
  A[3] = 4
  A[4] = 2
  A[5] = 3
  A[6] = 5
  A[7] = 4

In second 6, a leaf falls into position 5. This is the earliest time when leaves appear in every position across the river.

## Goal
The goal is to find the earliest time when the frog can jump to the other side of the river. The frog can cross only when leaves appear at every position across the river from 1 to X (that is, we want to find the earliest moment when all the positions from 1 to X are covered by leaves). You may assume that the speed of the current in the river is negligibly small, i.e. the leaves do not change their positions once they fall in the river.

## Algorithmic Approach
1. Create a Boolean array to track which positions have leaves.
2. Track how many unique positions have been covered.
3. Iterate through array `A`:
   - If a leaf falls at a position that hasn’t been covered yet:
     - Mark it as covered.
     - Decrease the counter.
   - If all positions from 1 to X are covered, return the current index (time).
4. If not all positions are covered by the end of the array, return -1.

## Reflection
I solved this task on my first attempt with a correct and efficient solution. It reinforced the importance of using space-efficient data structures and simple logic to track progress without nested loops.

## Time Complexity
- **O(N)** 