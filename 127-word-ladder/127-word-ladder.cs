public class Solution {
    
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
       if (beginWord == null || endWord == null || wordList == null || wordList.Count == 0)
        {
            return 0;
        }

        var dict = new HashSet<string>(wordList);
        if (!dict.Contains(endWord))
            return 0; 

        var queue = new Queue<string>();

        queue.Enqueue(beginWord);

        // mark visit
        dict.Remove(beginWord); 

        int depth = 1;

        while (queue.Count > 0)
        {
            int count = queue.Count;
            depth++; 

            // Check each adjacent string
            for (int layer = 0; layer < count; layer++) 
            {
                var current = queue.Dequeue();

                // go over each char in the word first                    
                for (int index = 0; index < current.Length; index++)
                {
                    // replace by all possible neighbors
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        if (c == current[index])
                        {
                            continue;
                        }

                        var neighbor = stringReplaceAt(current, index, c); // C# string is immutable

                        // find endWord
                        if (neighbor.CompareTo(endWord) == 0)
                        {
                            return depth;
                        }

                        if (dict.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                            dict.Remove(neighbor);
                        }
                    }
                }
            }                
        }

        return 0;
    }
    
    private static String stringReplaceAt(String s, int index, char c)
    {
        var array = s.ToCharArray();
        array[index] = c;

        return new String(array);
    }
}