namespace ValidateBinarySearchTree;

public class Solution
{
    /**
     *@param {TreeNode} root
    * @return {bool}
    */

    public bool IsValidBST(TreeNode root)
    {
        return DFS(root, long.MinValue, long.MaxValue);
    }

    private bool DFS(TreeNode node, long minValue, long maxValue)
    {
        if (node == null) return true;
        if (node.val <= minValue || node.val >= maxValue) return false;
        return DFS(node.left, minValue, node.val) && DFS(node.right, node.val, maxValue);
    }
}

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