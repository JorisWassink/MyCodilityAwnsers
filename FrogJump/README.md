# Frog Jump

## Problem Description
A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
Count the minimal number of jumps that the small frog must perform to reach its target.

**Example:**
X = 10
Y = 85
D = 30

the function should return 3, because the frog will be positioned as follows:
	after the first jump, at position 10 + 30 = 40
	after the second jump, at position 10 + 30 + 30 = 70
	after the third jump, at position 10 + 30 + 30 + 30 = 100


## Goal
Write a function that that, given three integers X, Y and D, returns the minimal number of jumps from position X to a position equal to or greater than Y.

## Algorithmic Approach
1. Calculate the diffrence between X and Y
2. Devide this by D


## Reflection
For this assignment, I had the right approach from the beginning. The main issue I ran into was related to variable types. I initially used floats for all numeric values and performed a lot of casting between types, especially when dividing integers. This led to performance issues and some unexpected behavior. Once I changed everything to use doubles consistently, the performance improved noticeably. This taught me an important lesson: using consistent and appropriate data types not only helps with accuracy, but also avoids unnecessary overhead from constant type conversions.

