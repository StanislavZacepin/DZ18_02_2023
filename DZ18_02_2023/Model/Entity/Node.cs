using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ18_02_2023.Model.Entity
{
    public class Node
    {
        public Node next { get; set; }
        public Node prev { get; set; }

        public int value { get; set; }

        public override string ToString()
        {
            return value.ToString();
        }


    }
}
