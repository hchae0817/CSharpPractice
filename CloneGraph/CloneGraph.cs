using System;
namespace Graph
{
	public static class CloneGraph
	{
        //Clone Graph
        //Given a reference of a node in a connected undirected graph, return a deep copy(clone) of the graph.

        //Example Input:
        //A graph like:

        //1 -- 2
        //|    |
        //4 -- 3

        //Expected Output: New graph with same structure but entirely new node objects.

        public static Node GetCloneGraph(Node node)
        {
            if (node == null) return new Node();
            // not to repeat same nope // node1
            Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
            Node result = DFS(node, visited);

            return result;
        }

        public static Node DFS(Node node, Dictionary<Node, Node> visited)
        {

            if (visited.ContainsKey(node))
                return visited[node];

            var clone = new Node(node.val);
            visited[node] = clone;

            foreach (var neighbar in node.neighbors)
            {
                clone.neighbors.Add(DFS(neighbar, visited));
            }
            return clone;
        }
        
	}
}

