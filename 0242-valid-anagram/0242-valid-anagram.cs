public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {return false;}
        
        List<char> sWord = new();
        sWord.AddRange(s);
        
        for (int i = 0; i < t.Length; i++) {
            if (sWord.Contains(t[i])) {sWord.Remove(t[i]);}
            else {return false;}
        }
        
        return true;
    }
}