using System.Numerics;

namespace Hackerrank;

public static class AOrB
{
    public static string PossibleSubsets(char[] A, int N)
    {
        string str = "";
        int N2q = (int)Math.Pow(2, N);
        for (int i = 0; i < (1 << N2q); ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                if ((i | (1 << j)) == 1)
                    str += A[j].ToString() + "\n";
            }
        }
        return str;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="k"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    public static void aOrB(int k, string a, string b, string c)
    {
        int k0d = k + 1;
        int ka0d = k + 1;
        int kb0d = k + 1;
        int kreset = 0;
        int kareset = 0;
        int kbreset = 0;
        BigInteger a0d = Convert.ToInt64(a, 16);
        BigInteger b0d = Convert.ToUInt64(b, 16);
        BigInteger c0d = Convert.ToInt64(c, 16);
        BigInteger aplusb = a0d + b0d;
        BigInteger iout = -1;
        BigInteger jout = -1;
        //--routine
        BigInteger i;
        for (i = 0; i <= aplusb; ++i)
        {
            BigInteger j;
            for (j = i; j <= aplusb; ++j)
            {
                BigInteger aorb = i | j;
                bool aorbisc = c0d == aorb;
                if (aorbisc)
                {
                    BigInteger axori = a0d ^ i;
                    BigInteger bxorj = b0d ^ j;
                    int abits = System.Numerics.BitOperations.PopCount((uint)axori);
                    int bbits = System.Numerics.BitOperations.PopCount((uint)bxorj);
                    int absum = abits + bbits;
                    int buffer = k0d;
                    int abuffer = ka0d;
                    int bbuffer = kb0d;
                    if (absum <= k0d)
                    {
                        kreset += 1;
                        k0d = absum;
                        ka0d = abits;
                        kb0d = bbits;
                        iout = i;
                        jout = j;
                        if (abits <= ka0d)
                        {
                            kareset = 0;
                            ka0d = abits;
                            iout = i;
                            jout = j;
                        }
                        else if (abuffer == ka0d)
                        {
                            kareset += 1;
                        }
                        if (bbits <= kb0d)
                        {
                            kbreset = 0;
                            kb0d = bbits;
                            iout = i;
                            jout = j;
                        }
                        else if (bbuffer == kb0d)
                        {
                            kbreset += 1;
                        }
                    }
                    else if (buffer == k0d)
                    {
                        kreset += 1;
                    }
                }

            }
        }
        string aout = Convert.ToHexString(iout.ToByteArray()).ToUpper();
        string bout = Convert.ToHexString(jout.ToByteArray()).ToUpper();
        string about = k0d > k ? "-1" : aout + "\n" + bout;
        Console.WriteLine(about);
    }
}