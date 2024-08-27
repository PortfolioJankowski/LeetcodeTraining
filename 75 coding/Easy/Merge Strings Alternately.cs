public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder output = new StringBuilder(word1.Length + word2.Length);
        int maxIndex = Math.Max(word1.Length, word2.Length);
        int sbIndex = 0;
        for (int i = 0; i < maxIndex; i++){
            if (i < word1.Length) {
                output.Append(word1[i]);
            }
            if (i < word2.Length) {
                output.Append(word2[i]);
            }
        }
        return output.ToString();


    }
