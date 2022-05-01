public class Solution {
    Dictionary<string,List<(string k,double v)>> dictEq = new Dictionary<string,List<(string k,double v)>>();
    
    
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        
        for(var i = 0; i< equations.Count; i++  ){
            
            if(!dictEq.ContainsKey(equations[i][0])){
                
                dictEq.Add(equations[i][0], new List<(string,double)>());
            }
            
            dictEq[equations[i][0]].Add((equations[i][1], values[i]));
            
            if(!dictEq.ContainsKey(equations[i][1])){
                
                dictEq.Add(equations[i][1], new List<(string,double)>());
            }
            
            dictEq[equations[i][1]].Add((equations[i][0], 1/values[i]));
            
        }
        
        double[] res = new double[queries.Count];
        
        for( var i =0; i< queries.Count; i++ ){
            if(dictEq.ContainsKey(queries[i][0]) && dictEq.ContainsKey(queries[i][1] )){
                res[i] = DFS(new HashSet<string>(),  queries[i][0], 1, queries[i][1]);
            }
            else res[i] = -1.0;
                
        }
        return res;
    }
    
    public double DFS(HashSet<string> visited, string next, double tempResult, string des ){
       
        
       if(next == des) return tempResult;
        
        var adjList = dictEq[next];
        
        for(var i =0 ;i< adjList.Count; i++ ){
            
            if(!visited.Contains(adjList[i].k)){
                visited.Add(adjList[i].k);
                var tempRes = DFS(visited,adjList[i].k, tempResult * adjList[i].v,des);
                if(tempRes != -1) return tempRes;
            }
        }
        
        return -1.0;
    }
}