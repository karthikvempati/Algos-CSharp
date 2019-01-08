using System;
using System.Collections.Generic;
using System.Linq;

namespace Contest118{

public class PowerFullNums
{ 
    public IList<int> PowerfulIntegers(int x, int y, int bound) {
        Dictionary<int, int> d1 = new Dictionary<int,int>();
        Dictionary<int, int> d2 = new Dictionary<int,int>();
        HashSet<int> h = new HashSet<int>();
        int value = 0;
        int i=0;
        while(value < bound){
            value = (int)Math.Pow(x,i);
            d1.Add(++i, value);
        }
        
        value = 0;
        i=0;
        while(value < bound){
            value = (int)Math.Pow(y, i);
            d2.Add(++i, value);
        }
        
        foreach(var v1 in d1.Values){
            foreach(var v2 in d2.Values){
                int val = v1+v2;
                if(!h.Contains(val)){
                    h.Add(val);
                }
            }
        }
        
       List<int> hList= h.ToList();

       return hList;
    } 
}

}