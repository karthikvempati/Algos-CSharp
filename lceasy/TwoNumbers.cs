using System;
using System.Collections.Generic;

namespace lceasy
{
    public class TwoNumbers
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int sec = target-nums[i];
                if(d.ContainsKey(sec)){
                    return new int[]{d[sec],i};
                }
                else if(!d.ContainsKey(nums[i])){
                    d.Add(nums[i], i);
                }
            }


            return new int[] { };
        }
    }
}