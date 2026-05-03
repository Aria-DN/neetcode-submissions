public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] count = new int[26]; // number of letters in alphabet

        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++; // ANSII number
            count[t[i] - 'a']--; 
        }

        for (int i = 0; i < 26; i++) {
            if (count[i] != 0) return false; // All numbers subtracted should be 0
        }

        return true;
    }
}