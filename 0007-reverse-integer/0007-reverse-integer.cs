public class Solution {
    public int Reverse(int x) {
        if (x == Int32.MinValue) {
            return 0;
        }

        bool sign = x > 0 ? true : false;
        int result = 0;
        x = Math.Abs(x);
        
        string reversed = new string(x.ToString().ToCharArray().Reverse().ToArray());
        
        try {
            result = Int32.Parse(reversed);
        } catch {
            Console.WriteLine("String is not a valid integer");   
        }
        return sign ? result : result * -1;
    }
}
