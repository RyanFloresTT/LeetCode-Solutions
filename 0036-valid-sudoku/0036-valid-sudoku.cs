public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<int> sudokuSet = new();
        
        bool TryAddToSet(int i, int j){
            if (board[i][j] != '.'){
                if (!sudokuSet.Contains(board[i][j])){
                    sudokuSet.Add(board[i][j]);
                    return true;
                } else {
                    return false;
                }
            }
            return true;
        }
        
        // Check Rows
        for (int i = 0; i < board.Length; i++){
            sudokuSet.Clear();
            for (int j = 0; j < board[i].Length; j++){
                if (!TryAddToSet(i,j)){return false;}
            }
        }
            
        // Check Columns
        for (int i = 0; i < board.Length; i++){
            sudokuSet.Clear();
            for (int j = 0; j < board[i].Length; j++){
                if (!TryAddToSet(j,i)){return false;}
            }
        }
            
        // Check Squares
        // Loops for Each Square
        for (int i = 0; i < 3; i++){
            sudokuSet.Clear();
            for (int j = 0; j < 3; j++){
                sudokuSet.Clear();
                // Loops for Within Each Square
                for (int k = i * 3; k < (i * 3) + 3; k++){
                    for (int l = j * 3; l < (j * 3) + 3; l++){
                        if (!TryAddToSet(k,l)){return false;}
                    }
                }
            }
        }
        return true;
    }
}