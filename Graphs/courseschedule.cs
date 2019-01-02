using System;
using System.Collections.Generic;

namespace Graphs
{

    public class  Node
    {
        public int val;
        public Node next;

        public bool visited;

        public Node(int value){
            val = value;
        }
    }
    
    public class Graph
    {
        private int vertexCount;
        private List<Node> adjacencyList;

        public Graph(int vertexCount){
            this.vertexCount = vertexCount;
            adjacencyList = new List<Node>();
            for(int i =0;i< vertexCount;i++){
                adjacencyList[i] = new Node(i);
            }
        }

        public void AddEdge(int source, int destination){
            InsertNode(source,destination);
        }

        public void InsertNode(int source,int destination){
            Node parent = adjacencyList[source];
            Node child = new Node(destination);
            var temp = parent.next; 
            parent.next = child;
            child.next = temp;
        } 
    }

    public class  Solution
    {
        public bool CourseSchedule(int numOfCourses,int[,] preReqs){
            HashSet<int> v = new HashSet<int>();
            Stack<Node> s = new Stack<Node>(); 
            Graph g = new Graph(numOfCourses);

            for(int i=0; i < preReqs.GetLength(0); i++){
                g.AddEdge(preReqs[i,0], preReqs[i,0]);
            } 

            return false;
        } 

        public Node GetNextUnvisitedChild(HashSet<int> v, int source){
            return new Node(1);
        }
    }

}