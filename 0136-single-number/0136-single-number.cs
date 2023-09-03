public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> singleNumSet = new HashSet<int>();
        
        if (nums.Length < 2) {return nums[0];}
        
        for (int i = 0; i  < nums.Length; i++){
            if (singleNumSet.Contains(nums[i])){
                singleNumSet.Remove(nums[i]);
            } else {
                singleNumSet.Add(nums[i]);
            }
        }
        return singleNumSet.ToArray()[0];
    }
}