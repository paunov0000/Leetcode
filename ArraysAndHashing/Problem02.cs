using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndHashing
{
    public class Problem02
    {
        public bool IsAnagram(string s, string t)
        {
            var chars = new int[128];

            if (s.Length != t.Length)
            {
                return false;
            }

            foreach (char c in t)
            {
                chars[c]++;
            }

            foreach (char c in s)
            {
                if (chars[c] != 0)
                {
                    chars[c]--;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
