using System.Collections.Generic;

namespace CourseSchedule {
    public class Graph
    {
        private int vertexCount;
        private List<int>[] adjacencyList;

        public Graph(int vertexCount){
            this.vertexCount = vertexCount;
            adjacencyList = new List<int>[vertexCount];
            for(int i =0;i< vertexCount;i++){ 
                adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination){
            adjacencyList[source].Add(destination);
        }

        public List<int> GetChildren(int vertex){
            return adjacencyList[vertex];
        }

        public List<int> TopSort() { 
            List<int> list = new List<int>();
            bool[] visited = new bool[vertexCount]; 
            bool[] recStack = new bool[vertexCount];  
            for (int i = 0; i < vertexCount; i++)
            {
                if(visited[i]) continue;
                if(TopSortUtil(list, visited, recStack, i) == null){
                    return new List<int>();
                } 
            }

            return list;
            
        }

        public List<int> TopSortUtil(List<int> list, bool[] visited,bool[] recStack, int vertex){
            if(recStack[vertex]){
              return null;              
            } 

            if(visited[vertex]) {
                return list;
            }
            
            visited[vertex] = true;
            
            recStack[vertex] = true;

            foreach (var item in adjacencyList[vertex])
            { 
                if(TopSortUtil(list, visited, recStack, item) == null){
                    return null;
                }
            }

            recStack[vertex] = false;

            list.Add(vertex);
            
            return list;
        }
    }

}    