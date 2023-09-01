public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numHash = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(!numHash.Contains(nums[i])){
                numHash.Add(nums[i]);
            } else {
                return true;
            }
        }
        return false;
    }
}