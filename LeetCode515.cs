using System;
using System.ComponentModel;
using System.Text;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class LeetCode515
    {
        public IList<int> LargestValues(TreeNode root)
        {
            List<int> output = new List<int>();

            if (root is null)
            {
                return output;
            }
            output.Add(root.val);
            List<TreeNode> starterRow = new List<TreeNode>();
            starterRow.Add(root);
            TransverseTree(starterRow, output);

            return output;
        }

        public void TransverseTree(List<TreeNode> currentLevel, List<int> maxes)
        {
            if (currentLevel.Count == 0)
            {
                return;
            }
            TransverseTree(GenerateNextLevel(currentLevel, maxes), maxes);

            return;
        }

        public List<TreeNode> GenerateNextLevel(List<TreeNode> currentLevel, List<int> maxes)
        {
            List<TreeNode> nextLevel = new List<TreeNode>();

            int? max = null;

            foreach (TreeNode node in currentLevel)
            {
                if (node.left is not null)
                {
                    if (max is null || node.left.val > max)
                    {
                        max = node.left.val;
                    }
                    nextLevel.Add(node.left);
                }
                if (node.right is not null)
                {
                    if (max is null || node.right.val > max)
                    {
                        max = node.right.val;
                    }
                    nextLevel.Add(node.right);
                }
            }
            if (max is not null)
            {
                maxes.Add((int)max);
            }
            return nextLevel;
        }
    }
}
