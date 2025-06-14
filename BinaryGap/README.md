# Binary Gap

## Problem Description
A binary gap within a positive integer `N` is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of `N`.

**Example:**
- `N = 1041` → binary: `10000010001` → longest binary gap = `5`

## Goal
Write a function that returns the length of the longest binary gap of a given integer `N`.

## Algorithmic Approach
1. Convert the number to a binary string.
2. Iterate through each character:
   - Count consecutive `0`s between `1`s.
   - Reset the counter on each `1`.
3. Store all valid gaps.
4. Sort and return the largest.

## Code Logic
- `Convert.ToString(N, 2)` gives the binary representation.
- Loop tracks `currentChain` (number of zeros between `1`s).
- Every time a `1` is found, the current gap is stored.
- Sort the gaps in descending order and return the first (longest) one.

## Reflection
The code handles the task correctly and efficiently.
Improvements could include:
- Skipping the final `binaryList.Add(currentChain)` as it might capture a trailing sequence not bounded by a `1`.
- Avoiding sorting for performance – just track the max while iterating.

## Time Complexity
- **O(n)** where `n` is the number of bits in the binary representation of `N`.