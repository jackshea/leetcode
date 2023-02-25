using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 克隆图
/// https://leetcode-cn.com/problems/clone-graph/
public class P0133_CloneGraph
{
    private readonly Dictionary<Node, Node> visited = new();

    public Node CloneGraph(Node node)
    {
        if (node == null) return null;

        if (visited.ContainsKey(node)) return visited[node];

        var newNode = new Node(node.val);
        visited[node] = newNode;
        foreach (var neighbor in node.neighbors) newNode.neighbors.Add(CloneGraph(neighbor));
        return newNode;
    }

    public class Node
    {
        public IList<Node> neighbors;
        public int val;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}