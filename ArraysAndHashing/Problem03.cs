using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndHashing
{
    public class Problem03
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var x = target - nums[i];

                if (map.ContainsKey(x))
                {
                    return new int[] { map[x], i };
                }

                map[nums[i]] = i;
            }

            return new int[0];
        }
    }
}
