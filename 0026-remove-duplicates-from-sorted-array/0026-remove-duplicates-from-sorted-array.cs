public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int numLen = nums.Length;
        if (numLen <= 1) {return numLen;}
        int lastIndex = 1;
        for(int i = 1; i < numLen; i++) {
            if(nums[i] != nums[i - 1]) {
                nums[lastIndex] = nums[i];
                lastIndex++;
            }
        }
        return lastIndex;
    }
}