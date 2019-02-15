using System;
using System.Collections.Generic;
namespace lcmedium
{
    /**

void AddWord(String word) a-z
bool SearchWord(String pattern) a-z.

. : any single char

AddWord(hello)
AddWord(tokyo)
SearchWord(hell) -> false
SearchWord(h.ll.) -> true
SearchWord(hell..) -> false

     */
 

    public class Trie
    {

        private Node root = new Node('*');

        public void AddWord(string word)
        {
            try
            {
                Node n = root;
                for (int i = 0; i < word.Length; i++)
                {
                    var child = IsCharPresentInChildern(word[i], n);
                    if (child == null)
                    {
                        Node node = new Node(word[i]);
                        if (i == word.Length - 1)
                            node.IsEndOfWord = true;
                        n.Children.Add(node);
                        n = node;
                    }
                    else
                    {
                        n = child;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool SearchWord(String pattern)
        {
            return SearchWord(pattern, root);
        }


        public bool SearchWord(String pattern, Node n)
        {
            //Console.WriteLine(pattern + "," + n.value);
            //Node n = root;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '.' && i < pattern.Length-1)
                {
                    foreach (var c in n.Children)
                    {
                        if (SearchWord(pattern.Substring(i + 1, pattern.Length - i - 1), c))
                            return true;
                    }
                } else if (pattern[i] == '.' && i == pattern.Length-1){
                    foreach (var c in n.Children)
                    {
                        if (c.IsEndOfWord)
                            return true;
                    } 
                }

                var child = IsCharPresentInChildern(pattern[i], n);

                if (child == null)
                {
                    return false;
                }
                else if (child.IsEndOfWord && i == pattern.Length - 1)
                {
                    return true;
                }
                else
                {
                    n = child;
                }
            }

            return false;
        }

        public Node IsCharPresentInChildern(char c, Node n)
        {
            foreach (var node in n.Children)
            {
                if (node.value == c)
                    return node;
            }

            return null;
        }
    }

    public class Node
    {
        public char value;
        public List<Node> Children;
        public bool IsEndOfWord;

        public Node(char c)
        {
            value = c;
            Children = new List<Node>();
        }
    }
}