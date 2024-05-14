# Valid Palindrome

## Description
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string `s`, return `true` ***if it is a palindrome, or `false` otherwise***.

#### Example 1:
> **Input:** s = "A man, a plan, a canal: Panama"
>
> **Output:** true
>
> **Explanation:** "amanaplanacanalpanama" is a palindrome.

#### Example 2:
> **Input:** s = "race a car"
>
> **Output:** false
>
> **Explanation:** "raceacar" is not a palindrome.

#### Example 3:
> **Input:** s = " "
>
> **Output:** true
>
> **Explanation:** s is an empty string "" after removing non-alphanumeric characters.
> Since an empty string reads the same forward and backward, it is a palindrome.

#### Constraints:
- `1 <= s.length <= 2 * 10^5`
- `s` consists only of printable ASCII characters.

## Testcase
#### Case 1
<sub>Input</sub>
```
s = "A man, a plan, a canal: Panama"
```

<sub>Output</sub>
```
true
```

<sub>Expected</sub>
```
true
```

#### Case 2
<sub>Input</sub>
```
s = "race a car"
```

<sub>Output</sub>
```
false
```

<sub>Expected</sub>
```
false
```

#### Case 3
<sub>Input</sub>
```
s = " "
```

<sub>Output</sub>
```
true
```

<sub>Expected</sub>
```
true
```

## Intuition
<!-- Describe your first thoughts on how to solve this problem. -->

## Approach
<!-- Describe your approach to solving the problem. -->

## Complexity
- Time complexity:
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity:
<!-- Add your space complexity here, e.g. $$O(n)$$ -->

## Code
```c#
using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        string cleanedString = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

        int left = 0;
        int right = cleanedString.Length - 1;

        while(left < right)
        {
            if(cleanedString[left] != cleanedString[right])
                return false;
            
            left++;
            right--;
        }

        return true;
    }
}
```
