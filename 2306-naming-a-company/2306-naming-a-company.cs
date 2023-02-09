public class Solution {
    public long DistinctNames(string[] ideas) {
        var initialGroup = new HashSet<string>[26];
        for (int i = 0 ; i < 26; i++) {
            initialGroup[i] = new HashSet<string>();
        }
        foreach(var idea in ideas) {
            initialGroup[idea[0] - 'a'].Add(idea.Substring(1, idea.Length - 1));
        }
        
        long answer = 0;
        for (int i = 0; i < 25; i++) {
            for (int j = i + 1; j < 26; j++) {
                long numOfMutual = 0;
                foreach (var ideaA in initialGroup[i]) {
                    if (initialGroup[j].Contains(ideaA))
                        numOfMutual++;
                }
                
                answer += 2 * (initialGroup[i].Count - numOfMutual) 
                    * (initialGroup[j].Count - numOfMutual);
            }
        }
        
        return answer;
    }
}