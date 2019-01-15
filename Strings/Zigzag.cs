using System;
using System.Text;

public class ZigZagString {
    public char[,] Convert(string s, int numRows) {
        int longCols = s.Length/numRows;
        int totalCols = longCols + (longCols)*(numRows-2);
        char[,] charMatrix = new char[numRows,totalCols];
        int i = 0; int j = 0;
        int a = 0; bool up = false;
        while(a < s.Length){
            if(i < numRows && j >=0 && !up){
                charMatrix[i,j] = s[a];
                i++;
                a++;
            }
            else if(up && i > 0 && j < totalCols ){
                i--;j++;
                charMatrix[i,j] = s[a];
                a++;
            }
            else if(i == numRows || i <= 0 ){
                up = !up;
                if(up) i--;
                else i++;
            }
        }
        
        return charMatrix;
        
        var sb = new StringBuilder();
        foreach(char b in charMatrix){
            if(b != default(char)){
                sb.Append(b.ToString());
            }
        }
        
        sb.ToString();
    }
}
