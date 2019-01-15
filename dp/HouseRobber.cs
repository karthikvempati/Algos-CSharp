using System;

namespace dp{
    public class HouseRobber
    {
        public int Rob(int[] nums) {

            if(nums.Length == 0)
                return 0;

            var sums = new int[nums.Length]; 
            if(nums.Length >= 1){
                sums[0] = nums[0];
            }
            if(nums.Length > 1){
                sums[1] = Math.Max(nums[1], nums[0]);
            }

            for(int i=2;i<nums.Length;i++){
                sums[i] = Math.Max(sums[i-2] + nums[i], sums[i-1]);
            }

            return sums[nums.Length -1];
        }  
    }
}