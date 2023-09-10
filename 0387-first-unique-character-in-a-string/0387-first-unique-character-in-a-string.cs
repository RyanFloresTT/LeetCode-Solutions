public class Solution {
    List<char> uniques = new();
    List<char> duplicates = new();
    
    public int FirstUniqChar(string s) {
        
        for (int i = 0; i < s.Length; i++) {
            if (!duplicates.Contains(s[i])) {
                duplicates.Add(s[i]);
                uniques.Add(s[i]);
            }
            else {
                uniques.Remove(s[i]);
            }
        }
        
        if (uniques.Count < 1) {return -1;}
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == uniques[0]) {return i;}
        }
        
        return -1;
    }
}