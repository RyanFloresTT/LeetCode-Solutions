public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return "";
        }

        string shortest = strs[0];
        foreach (string str in strs) {
            if (str.Length < shortest.Length) {
                shortest = str;
            }
        }

        for (int i = 0; i < shortest.Length; i++) {
            char currentChar = shortest[i];
            foreach (string str in strs) {
                if (str[i] != currentChar) {
                    return shortest.Substring(0, i);
                }
            }
        }

        return shortest;
    }
}
