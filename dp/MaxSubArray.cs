using System;

namespace dp {
    public class MaxSubArrayClass
    {
        public int MaxSubArray(int[] nums) {
            int max_sum_so_for = 0;
            int max_ending_sum = 0; 
            for (int i = 0; i < nums.Length; i++)
            {
                max_ending_sum = max_ending_sum + nums[i];
                if(max_ending_sum < 0){
                    max_ending_sum = 0;
                }
                if(max_sum_so_for < max_ending_sum){
                    max_sum_so_for = max_ending_sum;
                }                
            }
        
            return max_sum_so_for;
        } 
    }
}