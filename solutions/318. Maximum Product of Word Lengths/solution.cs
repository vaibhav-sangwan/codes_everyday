public class Solution {
    public int MaxProduct(string[] words) {
        int maxProd = 0, prod = 0;
        Dictionary<char, int>[] dict = new Dictionary<char, int>[words.Length];
        for(int i = 0; i < words.Length; i++)
        {
            dict[i] = new Dictionary<char, int>();
            foreach(char x in words[i])
            {
                if(!dict[i].ContainsKey(x))
                    dict[i].Add(x, 1);
            }
        }
        for(int i = 0; i < words.Length; i++)
        {
            for(int j = i + 1 ; j < words.Length; j++)
            {
                if(!matchingCharacters(words[i], dict[j]))
                {
                    prod = words[i].Length * words[j].Length;
                    if(prod > maxProd)
                        maxProd = prod;
                }
            }
        }
        return maxProd;
    }
    
    public bool matchingCharacters(string word, Dictionary<char, int> dict)
    {
        foreach(char x in word)
        {
            if(dict.ContainsKey(x))
                return true;
        }
        return false;
    }
}