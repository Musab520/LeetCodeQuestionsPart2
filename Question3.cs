using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPart2
{
     internal class Question3
    {
      
 
 public class ListNode
        {
     public int val;
     public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
                     }
}
        public static void Main()
        {
            ListNode node7 = new ListNode(7,null);
            ListNode node6 = new ListNode(7,node7);
            ListNode node5 = new ListNode(7,node6);
            ListNode node4 = new ListNode(7,node5);
            ListNode node3 = new ListNode(7,node4);
            ListNode node2 = new ListNode(7,node3);
            ListNode node1=new ListNode(7,node2);
            node1=RemoveElements(node1,7);
            while (node1 != null)
            {
                Console.WriteLine(node1.val);
                node1=node1.next;
            }
        }
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head != null)
            {
                ListNode curr = head;
                ListNode prev = null;
                if (curr.next == null)
                {
                    return curr.val!=val ? curr:null;
                }
                while (curr != null)
                {
                    if (curr.val == val)
                    {
                        if (prev != null)
                        {
                            prev.next = curr.next;
                            curr = prev;
                        }
                        else
                        {
                            head = curr.next;
                            curr = curr.next;
                            continue;
                        }

                    }
                    prev = curr;
                    curr = curr.next;
                }
    
            }
            return head;
        }
    }
}
