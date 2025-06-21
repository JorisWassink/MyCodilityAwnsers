# MissingInteger

## Problem Description
Given an array `A` of integers, find the smallest positive integer (greater than 0) that does not occur in `A`.

## Algorithmic Approach
1. Initialize an array of N counters to zero.
2. Use two tracking variables:
    currentMax for the highest counter value at any point.
    lastUpdate for lazy max counter operations.
3. Iterate through the array A:

    If the operation is a counter increase (1 to N):

        If the counter is below lastUpdate, update it first.

        Increment the counter.

        Update currentMax if needed.

    If the operation is N + 1, set lastUpdate to currentMax (lazy max).

4. After the loop, update any counters still below lastUpdate.

## Code Logic
- Lazy updating avoids full array writes on every max operation.
- Only counters that are read or modified get individually updated.
- A final pass ensures all counters meet the latest max state.

## Reflection
This problem took some time to get right. I began with a brute-force solution that updated the entire array on every max counter operation. While it produced correct results, performance was poor due to repeated O(N) operations inside an O(M) loop.

I tried several variations:

    One version rebuilt the array using Enumerable.Repeat, which improved clarity but still had performance issues.

    Another kept track of the highest value but still applied full updates too frequently.

The final version introduced a lazy update approach, tracking the last known max value and only applying it when necessary. This avoided unnecessary operations, brought the time complexity down to O(N + M), and passed all efficiency tests. It was a helpful reminder that avoiding redundant work is often the key to optimizing performance.

## Time Complexity
- **Time:** O(N + M) 

