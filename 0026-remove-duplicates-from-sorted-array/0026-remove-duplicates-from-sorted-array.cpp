class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        set<int> numSet;
        for(int num : nums){
            numSet.insert(num);
        }
        int i = 0;
        for (auto it = numSet.begin(); it != numSet.end(); it++){
            nums[i] = *it;
            i++;
        }
        return numSet.size();
    }
};