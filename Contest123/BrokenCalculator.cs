using System;

namespace Contest123 {

    public class BrokenCalculator
    {
        public int BrokenCalc(int X,int Y){
            int count = 0;

            while(X != Y){
                count++;
                if(Y == 2*X){
                    X *= 2;
                } else if(Y == 2*X-1){
                    X *= 2;
                }
                else if(Y == X-1){
                    X--;
                } else if(Math.Abs(Y - 4*X) < Math.Abs(Y - 4*(X-1))){
                    X = 2 * X;
                }
                else if(Math.Abs(Y - 4*X) > Math.Abs(Y - 4*(X-1))){
                    X--;
                }
                else if(Math.Abs(Y - 2*X) < Math.Abs(Y - 2*(X-1))){
                    X = 2 * X;
                }
                else if(Math.Abs(Y - 2*X) > Math.Abs(Y - 2*(X-1))){
                    X--;
                }
                else if(Y == 2*(X-1)){
                    count++;
                    break;
                }
            }

            return count;
        }
    }

}