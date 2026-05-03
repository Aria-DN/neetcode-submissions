public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        List<List<string>> allAnagramGrps = new();
        bool[] used = new bool[strs.Length];

        for (int i = 0; i < strs.Length; i++)
        {
            if (used[i]) continue;

            List<string> currAnagramGrp = new();
            currAnagramGrp.Add(strs[i]);
            used[i] = true;

            for (int k = i + 1; k < strs.Length; k++)
            {
                if (used[k]) continue;

                char[] iArray = strs[i].ToCharArray();
                char[] kArray = strs[k].ToCharArray();

                Array.Sort(iArray);
                Array.Sort(kArray);

                string iString = new string(iArray);
                string kString = new string(kArray);

                if (iString == kString)
                {
                    currAnagramGrp.Add(strs[k]);
                    used[k] = true;
                }
            }
            allAnagramGrps.Add(currAnagramGrp);
        }
        return allAnagramGrps;
    }
}