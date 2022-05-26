public class Solution {
    public int HammingWeight(uint n) {
        string binary = Convert.ToString(n, 2);
        int count = 0;
        for(int i = 0; i < binary.Length; i++)
        {
            if(binary[i] == '1')
                count++;
        }
        return count;
    }
}