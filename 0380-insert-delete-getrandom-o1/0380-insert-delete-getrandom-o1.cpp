#include <random>

class RandomizedSet {
public:
    std::unordered_set<int> numSet;
    std::mt19937 gen;

    RandomizedSet() : gen(std::random_device{}()) {
        numSet.clear();
    }

    bool insert(int val) {
        return numSet.insert(val).second;
    }

    bool remove(int val) {
        return numSet.erase(val) > 0;
    }

    int getRandom() {
        std::uniform_int_distribution<> dis(0, numSet.size() - 1);
        auto it = numSet.begin();
        std::advance(it, dis(gen));
        return *it;
    }
};
