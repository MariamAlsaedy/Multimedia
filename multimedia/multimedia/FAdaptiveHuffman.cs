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
    public partial class FAdaptiveHuffman : Form
    {
        private Rectangle encodeOriginalRect;
        private Rectangle decodeOriginalRect;
        private Rectangle entropyOriginalRect;
        private Rectangle closeOriginalRect;
        private Rectangle panel1OriginalRect;
        private Rectangle drawOriginalRect;
        private Rectangle backOriginalRect;
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
        public FAdaptiveHuffman()
        {
            InitializeComponent();
        }

        private void p3_Click(object sender, EventArgs e)
        {

        }
        adapHuff ad = null;
        int tNodes = 0, maxTreeHeight = 0;
        node Tree = null;
        private Pen blackPen;
        private SolidBrush blackBrush;
        Dictionary<string, node> char_connect_node = new Dictionary<string, node>();

        private void FAdaptiveHuffman_Load(object sender, EventArgs e)
        {
            IntroOriginalSize = this.Size;

            encodeOriginalRect = new Rectangle(encode.Location.X, encode.Location.Y, encode.Width, encode.Height);
            decodeOriginalRect = new Rectangle(decode.Location.X, decode.Location.Y, decode.Width, decode.Height);
            drawOriginalRect = new Rectangle(draw.Location.X, draw.Location.Y, draw.Width, draw.Height);
            entropyOriginalRect = new Rectangle(entropy.Location.X, entropy.Location.Y, entropy.Width, entropy.Height);
            backOriginalRect = new Rectangle(back.Location.X, back.Location.Y, back.Width, back.Height);
            closeOriginalRect = new Rectangle(close.Location.X, close.Location.Y, close.Width, close.Height);
            panel1OriginalRect = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
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

            //WindowState = FormWindowState.Maximized;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel1.SizeChanged += new EventHandler(panel1_SizeChanged);
            panel1.Font = new Font("Tahoma", 9.0f, FontStyle.Bold);
            blackPen = new Pen(Color.Black);
            blackBrush = new SolidBrush(Color.DarkViolet);
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
            resizeControl(encodeOriginalRect, encode);
            resizeControl(decodeOriginalRect, decode);
            resizeControl(entropyOriginalRect, entropy);
            resizeControl(backOriginalRect, back);
            resizeControl(closeOriginalRect, close);
            resizeControl(panel1OriginalRect, panel1);
            resizeControl(drawOriginalRect, draw);
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

        private void back_Click(object sender, EventArgs e)
        {
            var nextForm = new intro();
            nextForm.Show();
            this.Hide();
        }

        private void text1_Click(object sender, EventArgs e)
        {

        }

        private void more_Click(object sender, EventArgs e)
        {
            text1.Hide();
            more.Hide();
            text2.Show();
            less.Show();
        }

        private void less_Click(object sender, EventArgs e)
        {
            text2.Hide();
            less.Hide();
            text1.Show();
            more.Show();
        }

        private void FAdaptiveHuffman_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void FAdaptiveHuffman_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void FAdaptiveHuffman_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void text2_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        string encoded;
        private void encode_Click(object sender, EventArgs e)
        {
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();

            string a = txt1.Text;
            var tree = new HuffTree();
            encoded = tree.Encode(a);
            p1.Text = "The encoded string: " + encoded.ToString() + Environment.NewLine;
        }

        private void decode_Click(object sender, EventArgs e)
        {
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();

            var tree = new HuffTree();
            string decoded = tree.Decode(encoded);
            p1.Text = "The decoded string: " + decoded.ToString();
        }

        private void p1_TextChanged(object sender, EventArgs e)
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

        private void InorderTraversal(node t, int depth)
        {
            if (t != null)
            {
                InorderTraversal(t.Left, depth + 1); //add 1 to depth (y coordinate) 
                t.Xpos = tNodes++ + 1; //x coord is node number in inorder traversal
                t.Ypos = depth - 1; // mark y coord as depth
                InorderTraversal(t.Right, depth + 1);
            }
        }

        private int TreeHeight(node t)
        {
            if (t == null) return -1;
            else return 1 + Math.Max(TreeHeight(t.Left), TreeHeight(t.Right));
        }

        public void DTree(node root, Graphics d)
        {
            try
            {
                panel1.Width = ClientSize.Width - 50;
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
                    string s = root.sympol.ToString() + "(" + root.c.ToString() + ")"; //get the word at this node
                    d.DrawString(s, panel1.Font, blackBrush, new PointF(dx - ys - 30, dy));
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
        private void draw_Click(object sender, EventArgs e)
        {
            close.Show();
            panel1.Show();

            int i = 0;
            while (i < txt1.TextLength)
            {
                if (ad == null)
                    ad = new adapHuff(txt1.Text[i]);
                else
                    ad.insertnew(txt1.Text[i]);
                int depth = 1;
                tNodes = 0;
                Tree = ad.root;
                InorderTraversal(Tree, depth);
                maxTreeHeight = TreeHeight(Tree);
                panel1.Invalidate();
                i++;
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            close.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (Tree != null)
                DTree(Tree, e.Graphics);
        }
    }
}
