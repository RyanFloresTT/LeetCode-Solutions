class Solution {
public:
    int numberOfBeams(vector<string>& bank) {
        int beams = 0;
        int prevLasers = 0;
        for(string row : bank){
            int rowLasers = 0;
            for(int i = 0; i < row.size(); i++){
                if (row[i] == '1'){
                    rowLasers++;
                }
            }
            if (rowLasers > 0){
                beams += prevLasers * rowLasers;
                prevLasers = rowLasers;
            }
        }
        return beams;
    }
};