# Two Sum

## Description
Given an array of integers `nums` and an integer `target`, _return indices of the two numbers such that they add up to `target`_.

You may assume that each input would have **_exactly_** **one solution**, and you may not use the _same_ element twice.

You can return the answer in any order.

#### Example 1:
> **Input:** nums = [2,7,11,15], target = 9
>
> **Output:** [0,1]
>
> **Explanation:** Because nums[0] + nums[1] == 9, we return [0, 1].

#### Example 2:
> **Input:** nums = [3,2,4], target = 6
>
> **Output:** [1,2]

#### Example 3:
> **Input:** nums = [3,3], target = 6
>
> **Output:** [0,1]

#### Constraints:
- `2 <= nums.length <= 10^4`
- `-10^9 <= nums[i] <= 10^9`
- `-10^9 <= target <= 10^9`
- **Only one valid answer exists.**

## Testcase
#### Case 1
<sub>Input</sub>
```
nums = [2,7,11,15]
```
```
targt = 9
```

<sub>Output</sub>
```
[0,1]
```

<sub>Expected</sub>
```
[0,1]
```

#### Case 2
<sub>Input</sub>
```
nums = [3,2,4]
```
```
targt = 6
```

<sub>Output</sub>
```
[1,2]
```

<sub>Expected</sub>
```
[1,2]
```

#### Case 3
<sub>Input</sub>
```
nums = [3,3]
```
```
targt = 6
```

<sub>Output</sub>
```
[0,1]
```

<sub>Expected</sub>
```
[0,1]
```

# Intuition
The first thought is to find a way to determine if there are two numbers in the array that add up to the given target. A naive approach might involve checking every possible pair of numbers, but this would be inefficient. Instead, we can leverage a hash table (dictionary) to store each number's complement (target - current number) as we iterate through the array, allowing us to check if the complement has already been encountered.

# Approach
1. Initialize an empty dictionary to store the numbers we have seen so far and their indices.
2. Iterate through the array:
    - For each number, calculate its complement (target - current number).
    - Check if this complement is already in the dictionary.
        - If it is, return the indices of the complement and the current number.
        - IF it isn't, add the current number and its index to the dictionary. 
3. The solution guarantees that there is exactly one solution, so we will always find a result within the loop.

# Complexity
- Time complexity:
The time complexity is $O(n)$ because we iterate through the array once, performing constant-time dictionary operations (insertions and lookups).

- Space complexity:
The space complexity is $O(n)$ because, in the worst case, we might store all $n$ elements in the dictionary.

# Code
```c#
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        
    }
}
```
