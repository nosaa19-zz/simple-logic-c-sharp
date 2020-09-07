using SimpleCode.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCode.Service
{
    public class AdvanceServices
    {
        public String LinkedListShow() 
        {
            /* Start with the empty list */
            LList llist = new LList();

            // Insert 6. So linked list becomes 6->NUllist 
            llist.append(6);

            // Insert 7 at the beginning.  
            // So linked list becomes 7->6->NUllist 
            llist.push(7);

            // Insert 1 at the beginning.  
            // So linked list becomes 1->7->6->NUllist 
            llist.push(1);

            // Insert 4 at the end. So linked list becomes 
            // 1->7->6->4->NUllist 
            llist.append(4);

            // Insert 8, after 7. So linked list becomes 
            // 1->7->8->6->4->NUllist 
            llist.insertAfter(llist.head.next, 8);

            return llist.printList();
        }

        public String AVLShow() {
            AVL tree = new AVL();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.DisplayTree();
            tree.Find(7);
            return null;
        }

        public String SwapByReferenceShow() 
        {
            int a = 100;
            int b = 500;

            Console.WriteLine("Value of a and b before sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            Console.ReadLine();
            return null;
        }

        public String InheritanceCase01() 
        {
            Father f = new Father();
            Child c = new Child();
            f = c as Child;

            c.method01();c.method02();c.method03();
            Console.WriteLine("----------------------------------------------------");
            f.method01();f.method02();f.method03();

            return null;
        }

        /* Private Method Area */
        private void SwapNum(ref int x, ref int y)
        {
            int tempswap = x;
            x = y;
            y = tempswap;
        }
    }
}
