using System;
using System.Collections.Generic;
using System.Linq;

namespace TripleByte {

    public class TicTacToe
    {
        char[,] board;
        HashSet<int> excludeRow = new HashSet<int>();
        HashSet<int> excludeCol = new HashSet<int>();
        
        public TicTacToe(){
            board = new char[3,3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {  
                    board[i,j] = '-';
                } 
            }
        }

        //This method expects a 0 indexed row and column
        public void AddToken(int row, int col, char token){

            if(IsBoardFull())
                throw new Exception("Board is already full. No more moves possible");
            
            if(row < 3 && col  < 3 && row >=0 && col >=0 && (token == 'X' || token == 'O')){
                if(board[row,col] != '-'){
                    board[row,col] = token; 
                    excludeCol.Add(col);
                    excludeRow.Add(row);
                } 
                else 
                    throw new Exception("This is not a valid move");
            } else {
                throw new Exception("This is not a valid move");
            }
        }

        public bool IsBoardFull(){
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                { 
                    if(board[i,j] == '-')
                        return false;
                } 
            }

            return true;
        }

        public void MakeAMoveAI(){
            var rangeRow = Enumerable.Range(0, 2).Where(i => !excludeRow.Contains(i));
            var rangeCol = Enumerable.Range(0, 2).Where(i => !excludeCol.Contains(i));

            var rand = new System.Random();
            int indexRow = rand.Next(0, 2 - excludeRow.Count);
            int indexCol = rand.Next(0, 2 - excludeCol.Count);
            int row = rangeRow.ElementAt(indexRow);
            int col = rangeCol.ElementAt(indexCol);
            
            excludeRow.Add(row);
            excludeCol.Add(row);

            if(IsPositionAvailable(row,col)){
                AddToken(row,col, 'O');
            }
            else {
                MakeAMoveAI();
            }

        }

        public bool IsPositionAvailable(int row, int col){
            if(excludeCol.Count == 3 && excludeRow.Count == 3)
                return false;

            if(board[row,col] == '-')
                return true;

            return false;
        }

        public void PrintBoard(){
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if(j == 2){
                        Console.Write(board[i,j]);
                        break;
                    }
                    Console.Write( board[i,j] + "|");
                }

                Console.WriteLine();
            }
        }

    }

}