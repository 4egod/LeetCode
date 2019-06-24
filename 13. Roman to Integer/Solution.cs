using System.Collections.Generic;

public class Solution
{
    public int RomanToInt(string s)
    {
        int res = 0, p = 0, c = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            switch (s[i])
            {
                case 'M': c = 1000; break;
                case 'D': c = 500; break;
                case 'C': c = 100; break;
                case 'L': c = 50; break;
                case 'X': c = 10; break;
                case 'V': c = 5; break;
                case 'I': c = 1; break;
                default: break;
            }

            if (c >= p)
            {
                res += c;
                p = c;
            }
            else
            {
                res -= c;
            }
        }

        return res;
    }

    //public int RomanToInt(string s)
    //{
    //    int res = 0;

    //    Dictionary<string, int> d1 = new Dictionary<string, int>();
    //    d1.Add("CM", 900);
    //    d1.Add("CD", 400);
    //    d1.Add("XC", 90);
    //    d1.Add("XL", 40);
    //    d1.Add("IX", 9);
    //    d1.Add("IV", 4);
    //    d1.Add("III", 3);
    //    d1.Add("II", 2);

    //    foreach (var item in d1)
    //    {
    //        if (s.Contains(item.Key))
    //        {
    //            s = s.Replace(item.Key, string.Empty);
    //            res += item.Value;
    //        }
    //    }

    //    Dictionary<string, int> d2 = new Dictionary<string, int>();
    //    d2.Add("M", 1000);
    //    d2.Add("D", 500);
    //    d2.Add("C", 100);
    //    d2.Add("L", 50);
    //    d2.Add("X", 10);
    //    d2.Add("V", 5);
    //    d2.Add("I", 1);

    //    foreach (var item in d2)
    //    {
    //        while (s.Contains(item.Key))
    //        {
    //            int idx = s.IndexOf(item.Key);
    //            s = s.Remove(idx, 1);
    //            res += item.Value;
    //        }
    //    }

    //    return res;
    //}
}