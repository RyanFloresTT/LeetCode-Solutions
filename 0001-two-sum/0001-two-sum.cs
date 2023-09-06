public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hash = new();
        int[] result = new int[2];
        int lookFor;
        
        for (int i = 0; i < nums.Length; i++){
            lookFor = target - nums[i];
            
            if (IsValidAnswer(lookFor, i)){
                result[0] = hash[lookFor];
                result[1] = i;
                return result;
            }
            else if(!hash.ContainsKey(nums[i])){
                hash.Add(nums[i], i);
            }
            
        }
        return Array.Empty<int>();

        bool IsValidAnswer(int val, int index) => hash.ContainsKey(lookFor) && hash[lookFor] != index;
    }
}