public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        List<int> result = new();
        
        Dictionary<int, int> num1Dict = CountArrayToDict(nums1);
        Dictionary<int, int> num2Dict = CountArrayToDict(nums2);
        
        int smallKey;

        foreach (var kvp in num1Dict.Count <= num2Dict.Count ? num1Dict : num2Dict){
            if (num1Dict.ContainsKey(kvp.Key) && num2Dict.ContainsKey(kvp.Key)){
                smallKey = num1Dict[kvp.Key] <= num2Dict[kvp.Key] ? num1Dict[kvp.Key] : num2Dict[kvp.Key];
                for (int i = 0; i < smallKey; i++){
                    result.Add(kvp.Key);
                }
            }
        }
        
        return result.ToArray();
    }
    
    public Dictionary<int, int> CountArrayToDict(int[] arr){
        Dictionary<int, int> res = new();
        
        for (int i = 0; i < arr.Length; i++){
            if (!res.ContainsKey(arr[i])){
                res.Add(arr[i], 1);
            } else {
                res[arr[i]] += 1;
            }
        }
        
        return res;
    }
}