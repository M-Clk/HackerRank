
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")??"D:/HackerRank/Outputs", true);

        List<int> a = (Console.ReadLine()??"").TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = (Console.ReadLine()??"").TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
        Console.ReadLine();

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var points = new List<int> {0,0};
           
        for (int i = 0; i < 3; i++)
        {
            if (a[i] == b[i]) //no one receives point
                continue;
            if (a[i] > b[i]) //a receives point
                points[0]++;
            else //b receives point
                points[1]++;
        } 
        return points;
    }

}