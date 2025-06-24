using System;
using System.Xml.Linq;

namespace Graph
{
    public static class CourseDetection
    {
        //You are given numCourses and a list of prerequisites,
        //where prerequisites[i] = [a, b] means:
        //to take course a, you must have taken course b first.
        //Return true if it’s possible to finish all courses,
        //otherwise false.

        //Input:
        //numCourses = 4

        //prerequisites = [[1,0],[2,1],[3,2]]

        //🔹 Output:
        //true
        //→ You can take: 0 → 1 → 2 → 3

        // directed cycle

        public static bool GetResult(int[][] input, int numCourses)
        {
            if (input == null) return false;

            // build node graph
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            // node
            for (int i = 0; i < numCourses; i++)
                nodes[i] = new Node(i);

            // neighbors
            foreach (int[] pair in input)
            {
                int dest = pair[0];
                int src = pair[1];

                nodes[src].neighbors.Add(nodes[dest]); // directed
            }

            // 2. use visited status
            Dictionary<Node, int> visited = new Dictionary<Node, int>();
            foreach (Node node in nodes.Values)
                visited[node] = 0;

            //DFS
            foreach (Node node in nodes.Values)
            {
                if (visited[node] == 0 && HasCycleNode(node, visited))
                    return false;
            }

            return true;
        }
        // visited value =  {0, not visited} {1, visiting} {2, visited} 

        public static bool HasCycleNode(Node node, Dictionary<Node, int> visited)
        {
            if (visited[node] == 1) return true;  // cycle
            if (visited[node] == 2) return false; // already done

            visited[node] = 1; // mark visiting
            foreach (var neighbor in node.neighbors)
            {
                if (HasCycleNode(neighbor, visited))
                    return true;
            }
            visited[node] = 2; // mark done
            return false;
        }
    }
}

