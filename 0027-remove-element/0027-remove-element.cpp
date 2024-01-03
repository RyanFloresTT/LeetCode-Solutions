class Solution {
public:
    int removeElement(vector<int>& nums, int val) {
        multiset<int> numSet;
        for(int num : nums){
            if (num != val){
                numSet.insert(num);
            }
        }
        int i = 0;
        for (auto it = numSet.begin(); it != numSet.end(); it++) {
            nums[i] = *it;
            i++;
        }
        return numSet.size();
    }
};