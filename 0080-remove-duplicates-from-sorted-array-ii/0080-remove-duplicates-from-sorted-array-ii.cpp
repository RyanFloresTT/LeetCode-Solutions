class Solution {
public:
    int removeDuplicates(std::vector<int>& nums) {
        int shifts = 0;
        for (int i = nums.size() - 3; i >= 0; i--) {
            if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2]) {
                nums.erase(nums.begin() + i + 2);
                shifts++;
            }
        }
        return nums.size();
    }
};
