# Remove Element

## Description
Given an integer array `nums` and an integer `val`, remove all occurrences of val in nums ![in-place](https://en.wikipedia.org/wiki/In-place_algorithm). The order of the elements may be changed. Then return the _number of elements in_ `nums` _which are not equal to_ `val`.

Consider the number of elements in `nums` which are not equal to `val` be `k`, to get accepted, you need to do the following things:
- Change the array `nums` such that the first `k` elements of nums contain the elements which are not equal to `val`. The remaining elements of `nums` are not important as well as the size of `nums`.
- Return `k`.

#### Custom Judge
The judge will test your solution with the following code:
> int[] nums = [...]; // Input array
>
> int val = ...; // Value to remove
>
> int[] expectedNums = [...]; // The expected answer with correct length.
                              // It is sorted with no values equaling val.
>
> int k = removeElement(nums, val); // Calls your implementation
>
> assert k == expectedNums.length;
>
> sort(nums, 0, k); // Sort the first k elements of nums
>
> for (int i = 0; i < actualLength; i++) {
>
>   assert nums[i] == expectedNums[i];
>
> }

If all assertions pass, then your solution will be **accepted**.

#### Example 1:
> **Input:** nums = [3,2,2,3], val = 3
>
> **Output:** 2, nums = [2,2,_,_]
>
> **Explanation:** Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores).

#### Example 2:
> **Input:** nums = [0,1,2,2,3,0,4,2], val = 2
>
> **Output:** 5, nums = [0,1,4,0,3,_,_,_]
>
> **Explanation:** Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
> Note that the five elements can be returned in any order.
> It does not matter what you leave beyond the returned k (hence they are underscores).


#### Constraints:
- `0 <= nums.length <= 100`
- `0 <= nums[i] <= 50`
- `0 <= val <= 1009`

## Testcase
#### Case 1
<sub>Input</sub>
```
nums = [3,2,2,3]
```
```
val = 3
```

<sub>Output</sub>
```
[2,2]
```

<sub>Expected</sub>
```
[2,2]
```

#### Case 2
<sub>Input</sub>
```
nums = [0,1,2,2,3,0,4,2]
```
```
val = 2
```

<sub>Output</sub>
```
[0,1,3,0,4]
```

<sub>Expected</sub>
```
[0,1,3,0,4]
```

## Intuition
My first thought on solving this problem is to iterate through the array and filter out elements that are not equal to the specified value `val`. This can be done in a single pass, maintaining a counter to keep track of the position to place the next non-`val` element. This ensures we modify the array in-place without using extra space for another array.

## Approach
1. Initialize a counter `k` to 0. This counter will keep track of the number of elements that are not equal to `val` and will also serve as the index to place the next valid element.
2. Iterate through each element in the array using a for loop.
3. For each element, check if it is not equal to `val`.
4. If the element is not equal to `val`, place it at the index k and increment `k`.
5. After completing the iteration, `k` will contain the count of elements not equal to `val`, and the first `k` elements in the array will be the elements that are not equal to `val`.

## Complexity
- Time complexity:
The time complexity is $O(n)$ where $n$ is the length of the array, as we are iterating through the array only once.

- Space complexity:
The space complexity is $O(1)$ because we are modifying the array in-place and not using any extra space that scales with the input size.

## Code
```
public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int k = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[k++] = nums[i];
            }
        }

        return k;
    }
}
```
