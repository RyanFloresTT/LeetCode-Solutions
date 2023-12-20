/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* sortList(ListNode* head) {
        if(head == nullptr){return nullptr;}
        ListNode* dummy = new ListNode(0);
        ListNode* current = dummy;
        std::multiset<int> orderedSet;

        while(head->next != nullptr){
            orderedSet.insert(head->val);
            head = head->next;
        }
        orderedSet.insert(head->val);

        for (int i : orderedSet){
            dummy->next = new ListNode(i);
            dummy = dummy->next;
        }

        return current->next;
    }
};