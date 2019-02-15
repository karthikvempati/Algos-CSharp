using System;
using System.Collections.Generic;

namespace lcmedium {
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums){

            Array.Sort(nums);
            var result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(i >0 && nums[i] == nums[i-1]) continue;
                int j = i+1;
                int k = nums.Length - 1;
                while(j<k){
                    if(nums[i] + nums[j] + nums[k] > 0){
                        k--;
                        continue;
                    } else if(nums[i] + nums[j] + nums[k] < 0){
                        j++;
                        continue;
                    } else {
                        result.Add(new List<int>(){nums[i], nums[j], nums[k]});
                    }
                    do j++; while(j < k && nums[j]==nums[j-1]);
                    while(j<k && nums[k] == nums[k-1]) k--;
                }    
            }

            return result;
        }
    }
}