using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    public static class Extentions
    {
        public static void Print<T>(this T self) where T : List<int>
        {
            if (self == null) { Console.WriteLine("[]"); }
            else
            {
                Console.WriteLine("[{0}]", string.Join(", ", self));

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 4

                    }
                }
            };
            ListNode list2 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 4

                    }
                }
            };

            Solution solution = new Solution();

            ListNode resultList = solution.MergeTwoLists(list1, list2);
            /*ListNode resultList = solution.MergeTwoLists(null, new ListNode());*/
            List<int> listNodes = new List<int>();

            var tempListNode = resultList;
            if (tempListNode != null)
            {
                while (tempListNode.next != null)
                {
                    listNodes.Add(tempListNode.val);
                    tempListNode = tempListNode.next;
                }
                listNodes.Add(tempListNode.val);
            }
            listNodes.Print();

            Console.ReadLine();
        }



    }

    //Definition for singly-linked list.
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

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            var ListVols = new List<int>();
            ListNode tempListNode = list1;
            if (list1 == null && list2 == null) return null;
            if (list1 != null)
            {
                while (tempListNode.next != null)
                {
                    ListVols.Add(tempListNode.val);
                    tempListNode = tempListNode.next;
                }
                ListVols.Add(tempListNode.val);
            }
            if (list2 != null)
            {
                tempListNode = list2;
                while (tempListNode.next != null)
                {
                    ListVols.Add(tempListNode.val);
                    tempListNode = tempListNode.next;
                }
                ListVols.Add(tempListNode.val);
            }
            ListVols?.Sort();

            ListNode result = null;

            for (int i = ListVols.Count - 1; i >= 0; --i)
            {
                result = new ListNode()
                {
                    val = ListVols[i],
                    next = result
                };

            }

            return result;
        }
    }
}
