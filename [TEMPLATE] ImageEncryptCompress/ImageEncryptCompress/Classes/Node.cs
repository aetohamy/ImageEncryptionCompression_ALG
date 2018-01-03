using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageQuantization
{
    public class Node : IComparable
    {
        public Node Parent { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int ColorNumber { get; set; }
        public int Frequency { get; set; }

        //TOTAL : O(1)
        public int CompareTo(object obj)
        {
            Node node = (Node)obj; //O(1)
            if (this.Frequency < node.Frequency) //O(1)
                return -1;  //O(1)
            if (this.Frequency == node.Frequency) //O(1)
                return 0; //O(1)
            else
                return 1; //O(1)

        }
    }
}
