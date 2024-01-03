class Solution {
public:
    void rotate(vector<int>& nums, int k) {
        if (k % nums.size() == 0) {return;}
        if (k > nums.size()){
            k = k % nums.size();
        }
        std::vector<int> subSet;
        int tmp;        
        for (int i = nums.size() - k; i < nums.size(); i++) {
            subSet.push_back(nums[i]);
        }
        for (int i = nums.size() - k - 1; i >= 0; i--) {
            nums[i + k] = nums[i];
        }
        for (int i = 0; i < k; i++) {
            nums[i] = subSet[i];
        }
    }
};
