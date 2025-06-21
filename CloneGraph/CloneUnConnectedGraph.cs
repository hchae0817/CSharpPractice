using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Graph
{
	public static class CloneUnConnectedGraph
    {
        //Clone Graph

        // let’s use a simpler structure without a cycle so you can clearly see how
        // the graph is built and what the clone should look like.

        //Example Input:
        //A graph like:
        //  1
        // / \
        //2   3

        //Expected Output: New graph with same structure but entirely new node objects.

        public static Node GetCloneGraph(Node node)
        {
           if(node == null) { return new Node(); }
            var visited = new Dictionary<Node, Node>();
            var result = Traverse(node, visited); // val: 1, neighbor: 2,3
            return result;
        }

        
        public static Node Traverse(Node node, Dictionary<Node, Node> visited)
        {
            if (visited.ContainsKey(node))
            {
                return visited[node]; // included existing node with its neighbor
            }

            // clone
            var clone = new Node(node.val);
            visited[node] = clone;

            foreach(var neighbor in node.neighbors)
            {
                var neighborTrack = Traverse(neighbor, visited);
                clone.neighbors.Add(neighborTrack);
            }

            return clone;
        }
	}
}

