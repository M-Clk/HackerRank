class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var sortedList = arr.OrderBy(a=>a).ToList();
        long minSum = sortedList.Take(4).Sum(n => (long)n);
        long maxSum = sortedList.TakeLast(4).Sum(n => (long)n);
        Console.WriteLine("Max: " + String.Join(", ", sortedList.TakeLast(4).ToList()));
        Console.Write(minSum + " " + maxSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        Console.Write("Write the array please: ");
        List<int> arr = (Console.ReadLine()??"").TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
        Console.ReadLine();
    }
}
