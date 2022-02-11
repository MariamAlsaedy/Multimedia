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
    public partial class FHuffman : Form
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
        private Rectangle moreOriginalRect;
        private Rectangle lessOriginalRect;
        private Size IntroOriginalSize;
        public Point MouseLocation;

        public FHuffman()
        {
            InitializeComponent();
        }

        private SolidBrush blackBrush;

        int tNodes = 0, maxTreeHeight = 0;
        TreeNodes Tree = null;
        private Pen blackPen;

        Dictionary<char, int> repetation_chars = new Dictionary<char, int>();

        List<List<string>> Encode_Bits = new List<List<string>>();

        private void more_Click(object sender, EventArgs e)
        {
            text1.Hide();
            more.Hide();
            text2.Show();
            less.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var nextForm = new intro();
            nextForm.Show();
            this.Hide();
        }

        private void less_Click(object sender, EventArgs e)
        {
            text2.Hide();
            less.Hide();
            text1.Show();
            more.Show();
        }

        private void FHuffman_Load(object sender, EventArgs e)
        {
            IntroOriginalSize = this.Size;

            encodeOriginalRect = new Rectangle(draw.Location.X, draw.Location.Y, draw.Width, draw.Height);
            entropyOriginalRect = new Rectangle(entropy.Location.X, entropy.Location.Y, entropy.Width, entropy.Height);
            backOriginalRect = new Rectangle(back.Location.X, back.Location.Y, back.Width, back.Height);
            closeOriginalRect = new Rectangle(close.Location.X, close.Location.Y, close.Width, close.Height);
            tableOriginalRect = new Rectangle(btntable.Location.X, btntable.Location.Y, btntable.Width, btntable.Height);
            panel1OriginalRect = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            p1OriginalRect = new Rectangle(p2.Location.X, p2.Location.Y, p2.Width, p2.Height);
            p2OriginalRect = new Rectangle(p1.Location.X, p1.Location.Y, p1.Width, p1.Height);
            p3OriginalRect = new Rectangle(p3.Location.X, p3.Location.Y, p3.Width, p3.Height);
            txt1riginalRect = new Rectangle(txt1.Location.X, txt1.Location.Y, txt1.Width, txt1.Height);
            labl1OriginalRect = new Rectangle(title.Location.X, title.Location.Y, title.Width, title.Height);
            labl2OriginalRect = new Rectangle(text1.Location.X, text1.Location.Y, text1.Width, text1.Height);
            labl3OriginalRect = new Rectangle(text2.Location.X, text2.Location.Y, text2.Width, text2.Height);
            moreOriginalRect = new Rectangle(more.Location.X, more.Location.Y, more.Width, more.Height);
            lessOriginalRect = new Rectangle(less.Location.X, less.Location.Y, less.Width, less.Height);


           // WindowState = FormWindowState.Maximized;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel1.SizeChanged += new EventHandler(panel1_SizeChanged);
            panel1.Font = new Font("Tahoma", 9.0f, FontStyle.Bold);
            blackPen = new Pen(Color.Black);
            blackBrush = new SolidBrush(Color.DarkGreen);

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
            resizeControl(moreOriginalRect, more);
            resizeControl(lessOriginalRect, less);

        }

        private void FHuffman_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void FHuffman_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void FHuffman_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void p2_Click(object sender, EventArgs e)
        {

        }

        private void p3_Click(object sender, EventArgs e)
        {

        }

        public void temp_draw()
        {
            repetation_chars.Clear();
            if (txt1.Text == "")
            {
                return;
            }
            String code = txt1.Text;

            int i = 0;
            while (i < code.Length)
            {
                if (repetation_chars.ContainsKey(code[i]))
                {
                    repetation_chars[code[i]]++;
                }
                else repetation_chars[code[i]] = 1;
                i++;
            }
            List<Tuple<int, char>> rep = new List<Tuple<int, char>>();

            var arrayOfAllKeys = repetation_chars.Keys.ToArray();
            int a = 0;
            while( a < arrayOfAllKeys.Length)
            {
                Tuple<int, char> t = Tuple.Create(repetation_chars[arrayOfAllKeys[a]], arrayOfAllKeys[a]);

                rep.Add(t);
                a++;
            }
            rep.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            List<TreeNodes> rep_node = new List<TreeNodes>();
            int z = 0;
            while(z < rep.Count)
            {
                TreeNodes temp = new TreeNodes();
                temp.prob = rep[z].Item1;
                temp.sympol = rep[z].Item2.ToString();

                rep_node.Add(temp);
                z++;
            }

            TreeNodes c = new TreeNodes();

            Tree = formTreeForHuffman(rep_node);
            Encode_Bits.Clear();

            List<String> temp1 = new List<string>();
            temp1.Add("Sympol");
            temp1.Add("bits");
            temp1.Add("counter");
            Encode_Bits.Add(temp1);

            calculate_bits(Tree, "");
            int depth = 1;
            tNodes = 0;
            InorderTraversal(Tree, depth); // calculate position of each node 
            maxTreeHeight = TreeHeight(Tree);
        }

        private void encode_Click(object sender, EventArgs e)
        {
            panel1.Show();
            temp_draw();
            panel1.Invalidate();
        }

        private int TreeHeight(TreeNodes t)
        {
            if (t == null) return -1;
            else return 1 + Math.Max(TreeHeight(t.Left), TreeHeight(t.Right));
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

        TreeNodes formTreeForHuffman(List<TreeNodes> list)
        {
            if (list.Count <= 1)
            {
                list[0].sympol = list[0].prob.ToString();
                return list[0];
            }
            if (list.Count == 2)
            {
                TreeNodes node_left = new TreeNodes();
                TreeNodes node_right = new TreeNodes();

                node_left = list[0];
                node_right = list[1];

                TreeNodes final = new TreeNodes();
                final.Left = node_left;
                final.Right = node_right;
                final.prob = node_right.prob + node_left.prob;
                final.sympol = final.prob.ToString();
                return final;
            }

            List<TreeNodes> temp_lest = new List<TreeNodes>();
            temp_lest = list;

            TreeNodes lnode1 = new TreeNodes();
            TreeNodes rnode1 = new TreeNodes();

            lnode1 = list[0];
            rnode1 = list[1];

            TreeNodes left_right = new TreeNodes();
            left_right.Left = lnode1;
            left_right.Right = rnode1;
            left_right.prob = rnode1.prob + lnode1.prob;
            left_right.sympol = left_right.prob.ToString();

            temp_lest.RemoveAt(0);
            temp_lest.RemoveAt(0);

            temp_lest.Add(left_right);
            temp_lest.Sort((x, y) => x.prob.CompareTo(y.prob));


            TreeNodes last_final = new TreeNodes();
            last_final = formTreeForHuffman(temp_lest);

            return last_final;
        }

        public void DTree(TreeNodes root, Graphics d)
        {
            try
            {
                panel1.Width = ClientSize.Width - 20;
                panel1.Height = ClientSize.Height - 20;

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
                    s += "(" + root.prob.ToString() + ")";
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

        public string calculate_bits(TreeNodes root, string code)
        {
            if (root.Left == null && root.Right == null)
            {
                List<String> temp = new List<string>();
                temp.Add(root.sympol);
                temp.Add(code);
                temp.Add(root.prob.ToString());
                Encode_Bits.Add(temp);
                return "";
            }

            calculate_bits(root.Left, code + "0");
            calculate_bits(root.Right, code + "1");


            return "";
        }



        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static double logtwo(double num)
        {
            return Math.Log(num) / Math.Log(2);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();
            string input = txt1.Text;
            double infoC = 0;
            Dictionary<char, double> table = new Dictionary<char, double>();


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
                freq = letter.Value / input.Length;
                infoC += freq * logtwo(freq);
            }
            infoC *= -1;
            p1.Text = "The entropy of " + input.ToString() + " is " + infoC.ToString();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            temp_draw();
            var data  = new table(Encode_Bits);
            data.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Tree != null)
                DTree(Tree, e.Graphics);
        }
    }
}
