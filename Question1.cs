class Question1{
    public static void Main()
    {
        int[] nums = {2,2,1};
        Console.Write(SingleNumber(nums));
    }
    public static int SingleNumber(int[] nums)
    {
        Array.Sort(nums);
        if (nums.Length > 1)
        {
            for (int i = 1; i < nums.Length - 1; i++)//check in between first and last index
            {
                if (nums[i - 1] != nums[i] && nums[i + 1] != nums[i])
                {
                    return nums[i];
                }
            }
            if (nums[0] != nums[1])//first index is single
            {
                return nums[0];
            }
            if (nums[nums.Length - 1] != nums[nums.Length - 2])//last index is single
            {
                return nums[nums.Length - 1];
            }
        }
        else 
            return nums[0];
        return 0;
    }
}
