namespace MockInterviews 
{
    public class WordSearch2DArray
    {
         public bool Exist(char[,] board, string word) {
             if(board.Length <=0)
                return false;
            int hlen = board.GetLength(0);
            int vlen = board.GetLength(1);

            return Dfs(board, word);
         }

         public bool Dfs(char[,] board, string word){
             bool[,] v = new bool[board.GetLength(0), board.GetLength(1)];
             
             for(int i=0;i<board.GetLength(0);i++){
                 for(int j=0;j < board.GetLength(1);j++){
                     if(DfsUtil(board, word, i,j,0,v)) return true;
                 }
             }
             
             /*if(DfsUtil(board, word, 0,0,0,v)) return true;
             if(board.GetLength(0) > 1 && DfsUtil(board, word, 1,0,0,v)) return true;
             if(board.GetLength(1) > 1 && DfsUtil(board, word, 0,1,0,v)) return true;
             if(board.GetLength(1) > 1 && board.GetLength(0) > 1 && DfsUtil(board, word, 1,1,0,v)) return true;*/

             return false;
         }

         public bool DfsUtil(char[,] board, string word,int i,int j,int index,bool[,] v){

            if (word[index] == board[i, j])
            {
                if (index == word.Length - 1) return true;

                index++;
                  
                v[i, j] = true;

                if (i < board.GetLength(0) - 1 && !v[i + 1, j] && DfsUtil(board, word, i + 1, j, index, v)) return true;
                if (j < board.GetLength(1) - 1 && !v[i, j + 1] && DfsUtil(board, word, i, j + 1, index, v)) return true;
                if (i > 0 && !v[i - 1, j] && DfsUtil(board, word, i - 1, j, index, v)) return true;
                if (j > 0 && !v[i, j - 1] && DfsUtil(board, word, i, j - 1, index, v)) return true;
            }

             return false;
         }

    }
}
