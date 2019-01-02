using System;
using LRUCacheNS;

namespace algoscsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCacheNS.LRUCache cache = new LRUCacheNS.LRUCache( 1 /* capacity */ );
            
            cache.Put(2, 1);
            PrintList(cache);
            //cache.Put(2, 2);
            //PrintList(cache);
            cache.Get(1);       // returns 1
            PrintList(cache);
            cache.Put(3, 3);    // evicts key 2
            PrintList(cache);
            cache.Get(2);       // returns -1 (not found)
            cache.Put(4, 4);    // evicts key 1
            PrintList(cache);
            cache.Get(1);       // returns -1 (not found)
            cache.Get(3);       // returns 3
            cache.Get(4);       // returns 4
            //PrintCache(cache);
            //Console.WriteLine("Hello World!");
        }

        static void PrintCache(LRUCache cache){
            foreach(var item in cache.dict){
                Console.WriteLine(item.Value.data);
            }
        }

        static void PrintList(LRUCache cache){
            DLL head = cache.head;
            DLL tail = null;
            while(head != null){
                Console.Write(head.data + ","); 
                head = head.next;
            }

            while(tail != null){
                Console.Write(tail.data + ",");
                tail = tail.prev;
            }

            Console.WriteLine();
        }
    }
}
