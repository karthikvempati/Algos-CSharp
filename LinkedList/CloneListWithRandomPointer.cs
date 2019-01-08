using System.Collections.Generic;

namespace LinkedLists
{
    public class RandomListNode {
        public int label;
        public RandomListNode next, random;
        public RandomListNode(int x) { this.label = x; }
    }

    public class LinkedListsSolution {
        public RandomListNode CopyRandomList(RandomListNode head) {
            if(head == null)
                return null;
            RandomListNode headNode = new RandomListNode(head.label);
            var currentNode = headNode;
            var map = new Dictionary<RandomListNode, RandomListNode>();
            while(head != null){
                RandomListNode outPut = null;
                if(head.next != null){
                    if(map.TryGetValue(head.next,out outPut)){
                        currentNode.next = outPut;
                    }
                    else{ 
                            var next = new RandomListNode(head.next.label);
                            currentNode.next = next;
                            map.Add(head.next,next); 
                    }
                }
                else{
                    currentNode.next = null;
                }
                if(head.random != null){
                    if(map.TryGetValue(head.random, out outPut)){
                        currentNode.random = outPut;
                    }
                    else { 
                            var random = new RandomListNode(head.random.label);
                            currentNode.random = random;
                            map.Add(head.random, random);  
                    }
                }
                else{
                    currentNode.random = null;
                }
                
                head = head.next;
                currentNode = currentNode.next; 
            }
            
            return headNode;
        }
    }
}