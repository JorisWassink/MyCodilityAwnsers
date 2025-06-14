# TapeEquilibrium

## Problem Description
A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.

Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].

The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|

In other words, it is the absolute difference between the sum of the first part and the sum of the second part.

**Example:**
Consider array A such that:
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3

We can split this tape in four places:

	P = 1, difference = |3 − 10| = 7
	P = 2, difference = |4 − 9| = 5
	P = 3, difference = |6 − 7| = 1
	P = 4, difference = |10 − 3| = 7 
	

## Goal
Write a function that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.

## Algorithmic Approach
1. Split the array into two parts at every position P (1 ≤ P < A.Length).
2. Initialize:
   - p1 = A[0] (sum of the first part)
   - p2 = total sum of A minus A[0] (sum of the second part)
   - lowest = maximum possible integer value (to track the minimal difference)
3. Iterate from P = 1 to A.Length - 1:
   - Update the minimal difference between p1 and p2.
   - Add the next element to p1 and subtract it from p2 to simulate the next split.
4. Return the lowest difference found.

## Code Logic
- Start with the first element as the left-side sum (p1).
- Calculate the right-side sum (p2) by subtracting p1 from the total array sum.
- For each valid split point:
   - Calculate the absolute difference between the two sides.
   - Keep track of the smallest difference found.
   - Move the current element from right to left (add to p1, subtract from p2).
- After looping through all split points, return the smallest difference.

## Reflection
This problem I struggled with for quite a bit, I started with a brute-force approach that calculated both sides of the split in every iteration using nested loops. This worked correctly but had poor performance due to its O(N²) time complexity.

I then experimented with alternative methods:
- The second version combined both sums into a single loop, slightly cleaner but still inefficient.
- The third version used ArraySegment and LINQ's Sum to calculate each part. This improved readability but added hidden overhead due to allocations and method calls.

Eventually, I arrived at an optimized solution that calculates the total sum once and uses a single pass to adjust both partitions incrementally. This reduced the time complexity to O(N) and used only constant space. It was a valuable lesson in balancing readability, correctness, and performance.

## Time Complexity
- **O(n)**
- A single pass through the array after an initial sum (which is also O(N)).