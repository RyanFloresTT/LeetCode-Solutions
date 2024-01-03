class Solution {
public:
    int majorityElement(vector<int>& nums) {
        set<int> numSet;
        for(int num : nums){
            numSet.insert(num);
        }
        int majorityOccurence = nums.size() / 2;
        int majorityNumber;
        for (auto it = numSet.begin(); it != numSet.end(); it++){
            int count = std::count(nums.begin(), nums.end(), *it);
            if(count > majorityOccurence){
                majorityNumber = *it;
                return majorityNumber;
            }
        }
        return majorityNumber;
    }
};