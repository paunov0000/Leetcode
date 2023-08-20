using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndHashing
{
    public class Problem01
    {

        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        public bool ContainsDuplicate(int[] nums)
        {
            var map = new HashSet<int>();

            foreach (int num in nums)
            {
                if (map.Contains(num)) return true;

                map.Add(num);
            }

            return false;
        }
    }
}
