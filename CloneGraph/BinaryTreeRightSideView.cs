using System;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Graph
{
	public static class BinaryTreeRightSideView
    {
        //Given the root of a binary tree, imagine standing on the right side of it.
        //Return the values of the nodes you can see ordered from top to bottom.

        // Input
        // TreeNode root: 이진 트리의 루트 노드
        // Output
        // List<int>: 오른쪽에서 볼 수 있는 노드 값들을 위에서 아래로 나열한 리스트



        //Input:
        //       1
        //     /   \
        //    2     3 
        //     \     \
        //      4     5

          //   1        ← level 0
          //  /
          // 2        ← level 1
          //  \
          //   5      ← level 2ㅣ

        //Output: [1, 3, 4]

        public static List<int> GetResult(TreeNode root)
        {
            List<int> result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root); // 2

            // work through queue
            while(queue.Count > 0)
            {
                // level of the tree - count
                var treeLevelElementCount = queue.Count;
                for(int i = 0; i < treeLevelElementCount; i++)
                {
                    TreeNode current = queue.Dequeue();
                    // last node of that level
                    if (i == treeLevelElementCount - 1)
                    {
                        // store on the result
                        result.Add(current.val);
                    }
                }
                if(root.left != null)
                {
                    // add to the queue
                    queue.Enqueue(root.left);
                }
                if (root.right != null)
                {
                    // add to the queue
                    queue.Enqueue(root.right); 
                }
            }
            return result;
        }
        
	}
}

