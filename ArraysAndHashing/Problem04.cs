namespace ArraysAndHashing
{
    public class Problem04
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var count = new char[26];

                foreach (var c in str)
                {
                    count[c - 'a']++;
                }

                var key = new string(count);

                if (!result.ContainsKey(key))
                {
                    result.Add(key, new List<string> { str });
                }
                else
                {
                    result[key].Add(str);
                }
            }

            return result.Values.ToList();
        }
    }
}
