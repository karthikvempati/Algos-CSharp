public class Solution {
    public string Convert(string s, int numRows) {
        int longCols = s.Length/numRows;
        int totalCols = longCols + (longCols-1)*(numRows-2);
        char[,] charMatrix = new char[numRows,totalCols];
        int i = numRows; int j = totalCols;
        int a = 0; bool up = false;
        while(a < s.Length){
            if(i < numRows && j >=0 && !up){
                charMatrix[i,j] = s[a];
                i++;
            }
            else if(up && i > 0 && j < totalCols ){
                i--;j++;
                charMatrix[i,j] = s[a];
            }
            else if(i == numRows || i <= 0 ){
                up = !up;
            }
        }
        
        StringBuilder sb = new StringBuilder();
        foreach(char b in charMatrix){
            if(b != default(char)){
                sb.Append(b.ToString());
            }
        }
        
        return sb.ToString();
    }
}
