class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int pricesSize = prices.size();
        int maxProfit = 0;
        int currentProfit = 0;
        
        for (int i = 1; i < pricesSize; i++){
            if (prices[i] - prices[i - 1] > 0){
                currentProfit += prices[i] - prices[i - 1];
                if (currentProfit > maxProfit){maxProfit = currentProfit;}
            } else {
                if (currentProfit > 0){
                    currentProfit += prices[i] - prices[i - 1];
                    if (currentProfit < 0){currentProfit = 0;}
                }            
            }
        }
        return maxProfit;
    }
};