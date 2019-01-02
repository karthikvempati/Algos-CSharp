using System.Collections.Generic;
  public class UndirectedGraphNode {
      public int label;
      public IList<UndirectedGraphNode> neighbors;
      public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
  }
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        var copy = new UndirectedGraphNode(node.label);
        Dictionary<int,UndirectedGraphNode> clonedNodes = new Dictionary<int, UndirectedGraphNode>();
        CloneGraph(node, copy, clonedNodes);
        return copy;
    }
    
    public void CloneGraph(UndirectedGraphNode node, UndirectedGraphNode copy,Dictionary<int,UndirectedGraphNode> clonedNodes){
        
         foreach(var c in node.neighbors){
             UndirectedGraphNode currentCopy = null;
             if(clonedNodes.ContainsKey(c.label)){
                currentCopy = clonedNodes[c.label];
                copy.neighbors.Add(currentCopy);
             }
             else {
                currentCopy = new UndirectedGraphNode(c.label);
                clonedNodes.Add(c.label, currentCopy);
                copy.neighbors.Add(currentCopy);  
             } 
             
             CloneGraph(c, currentCopy, clonedNodes);
         }
    }
}