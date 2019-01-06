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
        int len = end - start+1;               // Calculate length
        return source.Substring(start, len); // Return Substring of length
    }
}

public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1)
            return s;
        if(s.Length == 2 && s[0] != s[1]){
            return s.Substring(0,1);
        }
        var result = String.Empty;
        Dictionary<string, bool> memo = new Dictionary<string, bool>();
        for(int i=0;i<s.Length-1;i++){
            for(int j=i; j< s.Length;j++){
                if(IsPalindrome(i,j, s, memo)){
                    string c = s.Slice(i,j);
                    if(result.Length < c.Length)
                        result = c;
                }
            }
        }
        
        return result;
    }
    
    public bool IsPalindrome(int i, int j,string s, Dictionary<string, bool> memo){
        if(i < j ){
            var lKey = i+"$"+j;
            if(memo.ContainsKey(lKey))
                return memo[lKey]; 
            bool doEndsMatch = s[i] == s[j];
            var a= i+1;
            var b= j-1;
            var key = a+"$"+b;
            bool subPalindrome = memo.ContainsKey(key) ? 
                memo[key] : IsPalindrome(a,b,s, memo);
            bool result = doEndsMatch && subPalindrome;
            memo.Add(lKey,result);
            return result;
        }
        else if(i > 0 && j > 0 )
        {
            var key = i+"$"+j;
            if(memo.ContainsKey(key))
                return memo[key]; 
            memo.Add(key,true);
            return true;
        }
        
        return false;
    }
}
