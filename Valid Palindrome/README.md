# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->

# Approach
<!-- Describe your approach to solving the problem. -->

# Complexity
- Time complexity:
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity:
<!-- Add your space complexity here, e.g. $$O(n)$$ -->

# Code
```
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
