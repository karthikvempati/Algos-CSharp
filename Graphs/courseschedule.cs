using System;
using System.Collections.Generic;

namespace Graphs
{

    public class  Node
    {
        public int val;
        public Node next;

        public Node(int value){
            val = value;
        }
    }
    
    public class Graph
    {
        private int vertexCount;
        private List<List<int>> adjacencyList;

        public Graph(int vertexCount){
            this.vertexCount = vertexCount;
            adjacencyList = new List<List<int>>();
            for(int i =0;i< vertexCount;i++){
                var adjacencyChildList = new List<int>();
                adjacencyList.Add(adjacencyChildList);
            }
        }

        public void AddEdge(int source, int destination){
            adjacencyList[source].Add(destination);
        }

        public List<int> GetChildren(int vertex){
            return adjacencyList[vertex];
        }

        public bool IsCyclicUtil(int vertex, bool[] visited, bool[] recStack){
            if(recStack[vertex]){
                return true;
            }

            if(visited[vertex]){
                return false;
            }

            recStack[vertex] = true;
            visited[vertex] = true;

            foreach(var child in GetChildren(vertex)){
                if(IsCyclicUtil(child, visited, recStack)){
                    return true;
                }
            }

            recStack[vertex] = false;

            return false;
        }

        public bool IsCyclic(){
            bool[] v = new bool[vertexCount];
            bool[] rs = new bool[vertexCount];
            for(int i=0;i<vertexCount;i++){
                if(IsCyclicUtil(i,v,rs)){
                    return true;
                }
            }

            return false;
        }

    }

    public class  Solution
    {
        public bool CourseSchedule(int numOfCourses,int[,] preReqs){
            HashSet<int> v = new HashSet<int>();
            Stack<Node> s = new Stack<Node>(); 
            Graph g = new Graph(numOfCourses);

            for(int i = 0; i < preReqs.GetLength(0); i++){     
                g.AddEdge(preReqs[i,0], preReqs[i,1]);
            } 
 
            return !g.IsCyclic();
        }  
    }

}