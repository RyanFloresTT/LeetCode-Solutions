class Solution {
public:
    int lengthOfLastWord(string s) {
        bool wordFound = false;
        int wordLen = 0;

        for(int i = s.size() - 1; i >= 0; i--){
            if (s[i] == ' '){
                if (wordFound) break;
                continue;
            } else {
                wordFound = true;
            }
            wordLen++;
        }
        return wordLen;
    }
};