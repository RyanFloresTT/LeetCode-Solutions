public class Solution {
    public bool IsPalindrome(string s) {
    HashSet<char> alphaNumericValues = new() {
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        
        s = s.ToLower();
        List<char> sWord = new();
        
        for (int i = 0; i < s.Length; i++) {
            if (IsAlphanumeric(s[i])) {sWord.Add(s[i]);}
        }
        
        for (int i = 0; i < sWord.Count / 2; i++) {
            if (sWord[i] != sWord[sWord.Count - 1 - i]) {return false;}
        }
        
        return true;
                    
        bool IsAlphanumeric(char x) => alphaNumericValues.Contains(x);
    }
}