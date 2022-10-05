using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm14
{
    public class BinaryTree
    {
        int value;
        BinaryTree left;
        BinaryTree right;

        public BinaryTree(List<int> values) : this(values, 0) { }

        BinaryTree(List<int> values, int index)
        {
            Load(this, values, index);
        }

        void Load(BinaryTree tree, List<int> values, int index)
        {
            this.value = values[index];
            if (index * 2 + 1 < values.Count)
            {
                this.left = new BinaryTree(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Count)
            {
                this.right = new BinaryTree(values, index * 2 + 2);
            }
        }

        public void PrintInDepth(BinaryTree r, int depth)
        {
            if (r == null) return;
            PrintInDepth(r.right, depth + 1);
            for (int i = 0; i < depth; i++)
            {
                Console.Write("    ");
            }
            Console.WriteLine(r.value);
            PrintInDepth(r.left, depth + 1);
        }

        
    }
}
