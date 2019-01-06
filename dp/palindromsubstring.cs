public static class Extensions
{
    /// <summary>
    /// Get the string slice between the two indexes.
    /// Inclusive for start index, exclusive for end index.
    /// </summary>
    public static string Slice(this string source, int start, int end)
    {
        if (end < 0) // Keep this for negative end support
        {
            end = source.Length + end;
        }
        int len = end - start;               // Calculate length
        return source.Substring(start, len); // Return Substring of length
    }
}

public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1)
            return s;
        var result = String.Empty;
        Dictionary<string, bool> memo = new Dictionary<string, bool>();
        for(int i=0;i<s.Length-1;i++){
            for(int j=i; j< s.Length;j++){
                if(len <= result.Length) continue; 
                if(len > result.Length && IsPalindrome(i,j, s, memo)){
                    result = s.Slice(i,j);
                }
            }
        }
        
        return result;
    }
    
    public bool IsPalindrome(int start, int end,string s, Dictionary<string, bool> memo){
        if(i >= j){
            if(memo.ContainsKey(i+"$"+j))
                return memo[i+"$"+j];
            bool doEndsMatch = s[i] == s[j];
            i = i+1;
            j=j-1;
            var key = i+"$"+j;
            bool subPalindrome = memo.ContainsKey(key) ? 
                memo[key] : IsPalindrome(i,j,s, memo);
            bool result = doEndsMatch && subPalindrome;
            memo.Add(key,result);
            return result;
        }
        else
        {
            var key = i+"$"+j;
            memo.Add(key,true);
            return true;
        }
    }
}
