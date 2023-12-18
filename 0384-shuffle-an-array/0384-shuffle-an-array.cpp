#include <vector>
#include <cstdlib>

class Solution {
private:
    std::vector<int> defaultNums;
    std::vector<int> nums;

public:
    Solution(std::vector<int>& nums) {
        this->nums = nums;
        defaultNums = nums;
    }
    
    std::vector<int> reset() {
        nums = defaultNums;
        return nums;
    }
    
    std::vector<int> shuffle() {
        int numsSize = nums.size();
        for (int i = numsSize - 1; i > 0; --i) {
            int randIndex = rand() % (i + 1);
            std::swap(nums[i], nums[randIndex]);
        }
        return nums;
    }
};


/*
 * Your Solution object will be instantiated and called as such:
 * Solution* obj = new Solution(nums);
 * vector<int> param_1 = obj->reset();
 * vector<int> param_2 = obj->shuffle();
 */