using System.ComponentModel;

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
public class LeetCode2415
{
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        List<TreeNode> initialList = new List<TreeNode>();
        initialList.Add(root);
        TraverseTree(initialList, 0);
        return root;
    }

    public void TraverseTree(List<TreeNode> nodesOfLevel, int modLevel)
    {
        if (nodesOfLevel.Count == 0)
        {
            return;
        }
        if (modLevel == 1)
        {
            SwitchValues(nodesOfLevel);
        }
        TraverseTree(GenerateNextLevel(nodesOfLevel), modLevel == 0 ? 1 : 0);
    }

    public void SwitchValues(List<TreeNode> nodesOfLevel)
    {
        int n = nodesOfLevel.Count;
        for (int i = 0; i < n / 2; i++)
        {
            int tempVal;
            tempVal = nodesOfLevel[i].val;
            nodesOfLevel[i].val = nodesOfLevel[nodesOfLevel.Count - i - 1].val;
            nodesOfLevel[nodesOfLevel.Count - i - 1].val = tempVal;
        }
    }

    public List<TreeNode> GenerateNextLevel(List<TreeNode> nodesOfLevel)
    {
        List<TreeNode> returnedNodes = new List<TreeNode>();

        foreach (TreeNode node in nodesOfLevel)
        {
            if (node.left != null)
            {
                returnedNodes.Add(node.left);
            }
            if (node.right != null)
            {
                returnedNodes.Add(node.right);
            }
        }
        return returnedNodes;
    }
}