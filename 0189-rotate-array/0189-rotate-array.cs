public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        
        List<int> finalValues = new List<int>();
        
        for (int i = nums.Length - k; i < nums.Length; i++){
            finalValues.Add(nums[i]);
        }
        
        for (int i = nums.Length - k - 1; i >= 0; i--){
            nums[i + k] = nums[i];
        }
        
        for (int i = 0; i < finalValues.Count; i++){
            nums[i] = finalValues[i];
        }
    }
}