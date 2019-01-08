using System.Collections.Generic;

namespace DfsGraph 
{
    public class Graph
    {
        int vertexCount;
        List<List<int>> adjacencyList;

        public Graph(int vertexCount){
            this.vertexCount = vertexCount;
            adjacencyList = new List<List<int>>();
            for (int i = 0; i < vertexCount; i++)
            {
                adjacencyList.Add(new List<int>());
            }
        }

        public void AddEdge(int source, int destination){
            adjacencyList[source].Add(destination);
            adjacencyList[destination].Add(source);
        }

        public List<int> GetChildren(int vertex){
            return adjacencyList[vertex];
        }

        public bool[] DfsGraph(){
            List<int> dfsList = new List<int>();
            bool[] visited = new bool[vertexCount];
            dfsList.Add(0);
            visited[0] = true;
            foreach(var a in adjacencyList[0]){
                if(!visited[a]){
                    DfsGraphUtil(a, dfsList, visited);
                }
            } 
            return visited;
        }

         public bool DfsGraphCycle(){ 
            bool[] visited = new bool[vertexCount]; 
            visited[0] = true;
            foreach(var a in adjacencyList[0]){ 
                 
                if(DfsGraphUtilCycle(a, visited, 0)){
                    return true;
                }
                
            }

            return false;
        }

        public void DfsGraphUtil(int vertex, List<int> dfsList, bool[] visited){            
            
            visited[vertex] = true;
            dfsList.Add(vertex);
            foreach (var item in adjacencyList[vertex])
            {
                if(!visited[item]){ 
                    DfsGraphUtil(item, dfsList, visited);
                } 
            }
        }
 
        public bool DfsGraphUtilCycle(int vertex, bool[] visited, int parent){            
            
            visited[vertex] = true;  
            foreach (var item in adjacencyList[vertex])
            {
                if(item == parent) continue;
                if(visited[item])
                    return true;
                DfsGraphUtilCycle(item, visited, vertex);
            }

            return false;
        }
    }
}