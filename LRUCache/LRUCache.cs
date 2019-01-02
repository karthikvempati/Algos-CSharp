using System.Collections.Generic;
using System;

 
namespace LRUCacheNS {
public class LRUCache {

    public Dictionary<int, DLL> dict = new Dictionary<int, DLL>(); 
    int capacity = 0;
    public DLL head = null;
    public DLL tail = null;
    
    public LRUCache(int capacity) {
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        DLL item = null;
        
        if(dict.ContainsKey(key)){
            item = dict[key];
        }

        if(item != null && item != tail && item != head){
            DeleteNode(item);
            UpdateHead(item);
        }
        else if(item == tail && item != null){
            DeleteLastNode();
            UpdateHead(item);
        } 

        return item == null? -1:item.data;        
    }
    
    public void Put(int key, int value) {
         
        if(dict.ContainsKey(key) && dict[key].data == value){
            throw new System.Exception("Item already exists");
        }

        if(dict.Count >= capacity){ 
            DeleteLastNode();            
        }

        var item = new DLL(key, value); 
        dict.Add(key, item);
        UpdateHead(item);
    }
    
    public void DeleteLastNode(){
        if(tail == null){
            return;
        }

        var temp = tail;        
        tail = tail.prev;        
        tail.next = null;
        dict.Remove(temp.key);
        temp = null; 
    }

    public void DeleteNode(DLL item){
        if(item == null)
            return;
        var prev = item.prev;
        var next = item.next;
        prev.next = next;
        next.prev = prev;
    }

    public void UpdateHead(DLL newHead){
        if(head == null){
            head = newHead; 
            return;
        }
        else if(tail == null){
            tail = head;
            head = newHead;
            tail.prev = head;
            head.next = tail;
            return;
        }

        var temp = head;
        head = newHead;
        head.prev = null;
        head.next = temp;
        temp.prev = head;

        if(!dict.ContainsKey(newHead.key)){
            dict.Add(newHead.key, newHead);
        }
    }
}

public class DLL {

    public DLL(int key,int value){
        this.key = key;
        this.data = value;
    }
    public int data;
    public int key;
    public DLL prev;
    public DLL next;
}

}
/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */