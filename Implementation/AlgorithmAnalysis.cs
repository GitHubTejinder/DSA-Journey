public static class AlgorithmAnalysis
{
    public static int FindMax(int[] nums)
    {
        int max = nums[0];

        foreach (var num in nums)
        {
            if (num > max)
                max = num;
        }

        return max;
    }
    // Time Complexity - O(n) - as we have to iterate over this loop n time to find the Max number in worst case.
    // Space Complexity - O(1) - as we just have one variable max for storing the Max value.

    public static int[] ReverseArray(int[] nums)
    {
        var arrayLength = nums.Length;
        var reversedArray = new int[arrayLength];
        
        for(int i = 0; i < arrayLength; i++)
        {
            reversedArray[arrayLength - i - 1] = nums[i];
        }

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(reversedArray[i]);
            if (i != arrayLength - 1)
            {
                Console.Write(", ");
            }
        }

        return reversedArray;
    }
    // Time Complexity - O(n) - as we have to iterate over this loop n time to shift the elements from one array to another
    // Space Complexity - O(n) - as we just have to have another array as well

    public static int[] ReverseArrayInPlace(int[] nums)
    {
        var arrayLength = nums.Length;
        int left, right, temp = 0;

        for (int i = 0; i < arrayLength/2; i++)
        {
            left = i;
            right = arrayLength - i - 1;

            if (left != right)
            {
                temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
            }
        }
        

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(nums[i]);
            if(i != arrayLength - 1)
            {
                Console.Write(", ");
            }
        }

        return nums;
    }
    // Time Complexity - O(n) - as we have to iterate over this loop n/2 time but would be n only
    // Space Complexity - O(1) - as we just 3 other fields

    public static void FrequencyCounter(string chars)
    {
        Dictionary<char, int> frequency = [];

        foreach(char c in chars)
        {
            if(frequency.TryGetValue(c, out int value))
            {
                frequency[c] = value + 1;
            }
            else
            {
                frequency.Add(c, 1);
            }
        }

        foreach(var kv in frequency)
        {
            Console.WriteLine(kv.Key + " -> " + kv.Value);
        }
    }
    // Time Complexity - O(n) - as we have to iterate over this loop n time but would be n only
    // Space Complexity - O(n) - as we just Dictionary of size n
}
