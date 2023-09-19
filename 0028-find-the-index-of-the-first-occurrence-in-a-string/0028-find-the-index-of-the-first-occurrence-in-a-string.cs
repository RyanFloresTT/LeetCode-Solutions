public class Solution {
    public int StrStr(string haystack, string needle) {
        int firstOccurence = 0;
        bool found;

        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            if (haystack[i] != needle[0]) {
                continue;
            } else {
                found = true;
                for (int j = 0; j < needle.Length; j++) {
                    if (haystack[i + j] != needle[j]) {
                        found = false;
                        break;
                    }
                }
                if (found) {
                    return i;
                }
            }
        }

        return -1;
    }
}