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
To determine if a given string is a palindrome, we need to ignore cases and remove any non-alphanumeric characters. After cleaning the string, we can compare it to its reverse to check if it reads the same forwards and backwards.

## Approach
1. **Convert to Lowercase and Clean the String:** First, we convert the input string to lowercase to make the comparison case-insensitive. We then use a regular expression to remove all non-alphanumeric characters from the string.
2. **Two-Pointer Technique:** We use two pointers, one starting at the beginning (`left`) and one at the end (`right`) of the cleaned string. We compare the characters at these pointers. If they are the same, we move the pointers towards the center and continue comparing. If at any point the characters do not match, we return `false`.
3. **Return Result:** If the pointers cross each other without finding any mismatches, the string is a palindrome, so we return `true`.

## Complexity
- Time complexity:
The time complexity is $O(n)$, where $n$ is the length of the input string. This is because we iterate through the string once to clean it and once more to check for palindromes.

- Space complexity:
The space complexity is $O(n)$, where $n$ is the length of the input string. This space is used for the cleaned string which contains only alphanumeric characters.

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
