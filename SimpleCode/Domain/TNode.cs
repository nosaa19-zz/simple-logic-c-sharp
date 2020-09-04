using System;
using System.Collections.Generic;
using System.Text;

namespace simple_code.Domain
{
    public class TNode
    {
        public int data;
        public TNode left;
        public TNode right;

        public TNode(int d)
        {
            data = d;
            left = null;
            right = null;
        }
    }
}
