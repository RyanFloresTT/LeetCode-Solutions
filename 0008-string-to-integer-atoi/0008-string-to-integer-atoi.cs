public class Solution {
    public int MyAtoi(string s) {
        int index = 0;
        int sign = 1;
        long result = 0;

        while (index < s.Length && char.IsWhiteSpace(s[index])) {
            index++;
        }

        if (index < s.Length && (s[index] == '-' || s[index] == '+')) {
            sign = s[index] == '-' ? -1 : 1;
            index++;
        }

        while (index < s.Length && char.IsDigit(s[index])) {
            int digit = s[index] - '0';

            if (result > (long.MaxValue - digit) / 10) {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            index++;
        }

        result *= sign;
        if (result < int.MinValue) {
            return int.MinValue;
        } else if (result > int.MaxValue) {
            return int.MaxValue;
        }

        return (int)result;
    }
}
