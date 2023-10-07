﻿TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();

        class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var totalFromLeftToRight = 0;
        var totalFromRightToLeft = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            totalFromLeftToRight += arr[i][i];
            totalFromRightToLeft += arr[i][arr.Count - 1 - i];
        }
        return Math.Abs(totalFromLeftToRight - totalFromRightToLeft);
    }
}