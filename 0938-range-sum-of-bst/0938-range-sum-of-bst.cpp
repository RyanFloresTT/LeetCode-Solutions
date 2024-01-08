/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    int rangeSumBST(TreeNode* root, int low, int high) {
        int result = 0;
        if(root == nullptr) {return 0;}
        if(root->val >= low && root->val <= high){
            result += root->val;
        }
        return rangeSumBST(root->right, low, high) + rangeSumBST(root->left, low, high) + result;
    }
};