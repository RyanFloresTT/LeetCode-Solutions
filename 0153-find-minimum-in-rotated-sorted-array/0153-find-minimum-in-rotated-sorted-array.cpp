class Solution {
public:
    int findMin(vector<int>& nums) {
        std::set<int> orderedSet;

        for(int i : nums){
            orderedSet.insert(i);
        }

        return *orderedSet.begin();
    }
};