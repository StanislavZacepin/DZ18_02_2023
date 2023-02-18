using DZ18_02_2023.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ18_02_2023.Model
{
    public class NodeList
    {
        private bool flag = false;

        public Node head { get; set; }
        public Node tail { get; set; }

        public void addNodeFirst(int Value)
        {
            Node node = new Node();
            node.value = Value;
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.prev = head;
                head.next = node;
                head = node;


                /* node.next = head;
                 node.prev = head.prev;
                 head.prev = node;
                */

            }
            head.next = null;
        }

        public void unrollNode(Node node1)
        {
            if (flag == false)
            {
                flag = true;
                head = node1;
            }

            if (node1.next != null)
            {
                head.prev = node1;
                node1 = node1.next;
                unrollNode(node1);
            }
            




        }

    }
}
