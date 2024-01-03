#include <random>
class RandomizedSet {
public:
    set<int> numSet;
    RandomizedSet() {
        numSet.clear();
    }
    
    bool insert(int val) {
        if(numSet.count(val) == 0){
            numSet.insert(val);
            return true;
        } else {
            return false;
        }
    }
    
    bool remove(int val) {
        if(numSet.count(val) == 0){
            return false;
        } else {
            numSet.erase(val);
            return true;
        }
    }
    
    int getRandom() {
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dis(0, numSet.size() - 1);
        auto it = numSet.begin();
        advance(it, dis(gen));
        return *it;
    }
};

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet* obj = new RandomizedSet();
 * bool param_1 = obj->insert(val);
 * bool param_2 = obj->remove(val);
 * int param_3 = obj->getRandom();
 */