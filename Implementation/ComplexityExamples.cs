// Time complexity for this method is O(n) - as loop is going to be executed for n times
public static void PrintNumbers(int n)
{
    for (int i = 0; i < n; i++)
        Console.WriteLine(i);
}

//Time complexity for this method is O(n2) - as there is a nested loop and inner statement is going to be executed for n*n times so n2
public static void PrintPairs(int n)
{
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            Console.WriteLine($"{i}, {j}");
}

//Time complexity for this method is O(1) - it is only printing one element from the array so 1
public static void PrintFirstItem(int[] nums)
{
    Console.WriteLine(nums[0]);
}

//Time complexity for this method is O(n) - as the loop is getting executed for n/2 but time complexity considers the degree of polynomial so it's n
public static void PrintHalf(int[] nums)
{
    for (int i = 0; i < nums.Length / 2; i++)
        Console.WriteLine(nums[i]);
}
