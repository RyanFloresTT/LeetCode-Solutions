public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums.Length < 2) {return;}
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == 0){
                for (int j = i + 1; j < nums.Length; j++){
                    if (nums[j] != 0){
                        int tmp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tmp;
                        break;
                    }
                }
            }
        }
    }
}