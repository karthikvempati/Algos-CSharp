using System.Collections.Generic;

public class ValidTreeGraph { 
    public bool ValidTree(int n, int[,] edges) {
        /* if(n <= 1)
            return true;
        
        Graph g = new Graph(n);
        
        for(int i = 0; i < edges.GetLength(0); i++){     
                g.AddEdge(edges[i,0], edges[i,1]);
        }
        
        bool[] visited = g.DfsGraph();
        bool connected = (visited.Where(a => a == false).Count() == 0);
        bool cycle = g.DfsGraphCycle();             
        
        return connected && !cycle;*/
        return true;
    } 
}