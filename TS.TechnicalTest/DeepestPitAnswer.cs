namespace TS.TechnicalTest;

public static class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        if (points is { Length : < 3 }) return -1;

        for (var p = 0;  p < points.Length - 2 ; p ++)
        {
           if(points[p] <= 0) continue; 
             
        }
    }
}
