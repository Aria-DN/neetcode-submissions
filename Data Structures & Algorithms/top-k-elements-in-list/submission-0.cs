public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        int numsLength = nums.Length;
        int[] mostFreqNums = new int[k];
        Dictionary<int, int> numCounts = new();
        for (int i=0; i<nums.Length; i++)
        {
            int iCount = 0;

            for (int j=0; j<nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    iCount++;
                }
            }
            numCounts[nums[i]] = iCount;
        }

        for (int i=0; i<k; i++)
        {
            int highestFreq = numCounts.OrderByDescending(x => x.Value).First().Key;
            mostFreqNums[i] = highestFreq;
            numCounts.Remove(highestFreq);
        }
        return mostFreqNums;
    }
}
