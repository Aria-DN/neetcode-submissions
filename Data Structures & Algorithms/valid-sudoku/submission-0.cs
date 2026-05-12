public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Check for dups in each row
        for (int row = 0; row < 9; row++)
        {
            HashSet<char> seen = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                char value = board[row][i];

                if (value == '.') 
                    continue;
                if (seen.Contains(value)) 
                    return false;
                seen.Add(value);
            }
        }
        // Check for dups in each column
        for (int col = 0; col < 9; col++)
        {
            HashSet<char> seen = new HashSet<char>();

            for (int i = 0; i < 9; i++)
            {
                char value = board[i][col];

                if (value == '.')
                    continue;
                if (seen.Contains(value))
                    return false;
                seen.Add(value);
            }
        }
        // Check for dups in each 3x3 square
        for (int square = 0; square < 9; square++)
        {
            HashSet<char> seen = new HashSet<char>();

            // Determine which 3x3 box we're in
            int boxRow = square / 3; // 0,1,2 (top, middle, bottom)
            int boxCol = square % 3; // 0,1,2 (left, middle, right)

            // Convert box position to starting row/col in the grid
            int rowStart = boxRow * 3;
            int colStart = boxCol * 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int row = rowStart + i;
                    int col = colStart + j;
                    char value = board[row][col];

                    if (value == '.') 
                        continue;
                    if (seen.Contains(value)) 
                        return false;
                    seen.Add(value);
                }
            }
        }

        return true;
    }
}
