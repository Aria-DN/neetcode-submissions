public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0)
        {
            return "-empty-list-";
        }

        string encodedStrs = string.Empty;

        for (int i = 0; i < strs.Count; i++)
        {
            encodedStrs = string.Concat(encodedStrs, strs[i]);

            if (i < strs.Count - 1)
            {
                encodedStrs = string.Concat(encodedStrs, "-delim-");
            }
        }

        return encodedStrs;
    }

    public List<string> Decode(string s) {
        if (s == "-empty-list-")
        {
            return new List<string>();
        }

        string[] decodedStrsArray = s.Split("-delim-");
        return new List<string>(decodedStrsArray);
    }
}
