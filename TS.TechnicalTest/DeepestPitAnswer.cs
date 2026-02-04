namespace TS.TechnicalTest;

public static class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        if (points is { Length : < 3 }) return -1;

        var maximumDepth = -1;
        for (var p = 0;  p < points.Length - 2 ; p ++)
        {
           if(points[p] <= 0) continue;

           var q = p ;
           while (q +1 <  points.Length &&  points[q] <= points[q + 1])
           {
               q++;
           }
           
           if(q == p) continue;

           var r = q;
           while (r +1 <  points.Length &&  points[r] <= points[r + 1])
           {
               r++;
           }
           
           if(r == q) continue;
           
           var left = points[p] - points[q];
           var right = points[r] - points[q];
           var depth = Math.Max(left, right);
           maximumDepth = Math.Max(maximumDepth, depth);

        }
        return maximumDepth;
    }
}
