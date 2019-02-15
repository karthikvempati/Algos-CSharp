using System;
using LRUCacheNS;
using Graphs;
using LinkedLists;
using System.Collections.Generic;
using System.Linq;
using lcmedium;
using lceasy;

namespace algoscsharp
{
    class Program
    {

        public static string LongestPalindrome(string s)
        {
            if (s.Length < 2)
                return s;
            string result = "";

            for (int i = 0; i < s.Length - 1 - result.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    int len = j - i;
                    if (len < result.Length)
                        continue;
                    var cs = s.Substring(i, len);
                    if (IsPalindrome(cs))
                    {
                        if (len > result.Length)
                        {
                            result = cs;
                        }
                    }
                }
            }

            return result;
        }

        public static bool IsPalindrome(string s)
        {
            for (int i = 0, j = s.Length - 1; i <= j; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        { 
            SortArrayParity sortArrayParity = new SortArrayParity();
            int[][] A = new int[][]{new int[]{3,1,2,4},new int[]{2}, new int[]{}, new int[]{3,1}};

            foreach(var a in A){
                PrintArray(sortArrayParity.SortArrayByParity(a));
            }  
        }

        static void PrintArray(int[] A){
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ",");
            }
            Console.WriteLine();
        }

        static void OldCode(){
            #region commentBTLex
            /*
            Contest122.IntervalListIntersection I = new Contest122.IntervalListIntersection();
            int[][] a = new int[][]{new int[]{0,2}, new int[]{5,10},new int[]{13,23},new int[]{24,25}};
            int[][] b = new int[][]{new int[]{1,5}, new int[]{8,12},new int[]{15,24},new int[]{25,26}};
            Contest122.Interval[] A = new Contest122.Interval[4];
            Contest122.Interval[] B = new Contest122.Interval[4];
            for (int i = 0; i < a.Length; i++)
            {
                A[i] = new Contest122.Interval(a[i][0], a[i][1]);
                B[i] = new Contest122.Interval(b[i][0], b[i][1]);                
            }
            I.IntervalIntersection(A,B);
            
                 if(root == null){
            return null;
        }
        StringBuilder sb = new StringBuilder();
        string result = string.Empty;
        string c = string.Empty;
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
        while(s.Count > 0){
            var node = s.Pop();
            sb.Append((char) (node.val + 97))
            
            if(node.left == null && node.right == null){  
                c = sb.ToString();
                result = CompareString(result, c.Reverse());
                sb.Remove(c.Length - 1, 1);
            }
            
            if(node.right != null)
                s.Push(node.right);
            
            if(node.left != null)
                s.Push(node.left);
        }
        
        return result;
            */
            #endregion
            #region OldCode
            /*
            Contest123.BrokenCalculator b = new Contest123.BrokenCalculator();
            int[] x = new int[] {2,5,3,1024,1};
            int[] y = new int[] {3,8,10,1,1000000000};
            for (int i = 0; i < x.Length; i++){
                Console.WriteLine(b.BrokenCalc(x[i],y[i]));
            }  
            Contest122.SumOfEvenNumbers s = new Contest122.SumOfEvenNumbers();
            s.SumEvenAfterQueries(new int[]{0,0,0,0},new int[][]{new int[]{1,0}, new int[]{-3,1} ,new int[]{-4,0} ,new int[]{2,3}});
            
            lcmedium.IntegerReplacementCount ic = new IntegerReplacementCount();
            ic.IntegerReplacement(int.MaxValue);
            
            //lcmedium.ThreeSumSolution t = new lcmedium.ThreeSumSolution();
            //int[] nums = new int[] {-1, 0, 1, 2, -1, -4};

            //var result = t.ThreeSum(nums);
            Trie trie = new Trie();
            trie.AddWord("hello"); 
            trie.AddWord("tokyo");
            Console.WriteLine(trie.SearchWord("hell"));
            Console.WriteLine(trie.SearchWord("h.ll."));
            Console.WriteLine(trie.SearchWord("hell.."));
            Console.WriteLine(trie.SearchWord("h.llo"));
           
            lcmedium.zigzagconversion z = new lcmedium.zigzagconversion();
            
            string[] s = new string[]{"PAYPALISHIRING"};
            int[] rows = new int[]{1};
            string[] r = new string[]{"PAHNAPLSIIGYIR"};

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(z.Convert(s[i],rows[i]) + " , " + r[i]);
            }

            
            TripleByte.TicTacToe ttt = new TripleByte.TicTacToe();
            ttt.AddToken(0,1,'X');
            ttt.MakeAMoveAI();
            ttt.PrintBoard();


            
            lcmedium.ReverseString reverseString = new lcmedium.ReverseString();

            string s = reverseString.ReverseWords("   a   b ");

            Console.WriteLine(s);

            int[] nums = new int[]{91,34,56,76,78};
            bool[] results = new bool[]{true,false,false,false,false,true};

            for (int i=0; i< nums.Length;i++){

                lceasy.HappyNumber h = new lceasy.HappyNumber();
                Console.WriteLine(h.IsHappy(nums[i]) + "," + results[i]);
            }



            int[] dividends = new int[]{7, -7, -7, 7,1,-2147483648, 2147483647, -2147483648, -2147483648};
            int[] divisors = new int[]{2, -2,  2, -2,1, 1, 1, -1, -2147483648};
            int[] results = new int[]{3,3,-3,-3,1,-2147483648,2147483647,2147483647, 1 };

            for (int i=0; i< dividends.Length;i++){

                int dividend = dividends[i];
                int divisor = divisors[i];

                lcmedium.DivideNoMulti d = new lcmedium.DivideNoMulti();
                Console.WriteLine(d.Divide(dividend, divisor) + "," + results[i]);
            }
          
            var board = new char[,]{
                {'C','A','A'}, {'A','A','A'}, {'B','C','D'}
            };

            MockInterviews.WordSearch2DArray ws = new MockInterviews.WordSearch2DArray();
            string[] s = new string[]{"AAB","ABCCED","SEE","ABCB","ABC","ADF","SCF"};
            bool[] results = new bool[]{true, true,true,false,true,true,true};
            
            for (int i = 0; i < s.Length; i++)
            { 
                Console.WriteLine(ws.Exist(board, s[i]) + "," + results[i]);  
            } 
              
            
            Arrays.NeedleInHayStack n = new Arrays.NeedleInHayStack(); 
            string[] hayStacks = new string[]{"mississippi","hello","aaaaa","aa","ababbaab", "a",""};
            string[] needles = new string[]{"issip","ll","a","bba","baab","aaaa",""};
            int[] results = new int[]{4,2,0,-1,4,-1,0};

            for (int i = 0; i < hayStacks.Length; i++)
            {
                Console.WriteLine(n.StrStr(hayStacks[i], needles[i])==results[i]);    
            }
            
            
            Contest119.KClosestSum kc = new Contest119.KClosestSum();
            int[][] a = new int[2][];
            a[0] = new int[]{1,3};
            a[1] = new int[]{-2,2};
            kc.KClosest(a, 1);
            
            dp.PaintHouse ph = new dp.PaintHouse();
            int[,] costs = new int[,]{{17,2,17},{16,16,5},{ 14,3,19}};
            Console.WriteLine(ph.Paint(costs));

            
            dp.HouseRobber hr = new dp.HouseRobber();
            int[] houses = new int[]{2,7,9,3,1};
            Console.WriteLine(hr.Rob(houses));

            
            var nums = new int[]{-2,1,-3,4,4,2,1,-5,4 };
            dp.MaxSubArrayClass m = new dp.MaxSubArrayClass();
            Console.WriteLine(m.MaxSubArray(nums));
           
            ZigZagString z = new ZigZagString();
            var a = z.Convert("PAYPALISHIRING",4);
            //PrintZigZag(a);
           
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

        static void PrintZigZag(char[,] a)
        {
            for (int i = 0, j = 0; i < a.GetLength(0) && j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
                if (j == a.GetLength(1) - 1)
                {
                    Console.WriteLine();
                    i++;
                    j = -1;
                }
            }
        }

        static void PrintCache(LRUCache cache)
        {
            foreach (var item in cache.dict)
            {
                Console.WriteLine(item.Value.data);
            }
        }

        static void PrintRandomListNode(RandomListNode head)
        {
            while (head != null)
            {
                Console.WriteLine("head value --> " + head.label);
                if (head.next != null)
                {
                    Console.WriteLine("--> next value --> " + head.next.label);
                }
                if (head.random != null)
                {
                    Console.WriteLine("--> random value -->" + head.random.label);
                }
                head = head.next;
            }
        }


        static void PrintTwoRandomListNode(RandomListNode head1, RandomListNode head2)
        {
            while (head1 != null && head2 != null)
            {
                Console.WriteLine("head value --> " + head1.label);
                Console.WriteLine("head value --> " + head2.label);
                if (head1.next != null && head2.next != null)
                {
                    Console.WriteLine("--> next value --> " + head1.next.label);
                    Console.WriteLine("--> next value --> " + head2.next.label);
                }
                if (head1.random != null && head2.random != null)
                {
                    Console.WriteLine("--> random value -->" + head1.random.label);
                    Console.WriteLine("--> random value -->" + head2.random.label);
                }
                head1 = head1.next;
                head2 = head2.next;
            }
        }

        static RandomListNode CreateLinkedList(int length)
        {
            int len = length;
            var head = new RandomListNode(0);
            var temp = head;
            List<RandomListNode> list = new List<RandomListNode>();
            list.Add(temp);
            for (int i = 1; i <= len; i++)
            {
                temp.next = new RandomListNode(i);
                list.Add(temp.next);
                temp = temp.next;
            }

            temp = head;

            while (temp != null)
            {
                Random r = new Random();
                int i = r.Next(0, len);
                temp.random = list[i];
                temp = temp.next;
            }

            return head;
        }

        static void PrintLinkedList(LRUCache cache)
        {
            DLL head = cache.head;
            DLL tail = null;
            while (head != null)
            {
                Console.Write(head.data + ",");
                head = head.next;
            }

            while (tail != null)
            {
                Console.Write(tail.data + ",");
                tail = tail.prev;
            }

            Console.WriteLine();
        }

        static void PrintList(IList<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item + ',');
            }
        }
    }
}
