using System;

public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length < 2) { return true; }
        int furthestReach = 0;

        for (int i = 0; i < nums.Length - 1; i++){
            if (i > furthestReach) { return false; }
            furthestReach = Math.Max(furthestReach, i + nums[i]);
            if (furthestReach >= nums.Length - 1) { return true ;}
        }
        return false;
    }
}