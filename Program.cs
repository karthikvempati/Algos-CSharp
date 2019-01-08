using System;
using LRUCacheNS;
using Graphs;
using LinkedLists;
using System.Collections.Generic;
using System.Linq;

namespace algoscsharp
{ 
    class Program
    {

        public static string LongestPalindrome(string s) {
            if(s.Length < 2)
            return s;
            string result = "";

            for(int i=0;i < s.Length-1-result.Length;i++){
                for(int j=i+1;j <= s.Length;j++){
                    int len = j-i;
                    if(len < result.Length)
                        continue;
                    var cs = s.Substring(i, len);
                    if(IsPalindrome(cs)){
                        if(len > result.Length){
                            result = cs;
                        }
                    }
                }
            }

            return result;
        }
    
        public static bool IsPalindrome(string s){
            for(int i=0,j=s.Length-1;i<=j;i++,j--){
                if(s[i] != s[j])
                    return false;
            }
            
            return true;
        }
 
        static void Main(string[] args)
        {  
            string[] strArray = new string[]{"","a","aa","ababbaab",
            "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth"
            ,"ibvjkmpyzsifuxcabqqpahjdeuzaybqsrsmbfplxycsafogotliyvhxjtkrbzqxlyfwujzhkdafhebvsdhkkdbhlhmaoxmbkqiwiusngkbdhlvxdyvnjrzvxmukvdfobzlmvnbnilnsyrgoygfdzjlymhprcpxsnxpcafctikxxybcusgjwmfklkffehbvlhvxfiddznwumxosomfbgxoruoqrhezgsgidgcfzbtdftjxeahriirqgxbhicoxavquhbkaomrroghdnfkknyigsluqebaqrtcwgmlnvmxoagisdmsokeznjsnwpxygjjptvyjjkbmkxvlivinmpnpxgmmorkasebngirckqcawgevljplkkgextudqaodwqmfljljhrujoerycoojwwgtklypicgkyaboqjfivbeqdlonxeidgxsyzugkntoevwfuxovazcyayvwbcqswzhytlmtmrtwpikgacnpkbwgfmpavzyjoxughwhvlsxsgttbcyrlkaarngeoaldsdtjncivhcfsaohmdhgbwkuemcembmlwbwquxfaiukoqvzmgoeppieztdacvwngbkcxknbytvztodbfnjhbtwpjlzuajnlzfmmujhcggpdcwdquutdiubgcvnxvgspmfumeqrofewynizvynavjzkbpkuxxvkjujectdyfwygnfsukvzflcuxxzvxzravzznpxttduajhbsyiywpqunnarabcroljwcbdydagachbobkcvudkoddldaucwruobfylfhyvjuynjrosxczgjwudpxaqwnboxgxybnngxxhibesiaxkicinikzzmonftqkcudlzfzutplbycejmkpxcygsafzkgudy",
            "jglknendplocymmvwtoxvebkekzfdhykknufqdkntnqvgfbahsljkobhbxkvyictzkqjqydczuxjkgecdyhixdttxfqmgksrkyvopwprsgoszftuhawflzjyuyrujrxluhzjvbflxgcovilthvuihzttzithnsqbdxtafxrfrblulsakrahulwthhbjcslceewxfxtavljpimaqqlcbrdgtgjryjytgxljxtravwdlnrrauxplempnbfeusgtqzjtzshwieutxdytlrrqvyemlyzolhbkzhyfyttevqnfvmpqjngcnazmaagwihxrhmcibyfkccyrqwnzlzqeuenhwlzhbxqxerfifzncimwqsfatudjihtumrtjtggzleovihifxufvwqeimbxvzlxwcsknksogsbwwdlwulnetdysvsfkonggeedtshxqkgbhoscjgpiel"};
            
            string[] result = new string[]{"","a","aa","baab", "ranynar","",""};

            for(int i=0;i<result.Length;i++){
                longestpalindromestring.Solution s = new longestpalindromestring.Solution();
                var res = s.LongestPalindrome(strArray[i]);
                Console.WriteLine(res + "," + result[i]);
            }
            #region OldCode
            /*

            Contest118.PowerFullNums pn = new Contest118.PowerFullNums();
            PrintList(pn.PowerfulIntegers(1,3,12));

          
            CourseSchedule.Graph g = new CourseSchedule.Graph(4);
            int[,] preReqs = new int[,]{{1,0},{2,0},{3,1},{3,2}};

            for(int i = 0; i < preReqs.GetLength(0); i++){     
                g.AddEdge(preReqs[i,1], preReqs[i,0]);
            }

            var list = g.TopSort(); 

            PrintList(list);

            
            string s = LongestPalindrome("cyyoacmjwjubfkzrrbvquqkwhsxvmytmjvbborrtoiyotobzjmohpadfrvmxuagbdczsjuekjrmcwyaovpiogspbslcppxojgbfxhtsxmecgqjfuvahzpgprscjwwutwoiksegfreortttdotgxbfkisyakejihfjnrdngkwjxeituomuhmeiesctywhryqtjimwjadhhymydlsmcpycfdzrjhstxddvoqprrjufvihjcsoseltpyuaywgiocfodtylluuikkqkbrdxgjhrqiselmwnpdzdmpsvbfimnoulayqgdiavdgeiilayrafxlgxxtoqskmtixhbyjikfmsmxwribfzeffccczwdwukubopsoxliagenzwkbiveiajfirzvngverrbcwqmryvckvhpiioccmaqoxgmbwenyeyhzhliusupmrgmrcvwmdnniipvztmtklihobbekkgeopgwipihadswbqhzyxqsdgekazdtnamwzbitwfwezhhqznipalmomanbyezapgpxtjhudlcsfqondoiojkqadacnhcgwkhaxmttfebqelkjfigglxjfqegxpcawhpihrxydprdgavxjygfhgpcylpvsfcizkfbqzdnmxdgsjcekvrhesykldgptbeasktkasyuevtxrcrxmiylrlclocldmiwhuizhuaiophykxskufgjbmcmzpogpmyerzovzhqusxzrjcwgsdpcienkizutedcwrmowwolekockvyukyvmeidhjvbkoortjbemevrsquwnjoaikhbkycvvcscyamffbjyvkqkyeavtlkxyrrnsmqohyyqxzgtjdavgwpsgpjhqzttukynonbnnkuqfxgaatpilrrxhcqhfyyextrvqzktcrtrsbimuokxqtsbfkrgoiznhiysfhzspkpvrhtewthpbafmzgchqpgfsuiddjkhnwchpleibavgmuivfiorpteflholmnxdwewj");
            Console.WriteLine(s);
            DfsGraph.Graph g = new DfsGraph.Graph(5);
            int[,] preReqs = new int[,]{{0,1},{1,2},{2,3},{1,3},{1,4}};

            for(int i = 0; i < preReqs.GetLength(0); i++){     
                g.AddEdge(preReqs[i,0], preReqs[i,1]);
            }

            bool[] visited = g.DfsGraph();
            Console.WriteLine(visited.Where(a => a == false).Count() == 0);
            bool cycle = g.DfsGraphCycle(); 
            Console.WriteLine(cycle);

             foreach (var item in g.DfsGraph())
            {
                Console.Write(item + ",");
            }*/
            /* var node = CreateLinkedList(1);
            //PrintRandomListNode(node);
            var sol = new LinkedListsSolution();
            //PrintTwoRandomListNode(node,sol.CopyRandomList(node));
            PrintTwoRandomListNode(node,sol.CopyRandomList(node)); */                       
            
            /* Solution s = new Solution();
            int[,] i = new int[,]{{1,0}};
            s.CourseSchedule(2, i);

            DfsGraph.Graph g = new DfsGraph.Graph(7);
            int[,] preReqs = new int[,]{{0,1},{0,2},{0,3},{1,4},{4,5},{5,6},{4,6}};

            for(int i = 0; i < preReqs.GetLength(0); i++){     
                g.AddEdge(preReqs[i,0], preReqs[i,1]);
            }

            foreach (var item in g.DfsGraph())
            {
                Console.Write(item + ",");
            }
            */
            //LRUCacheNS.LRUCache cache = new LRUCacheNS.LRUCache( 1 /* capacity */ );
            
            //cache.Put(2, 1);
            //PrintList(cache);
            //cache.Put(2, 2);
            //PrintList(cache);
            //cache.Get(1);       // returns 1
            //PrintList(cache);
            //cache.Put(3, 3);    // evicts key 2
            //PrintList(cache);
            ///cache.Get(2);       // returns -1 (not found)
            //cache.Put(4, 4);    // evicts key 1
            //PrintList(cache);
            //cache.Get(1);       // returns -1 (not found)
            //cache.Get(3);       // returns 3
            //cache.Get(4);       // returns 4
            //PrintCache(cache);
            //Console.WriteLine("Hello World!");
            #endregion
        }

