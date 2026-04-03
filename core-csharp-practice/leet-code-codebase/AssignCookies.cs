using System;

class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int a = g.Length - 1;
        int e = s.Length - 1;
        int re = 0;

        while (e >= 0 && a >= 0)
        {
            if (g[a] <= s[e])
            {
                re++;
                e--;
            }
            a--;
        }

        return re;
    }
}
