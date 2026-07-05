public static class ArrayOperations
{
    public static int Search(int[] nums, int target)
    {
        int index = -1;
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] == target)
            {
                index = i;
                break;
            }
        }
        return index;
    }
    //Time complexity - O(n) - as will have to check all the elements in case target is at the last index.
    //Space complexity - O(1) - as we are just creating few properties and that wont change with increased array length.

    public static int FindSecondLargest(int[] nums)
    {
        int largest = 0, secondLargest = 0;
        int length = nums.Length;
        for (int i = 1; i < length; i++)
        {
            if (nums[i] > largest)
            {
                secondLargest = largest;
                largest = nums[i];
            }
            else if (nums[i] > secondLargest && secondLargest != largest)
            {
                secondLargest = nums[i];
            }
        }
        return secondLargest;
    }
    //Time complexity - O(n) - as we are doing one traversal
    //Space complexity - O(1) - as we are just creating few properties and that wont change with increased array length.

    public static int[] Remove(int[] nums, int element)
    {
        int length = nums.Length;
        int index = 0;
        bool elementFound = false;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] == element)
            {
                elementFound = true;
                index = i;
                break;
            }
        }
        if (!elementFound)
        {
            return nums;
        }
        for (int i = index; i < length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[length-1] = 0;
        return nums;
    }
    //Time complexity - O(n) - as we are doing two traversals but total operations are n only as k for search and n-k for shifting
    //Space complexity - O(1) - as we are just creating few properties and that wont change with increased array length.
}