        static void PrintCache(LRUCache cache){
            foreach(var item in cache.dict){
                Console.WriteLine(item.Value.data);
            }
        }

        static void PrintRandomListNode(RandomListNode head){
            while(head != null){
                Console.WriteLine("head value --> " + head.label);
                if(head.next != null){
                    Console.WriteLine("--> next value --> " + head.next.label);
                }
                if(head.random != null){
                    Console.WriteLine("--> random value -->" + head.random.label);
                }
                head = head.next;
            }
        }

        
        static void PrintTwoRandomListNode(RandomListNode head1, RandomListNode head2){
            while(head1 != null && head2 != null){
                Console.WriteLine("head value --> " + head1.label);
                Console.WriteLine("head value --> " + head2.label);                
                if(head1.next != null && head2.next != null){
                    Console.WriteLine("--> next value --> " + head1.next.label);
                    Console.WriteLine("--> next value --> " + head2.next.label);                    
                }
                if(head1.random != null && head2.random != null){
                    Console.WriteLine("--> random value -->" + head1.random.label);
                    Console.WriteLine("--> random value -->" + head2.random.label);
                }
                head1 = head1.next;
                head2 = head2.next;
            }
        }

        static RandomListNode CreateLinkedList(int length){
            int len = length;
            var head = new RandomListNode(0);
            var temp = head; 
            List<RandomListNode> list = new List<RandomListNode>();
            list.Add(temp);
            for(int i=1;i<=len;i++){
                temp.next = new RandomListNode(i);
                list.Add(temp.next);
                temp = temp.next;
            } 

            temp = head;

            while(temp != null){
                Random r = new Random();
                int i = r.Next(0,len);
                temp.random = list[i];
                temp = temp.next;
            }

            return head;
        }

        static void PrintLinkedList(LRUCache cache){
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

        static void PrintList(IList<int> list){
            foreach (var item in list)
            {
                Console.WriteLine(item + ',');
            }
        }
    }
}
