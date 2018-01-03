using ImageEncryptCompress;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ImageQuantization
{
    public class HuffmanTree
    {

        public FrequencyGenerator Frequencies { get; set; }
        public PriorityQueue<Node> RedTree;
        public PriorityQueue<Node> GreenTree;
        public PriorityQueue<Node> BlueTree;
        public Node RedRoot { get; set; }
        public Node GreenRoot { get; set; }
        public Node BlueRoot { get; set; }
        public Dictionary<byte,List<bool>> RedEncodings { get; set; }
        public Dictionary<byte,List<bool>> GreenEncodings { get; set; }
        public Dictionary<byte,List<bool>> BlueEncodings { get; set; }

        public Dictionary<List<bool>, byte> ReverseRedEncodings { get; set; }
        public Dictionary<List<bool>, byte> ReverseGreenEncodings { get; set; }
        public Dictionary<List<bool>, byte> ReverseBlueEncodings { get; set; }

        //public Dictionary<int, byte> IntReverseRedEncodings { get; set; }
        //public Dictionary<int, byte> IntReverseGreenEncodings { get; set; }
        //public Dictionary<int, byte> IntReverseBlueEncodings { get; set; }

        public Dictionary<string, byte> IntReverseRedEncodings { get; set; }
        public Dictionary<string, byte> IntReverseGreenEncodings { get; set; }
        public Dictionary<string, byte> IntReverseBlueEncodings { get; set; }

        public string RedTreeString;
        public string GreenTreeString;
        public string BlueTreeString;

        //TOTAL:O(1)
        public HuffmanTree(FrequencyGenerator FG) //O(1)
        {
            Frequencies = FG; //O(1)
            RedTree = new PriorityQueue<Node>(); //O(1)
            GreenTree = new PriorityQueue<Node>(); //O(1)
            BlueTree = new PriorityQueue<Node>(); //O(1)
            RedEncodings = new Dictionary<byte, List<bool>>(); // O(1)
            GreenEncodings = new Dictionary<byte, List<bool>>(); //O(1)
            BlueEncodings = new Dictionary<byte, List<bool>>(); // O(1)
            RedRoot = new Node(); // O(1)
            GreenRoot = new Node(); // O(1)
            BlueRoot = new Node(); //O(1)
            ReverseRedEncodings = new Dictionary<List<bool>, byte>(); //O(1)
            ReverseGreenEncodings = new Dictionary<List<bool>, byte>(); //O(1)
            ReverseBlueEncodings = new Dictionary<List<bool>, byte>(); //O(1)
        }

        //TOTAL:O(L log L )
        public void ConstructTree()
        {
            RedRoot = ConstructColor(Frequencies.RedFrequencies, RedTree); // O(L log L)
            GreenRoot = ConstructColor(Frequencies.GreenFrequencies, GreenTree); // O(L log L)
            BlueRoot = ConstructColor(Frequencies.BlueFrequencies, BlueTree); //O (L log L)
            GenerateEncodings(RedRoot, new List<bool>(), RedEncodings,ReverseRedEncodings); //O(1)
            GenerateEncodings(GreenRoot, new List<bool>(), GreenEncodings,ReverseGreenEncodings); //O(1)
            GenerateEncodings(BlueRoot,  new List<bool>(), BlueEncodings,ReverseBlueEncodings); //O(1)
        }

        // TOTAL : O( l log l)
        private Node ConstructColor(int[] colorFrequency, PriorityQueue<Node> colorTree)
        {
            for(int i = 0;i<256;i++) //O(log L)
            { 
                if(colorFrequency[i]!=0)
                    colorTree.Enqueue(new Node { ColorNumber = i, Frequency = colorFrequency[i] }); // O(log L)
            }

            while (colorTree.Count > 1) // O( l log l) #iterations N/2
            {
                // Total : O ( Log l)
                Node n1 = colorTree.Dequeue(); //log l
                Node n2 = colorTree.Dequeue(); //log l
                var n3 = new Node { Left = n2, Right = n1, Frequency = n1.Frequency + n2.Frequency }; // O(1)
                n1.Parent = n3; // O(1)
                n2.Parent = n3; // O(1)
                colorTree.Enqueue(n3); // O(log l)
            }

            Node node = new Node(); // O(1)
            node = colorTree.Peek(); // O(1)
            return node; // O(1)
        }

        // O(n) worst case


        //TOTAL :O(1)
        private void GenerateEncodings(Node node, List<bool> path, Dictionary<byte, List<bool>> dictionary , Dictionary<List<bool>,byte> reverseDictionary)
        {
            if (node != null || path.Count==0) //O(1)
            {
                if (node.Left == null && node.Right == null) //found a leaf node   //O(1)
                {
                    dictionary.Add((byte)node.ColorNumber, new List<bool>(path)); //O(1)
                    reverseDictionary.Add(new List<bool>(path), (byte)node.ColorNumber); //O(1)
                }
                if (node.Left != null) //O(1)
                {
                    List<bool> newPath = new List<bool>(path);//O(1)
                    newPath.Add(false); //O(1)
                    GenerateEncodings(node.Left, newPath, dictionary,reverseDictionary); //O(1)
                }

                if (node.Right != null) //O(1)
                {
                    List<bool> newPath = new List<bool>(path); //O(1)
                    newPath.Add(true);  //O(1)
                    GenerateEncodings(node.Right, newPath, dictionary,reverseDictionary); //O(1)
                }


            }
        }

        public void GenerateAnotherEncodings() 
        {
            IntReverseBlueEncodings = new Dictionary<string, byte>(); 
            IntReverseGreenEncodings = new Dictionary<string, byte>(); 
            IntReverseRedEncodings = new Dictionary<string, byte>(); 

            foreach (var entry in ReverseRedEncodings)
            {
                StringBuilder sb = new StringBuilder(); 
                for (int i = 0; i < entry.Key.Count; i++)
                {
                    if (entry.Key[i]) sb.Append('1');
                    else
                        sb.Append('0');
                }

                IntReverseRedEncodings.Add(sb.ToString(), entry.Value);
            }

            foreach (var entry in ReverseGreenEncodings)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < entry.Key.Count; i++)
                {
                    if (entry.Key[i]) sb.Append('1');
                    else
                        sb.Append('0');
                }

                IntReverseGreenEncodings.Add(sb.ToString(), entry.Value);
            }

            foreach (var entry in ReverseBlueEncodings)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < entry.Key.Count; i++)
                {
                    if (entry.Key[i]) sb.Append('1');
                    else
                        sb.Append('0');
                }

                IntReverseBlueEncodings.Add(sb.ToString(), entry.Value);
            }
        }

        /*public int ReverseTraverse(List<bool> path , Node node)
        {
            while(path.Count>0)
            {
                    if (path[0])
                    {
                        path.RemoveAt(0);
                        node = node.Right;
                    }
                    else
                    {
                        path.RemoveAt(0);
                        node = node.Left;
                    }

                if (node.Left == null && node.Right == null) { return (byte)node.ColorNumber; }

            }
            return -1;
        }*/

        #region GUI Functions

        // For GUI PURPOSE TO SHOW TREE AS GUI
        public void GetStringRepresentation()
        {
            Traverse(RedRoot, 0, "", ref RedTreeString);
            Traverse(GreenRoot, 0, "", ref GreenTreeString);
            Traverse(BlueRoot, 0, "", ref BlueTreeString);
        }

        //Fills the text representation of the tree
        private void Traverse(Node node, int level ,string encoding , ref string treeString)
        {
            if (node != null)
            {
                for (int i = 0; i < level; i++)
                    treeString += "   ";
                for (int i = 0; i < level; i++)
                    treeString += "-";

                if (node.Left == null && node.Right == null) //found a leaf node
                    treeString += node.ColorNumber + " : " + encoding+"\n";

                else
                    treeString += node.Frequency + "\n";

                if (node.Left != null)
                    Traverse(node.Left, level + 1,encoding+"0",ref treeString);

                if (node.Right != null)
                    Traverse(node.Right, level + 1,encoding+"1",ref treeString);
            }
        }
        #endregion
    }


}
