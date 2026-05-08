public class Solution {
    public int[] ProductExceptSelf(int[] nums) // No division, but not O(n) time yet. Stilll O(n^2)
    {
        int[] output = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int tempSelfNum = nums[i];
            int tempProduct = 1;
            nums[i] = 1;
            foreach (int num in nums)
            {
                tempProduct = tempProduct * num;
            }
            output[i] = tempProduct;
            nums[i] = tempSelfNum;
        }
        return output;
    }
}
