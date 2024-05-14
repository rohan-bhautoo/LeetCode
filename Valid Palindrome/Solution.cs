public class Solution 
{
    public bool IsPalindrome(string s) 
    {
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
