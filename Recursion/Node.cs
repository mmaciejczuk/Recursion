using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Node
    {
        public Node()
        {

        }

        public string Name { get; set; }
        public int Value { get; set; }
        IList<Node> ChildNodes { get; set; }

        private Node populateNodes()
        {
            Node node = new Node();
            List<Node> NodesList = new List<Node>();
            node.Name = "firstNode";
            node.Value = new Random().Next();
            for (int i = 0; i < 10; i ++)
            {
                NodesList.Add(new Node
                {
                    Name = "child" + i,
                    Value = i,
                    ChildNodes = null
                });
            }

            node.ChildNodes = NodesList;

            return node;
        }
    }
}
