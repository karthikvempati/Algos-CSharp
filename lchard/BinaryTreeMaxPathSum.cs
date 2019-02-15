using System;

namespace lchard {

    public class BinaryTreeMaxPathSum
    {
        public int MaxPathSum(TreeNode root){
            return 0;
        }

        public int MaxPathSum(TreeNode node, int leftpathsum, int rightpathsum, int maxsum){
            return 0;
        }
    }

    public class TreeNode
    {
        public int val { get; set; }    

        public TreeNode left { get; set; }  

        public TreeNode right { get; set; }

        public TreeNode(int value){
            this.val = value;
        }
    }
}