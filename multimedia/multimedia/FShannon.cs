using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multimedia
{
    public partial class FShannon : Form
    {
        private Rectangle encodeOriginalRect;
        private Rectangle entropyOriginalRect;
        private Rectangle backOriginalRect;
        private Rectangle closeOriginalRect;
        private Rectangle panel1OriginalRect;
        private Rectangle tableOriginalRect;
        private Rectangle p1OriginalRect;
        private Rectangle p2OriginalRect;
        private Rectangle p3OriginalRect;
        private Rectangle txt1riginalRect;
        private Rectangle labl1OriginalRect;
        private Rectangle labl2OriginalRect;
        private Rectangle labl3OriginalRect;
        private Rectangle labl4OriginalRect;
        private Rectangle moreOriginalRect;
        private Rectangle lessOriginalRect;
        private Size IntroOriginalSize;
        public Point MouseLocation;

        private SolidBrush blackBrush;
        int tNodes = 0, maxTreeHeight = 0;
        TreeNodes Tree = null;
        private Pen blackPen;
        Dictionary<char, int> repetChar = new Dictionary<char, int>();  //to store freq and char
        List<List<String>> encodeBits = new List<List<string>>();      //linked list definition

        public FShannon()
        {
            InitializeComponent();
        }

        private void less_Click(object sender, EventArgs e)
        {
            text2.Hide();
            less.Hide();
            text1.Show();
            more.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var nextForm = new intro();
            nextForm.Show();
            this.Hide();
        }

        private void more_Click(object sender, EventArgs e)
        {
            text1.Hide();
            more.Hide();
            text2.Show();
            less.Show();
        }

        private void FShannon_Load(object sender, EventArgs e)
        {
            IntroOriginalSize = this.Size;

            encodeOriginalRect = new Rectangle(draw.Location.X, draw.Location.Y, draw.Width, draw.Height);
            entropyOriginalRect = new Rectangle(entropy.Location.X, entropy.Location.Y, entropy.Width, entropy.Height);
            backOriginalRect = new Rectangle(back.Location.X, back.Location.Y, back.Width, back.Height);
            closeOriginalRect = new Rectangle(close.Location.X, close.Location.Y, close.Width, close.Height);
            tableOriginalRect = new Rectangle(btntable.Location.X, btntable.Location.Y, btntable.Width, btntable.Height);
            panel1OriginalRect = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            p1OriginalRect = new Rectangle(p2.Location.X, p2.Location.Y, p2.Width, p2.Height);
            p1OriginalRect = new Rectangle(p2.Location.X, p2.Location.Y, p2.Width, p2.Height);
            p2OriginalRect = new Rectangle(p1.Location.X, p1.Location.Y, p1.Width, p1.Height);
            p3OriginalRect = new Rectangle(p3.Location.X, p3.Location.Y, p3.Width, p3.Height);
            txt1riginalRect = new Rectangle(txt1.Location.X, txt1.Location.Y, txt1.Width, txt1.Height);
            labl1OriginalRect = new Rectangle(title.Location.X, title.Location.Y, title.Width, title.Height);
            labl2OriginalRect = new Rectangle(text1.Location.X, text1.Location.Y, text1.Width, text1.Height);
            labl3OriginalRect = new Rectangle(text2.Location.X, text2.Location.Y, text2.Width, text2.Height);
            labl4OriginalRect = new Rectangle(L1.Location.X, L1.Location.Y, L1.Width, L1.Height);
            moreOriginalRect = new Rectangle(more.Location.X, more.Location.Y, more.Width, more.Height);
            lessOriginalRect = new Rectangle(less.Location.X, less.Location.Y, less.Width, less.Height);

           // WindowState = FormWindowState.Maximized;
            panel1.Paint += new PaintEventHandler(panel1_Paint);  //to draw at the panel
            panel1.SizeChanged += new EventHandler(panel1_SizeChanged); //handle size panel
            panel1.Font = new Font("Tahoma", 9.0f, FontStyle.Bold);
            blackPen = new Pen(Color.Black);
            blackBrush = new SolidBrush(Color.DarkRed);
        }
        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)this.Width / (float)(IntroOriginalSize.Width);
            float yRatio = (float)this.Height / (float)(IntroOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
        private void resizeChildrenControls()
        {
            resizeControl(encodeOriginalRect, draw);
            resizeControl(entropyOriginalRect, entropy);
            resizeControl(backOriginalRect, back);
            resizeControl(closeOriginalRect, close);
            resizeControl(tableOriginalRect, btntable);
            resizeControl(panel1OriginalRect, panel1);
            resizeControl(p1OriginalRect, p2);
            resizeControl(p2OriginalRect, p1);
            resizeControl(p3OriginalRect, p3);
            resizeControl(txt1riginalRect, txt1);
            resizeControl(labl1OriginalRect, title);
            resizeControl(labl2OriginalRect, text1);
            resizeControl(labl3OriginalRect, text2);
            resizeControl(labl4OriginalRect, L1);
            resizeControl(moreOriginalRect, more);
            resizeControl(lessOriginalRect, less);

        }

        private void FShannon_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void FShannon_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void FShannon_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        public static double log2(double num)
        {
            return Math.Log(num) / Math.Log(2);
        }

        private void encode_Click(object sender, EventArgs e)
        {
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();
            string input = txt1.Text;
            double infoC = 0; //freq
            Dictionary<char, double> table = new Dictionary<char, double>();  //stream of symbols and 0 and ones


            foreach (char c in input)
            {
                if (table.ContainsKey(c))
                    table[c]++;
                else
                    table.Add(c, 1);

            }

            double freq;
            foreach (KeyValuePair<char, double> letter in table)
            {
                freq = letter.Value / input.Length;  //get prop
                infoC += freq * log2(freq);   //calc entropy
            }
            infoC *= -1;
            p1.Text = "Entropy of " + input.ToString() + " : " + infoC.ToString();
        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        public void temp_draw()
        {
            repetChar.Clear();
            if (txt1.Text == "")
            {
                return;
            }
            String code = txt1.Text;

            int i = 0;
            while(i < code.Length)
            {
                if (repetChar.ContainsKey(code[i]))
                {
                    repetChar[code[i]]++;
                }
                else repetChar[code[i]] = 1;
                i++;
            }
            List<Tuple<int, char>> rep = new List<Tuple<int, char>>();

            var arrayOfAllKeys = repetChar.Keys.ToArray();

            int a = 0;
            while(a < arrayOfAllKeys.Length)
            {
                Tuple<int, char> t = Tuple.Create(repetChar[arrayOfAllKeys[a]], arrayOfAllKeys[a]);

                rep.Add(t);
                a++;
            }
            rep.Sort((x, y) => y.Item1.CompareTo(x.Item1));
            TreeNodes c = new TreeNodes();

            Tree = formTree(rep);

            encodeBits.Clear();

            List<String> temp1 = new List<string>();
            temp1.Add("Sympol");
            temp1.Add("bits");
            temp1.Add("counter");
            encodeBits.Add(temp1);

            calcBits(Tree, "");


            int depth = 1;   //the leaves defult 1
            tNodes = 0;
            InorderTraversal(Tree, depth);
            maxTreeHeight = TreeHeight(Tree);
            rename_nodes(Tree);
            set_prob(Tree);
        }

        private void draw_Click(object sender, EventArgs e)
        {
            panel1.Show();
            temp_draw();
            panel1.Invalidate();
        }
     
        private void InorderTraversal(TreeNodes t, int depth)
        {
            if (t != null)
            {
                InorderTraversal(t.Left, depth + 1); //add 1 to depth (y coordinate) 
                t.Xpos = tNodes++ + 1; //x coord is node number in inorder traversal
                t.Ypos = depth - 1; // mark y coord as depth
                InorderTraversal(t.Right, depth + 1);
            }
        }


        public void DTree(TreeNodes root, Graphics d)
        {
            try
            {
                panel1.Width = ClientSize.Width - 8;
                panel1.Height = ClientSize.Height - 8;

                int Width = panel1.Width;
                int Height = panel1.Height;
                int dx = 0, dy = 0, dx2 = 0, dy2 = 0, ys = 20;
                int Xscale, Yscale;
                int treeHeight = TreeHeight(root);

                Xscale = (int)(Width / tNodes); //scale x by total nodes in tree
                Yscale = (int)((Height - ys) / (maxTreeHeight + 1)); //scale y by tree height

                if (root != null)
                {
                    // inorder traversal to draw each node
                    DTree(root.Left, d); // do left side of inorder traversal 
                    dx = root.Xpos * Xscale; // get x,y coords., and scale them 
                    dy = root.Ypos * Yscale;
                    string s = root.sympol.ToString(); //get the word at this node
                    d.DrawString(s, panel1.Font, blackBrush, new PointF(dx - ys, dy));

                    // this draws the lines from a node to its children, if any
                    if (root.Left != null)
                    {
                        //draws the line to left child if it exists
                        dx2 = root.Left.Xpos * Xscale;
                        dy2 = root.Left.Ypos * Yscale;
                        d.DrawLine(blackPen, dx, dy, dx2, dy2);
                    }

                    if (root.Right != null)
                    {
                        //draws the line to right child if it exists
                        dx2 = root.Right.Xpos * Xscale;//get right child x,y scaled position
                        dy2 = root.Right.Ypos * Yscale;
                        d.DrawLine(blackPen, dx, dy, dx2, dy2);
                    }

                    DTree(root.Right, d); //now do right side of inorder traversal 
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }


        public String rename_nodes(TreeNodes tree)
        {
            if (tree == null) return "";
            if (tree.Left == null && tree.Right == null)
                return tree.sympol;

            String rname = rename_nodes(tree.Right);
            String lname = rename_nodes(tree.Left);

            if (tree.sympol == "#")
            {
                tree.sympol = rname + " , " + lname;
            }
            return tree.sympol;
        }

        public int set_prob(TreeNodes tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else if (tree.Left == null && tree.Right == null)
            {
                tree.prob = 1;
                return 1;
            }
            int left = set_prob(tree.Left);
            int right = set_prob(tree.Right);

            tree.prob = left + right;
            Tree = tree;
            return 1;
        }

        public string calcBits(TreeNodes root, string code)
        {
            if (root.Left == null && root.Right == null)
            {
                List<String> temp = new List<string>();
                temp.Add(root.sympol);
                temp.Add(code);
                temp.Add(root.prob.ToString());
                encodeBits.Add(temp);
                return "";
            }

            calcBits(root.Left, code + "0");
            calcBits(root.Right, code + "1");


            return "";
        }
        private int TreeHeight(TreeNodes t)
        {
            if (t == null) return -1;
            else return 1 + Math.Max(TreeHeight(t.Left), TreeHeight(t.Right));
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
          panel1.Invalidate();  //to resize the panel draw 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Tree != null)
              DTree(Tree, e.Graphics);  // Graphics defult draw
        }

        private void btntable_Click(object sender, EventArgs e)
        {
            temp_draw();
            table data = new table(encodeBits);
            data.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        TreeNodes formTree(List<Tuple<int, char>> list)
        {
            if (list.Count <= 1)
            {
                TreeNodes r = new TreeNodes();
                r.Left = null;
                r.Right = null;
                r.sympol = list[0].Item2.ToString();
                return r; //repition of nodes
            }

            List<Tuple<int, char>> tempList = new List<Tuple<int, char>>();
            int sympolsCount = 0;
            tempList = list;

            int y = 0;
            while(y < tempList.Count)
            {
                sympolsCount += tempList[y].Item1;
                y++;
            }
            List<Tuple<int, char>> rlist = new List<Tuple<int, char>>();
            List<Tuple<int, char>> llist = new List<Tuple<int, char>>();

            int sumToHalf = 0;
            int i = 0;
            while(i < tempList.Count)
            {
                if (sumToHalf < sympolsCount / 2)
                {
                    rlist.Add(tempList[i]);
                    sumToHalf += tempList[i].Item1;
                }
                else
                {
                    llist.Add(tempList[i]);
                }

                i++;
            }
            TreeNodes rnode = new TreeNodes();
            TreeNodes lnode = new TreeNodes();

            rnode = formTree(rlist);
            lnode = formTree(llist);

            rnode.bit = "1";
            lnode.bit = "0";

            TreeNodes n = new TreeNodes();
            n.Left = lnode;
            n.Right = rnode;
            return n;
        }
    }
}
