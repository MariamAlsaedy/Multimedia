using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multimedia
{
    internal class adapHuff
    {
         Dictionary<char, node> nasib = new Dictionary<char, node>();
        Dictionary<int, Queue<node>> des = new Dictionary<int, Queue<node>>();// FIFO (First In First Out)
        public node teqia = new node();
        public node root = new node();
        public node newbie = new node();
        public adapHuff(char s)
        {
            insertnew(s);
            root = teqia.parent;
        }

        public void insertnew(char c)
        {
            node u;
            if (nasib.ContainsKey(c))
            {
                u = nasib[c];
            }
            else 
            {
                u = new node(teqia, c);
                newbie = u;
                nasib[c] = u;
                teqia.Right = u;
                teqia.Left = new node(teqia);
                teqia = teqia.Left;
            }
            prop(u);

        }

        public void prop(node n)
        {
            node ta;
            if (n.root)
            {
                n.c++;
                return;

            }

            if (des.ContainsKey(n.c) != false && des[n.c].Count != 0 && (!(n == newbie && des[(n.c)].Peek() == n.parent)))
            {
                ta = des[n.c].Dequeue();
                if (des[(n.c)].Count == 0)
                    des.Remove(n.c);
                node newfather = ta.parent;
                swap(ta, n);

                nasib[ta.sympol] = ta;
                nasib[n.sympol] = n;
            }
            else { ta = n; }
            ta.c++;
            Queue<node> q = new Queue<node>();


            if (!des.ContainsKey(ta.c))
            {
                des[ta.c] = q;
            }
            else
            {
                q = des[ta.c];
            }

            if (des.ContainsKey(n.c) != false && des[n.c].Count() != 0 && ((n == newbie && des[n.c].Peek() == n.parent)))
                des.Remove(n.c);

            prop(ta.parent);
            q.Enqueue(ta);
        }

        public void makefather(node father, node son)
        {
            if (son == null)
                return;
            son.parent = father;
        }

        public void swap(node n1, node n2)
        {
            node t = n1.Left;
            n1.Left = n2.Left;
            n2.Left = t;
            t = n1.Right;
            n1.Right = n2.Right;
            n2.Right = t;

            char c = n1.sympol;
            n1.sympol = n2.sympol;
            n2.sympol = c;
            makefather(n1, n1.Left);
            makefather(n1, n1.Right);
            makefather(n2, n2.Right);
            makefather(n2, n2.Left);
        }
    }
}
