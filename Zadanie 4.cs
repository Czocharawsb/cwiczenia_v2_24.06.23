using System;

public class Program
{
    public static void Main()
    {
        int[][] array = new int[][]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 4, 2, 3, 1 },
            new int[] { 3, 1, 4, 2 },
            new int[] { 2, 4, 1, 3 }
        };

        FindClosestRows(array, out int row1, out int row2);

        Console.WriteLine("Najbardziej zbliżone wiersze: {0}, {1}", row1, row2);
    }

    public static void FindClosestRows(int[][] array, out int row1, out int row2)
    {
        int minDiff = int.MaxValue;
        row1 = 0;
        row2 = 0;

        int rowCount = array.Length;

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = i + 1; j < rowCount; j++)
            {
                int diff = CalculateRowDifference(array[i], array[j]);

                if (diff < minDiff)
                {
                    minDiff = diff;
                    row1 = i;
                    row2 = j;
                }
            }
        }
    }

    public static int CalculateRowDifference(int[] row1, int[] row2)
    {
        int columnCount = row1.Length;
        int difference = 0;

        for (int k = 0; k < columnCount; k++)
        {
            int elementDiff = row1[k] - row2[k];
            difference += elementDiff * elementDiff;
        }

        return difference;
    }
}