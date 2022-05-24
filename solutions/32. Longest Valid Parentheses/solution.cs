public class Solution {
    public int LongestValidParentheses(string s) {
        Stack<int> stack = new Stack<int>();
        char[] S = s.ToCharArray();
        int curr = 0, max = 0, temp = 0, prev = 0;
        for(int i = 0; i < S.Length; i++)
        {
            if(S[i] == '(')
                stack.Push(i);
            else if(S[i] == ')')
            {
                if(stack.Count != 0)
                {
                    S[i] = '-';
                    S[stack.Pop()] = '-';   
                }
            }
        }
        int count = 0, maxCount = 0;
        foreach(char x in S)
        {
            if(x == '-')
                count++;
            else
            {
                if(count > maxCount)
                    maxCount = count;
                count = 0;
            }
        }
        if(count > maxCount)
            maxCount = count;
        return maxCount;

    }
}