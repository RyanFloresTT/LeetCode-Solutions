/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
#include <iostream>
#include <unordered_set>
class Solution {
public:
    bool hasCycle(ListNode* head) {
        std::unordered_set<ListNode*> nodeSet;
        while (head != nullptr) {
            if (nodeSet.count(head) > 0) {
                return true;
            }
            nodeSet.insert(head);
            head = head->next;
        }
        return false;
    }
};