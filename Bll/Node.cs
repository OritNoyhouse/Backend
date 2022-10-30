using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bll
{
    public class Node
    {
        public int Value { get; set; }
        public Node[] ChildNodes { get; set; }
        public bool Selected { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

