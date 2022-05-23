public class Solution
{
    int[,,] dp = new int[601, 101, 101];
    public int FindMaxForm(string[] strs, int m, int n)
    {
        int l = strs.Length;
        int[,] dig = new int[l, 2];
        for (int i = 0; i < l; i++)
        {
            foreach (char x in strs[i])
            {
                if (x == '0')
                    dig[i, 0]++;
                else
                    dig[i, 1]++;
            }
        }
        return sub(dig, 0, m, n, l);
    }

    public int sub(int[,] dig, int index, int avaiZeros, int avaiOnes, int l)
    {
        if (index >= l || (avaiZeros <= 0 && avaiOnes <= 0))
            return 0;
        if (dp[index, avaiZeros, avaiOnes] != 0)
            return dp[index, avaiZeros, avaiOnes];
        if (dig[index, 0] > avaiZeros || dig[index, 1] > avaiOnes)
            return dp[index, avaiZeros, avaiOnes] = sub(dig, index + 1, avaiZeros, avaiOnes, l);

        return dp[index, avaiZeros, avaiOnes] = Math.Max((1 + sub(dig, (index + 1), avaiZeros - dig[index, 0], avaiOnes - dig[index, 1], l)), (sub(dig, (index + 1), avaiZeros, avaiOnes, l)));

    }
}