class Solution {
public:
    int missingNumber(vector<int>& nums) {
        int numsSize = nums.size();
        int missingNum = nums.size();
        for(int i = 0; i < numsSize; i++){
            missingNum += (numsSize - i - 1);
            missingNum -= nums[i];
        }
        return missingNum;
    }
};