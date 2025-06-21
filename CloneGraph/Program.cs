using System.Xml.Linq;
using Graph;
namespace Graph
{
    class Prgram
    {

        static void Main(string[] args)
        {
            //var node1 = new Node(1);
            //var node2 = new Node(2);
            //var node3 = new Node(3);
            //var node4 = new Node(4);

            //node1.neighbors.AddRange(new[] { node2, node4 });
            //node2.neighbors.AddRange(new[] { node1, node3 });
            //node3.neighbors.AddRange(new[] { node2, node4 });
            //node4.neighbors.AddRange(new[] { node1, node3 });

            //// Clone the graph starting from node1
            //var cloned = CloneGraph.GetCloneGraph(node1);


            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            node1.neighbors.Add(node2);
            node1.neighbors.Add(node3);

            node2.neighbors.Add(node1);
            node3.neighbors.Add(node1);

            var cloned = CloneUnConnectedGraph.GetCloneGraph(node1);


            Console.WriteLine("Cloned Node: " + cloned.val);
            Console.WriteLine("Cloned Neighbors: " + string.Join(", ",
                cloned.neighbors.Select(n => n.val)));

        }
    }
}