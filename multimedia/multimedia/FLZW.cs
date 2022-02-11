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
    public partial class FLZW : Form
    {
        private Rectangle encodeOriginalRect;
        private Rectangle decodeOriginalRect;
        private Rectangle entropyOriginalRect;
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
        public FLZW()
        {
            InitializeComponent();
        }

        private void FLWZ_Load(object sender, EventArgs e)
        {
            IntroOriginalSize = this.Size;

            encodeOriginalRect = new Rectangle(Compress1.Location.X, Compress1.Location.Y, Compress1.Width, Compress1.Height);
            decodeOriginalRect = new Rectangle(Incompress.Location.X, Incompress.Location.Y, Incompress.Width, Incompress.Height);
            entropyOriginalRect = new Rectangle(entropy.Location.X, entropy.Location.Y, entropy.Width, entropy.Height);
            backOriginalRect = new Rectangle(back.Location.X, back.Location.Y, back.Width, back.Height);
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
            resizeControl(encodeOriginalRect, Compress1);
            resizeControl(decodeOriginalRect, Incompress);
            resizeControl(entropyOriginalRect, entropy);
            resizeControl(backOriginalRect, back);
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

        private void FLWZ_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void FLWZ_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void FLWZ_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void text2_Click(object sender, EventArgs e)
        {

        }

        private void text1_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        List<String> outs = new List<string>();
        Dictionary<string, int> dic = new Dictionary<string, int>();

        private void encode_Click(object sender, EventArgs e)
        {
            // Show the output textbox 
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();

            if (txt1.Text == "")
            {
                return;
            }
            outs.Clear();
            dic.Clear();

            // add charachter to the Dictionary
            int x = 1;

            int y = 0;
            while ( y < txt1.Text.Length)
            {
                if (!dic.ContainsKey(txt1.Text[y].ToString()))
                {
                    dic[txt1.Text[y].ToString()] = x;
                    x++;
                }
                y++;
            }

            string prefix = dic.ElementAt(0).Key;
            int codeword = x;
            int z = 1;
            while(z < txt1.Text.Length)
            {
                char _char = txt1.Text[z];
                string prefix_char = "";
                prefix_char += prefix;
                prefix_char += _char;
                if (dic.ContainsKey(prefix_char))
                {
                    prefix = prefix + _char.ToString();
                }
                else
                {
                    outs.Add(dic[prefix].ToString());
                    p1.Text += dic[prefix].ToString() + "|";   //output
                    dic[prefix_char] = codeword;
                    codeword++;
                    prefix = _char.ToString();
                }
                z++;
            }
            outs.Add(dic[prefix].ToString());
            p1.Text += dic[prefix].ToString() + "|";   //output

        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void decode_Click(object sender, EventArgs e)
        {
            // Show the output textbox 
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();

            int PreviousCodeWord = int.Parse(outs[0]);
            p1.Text = "";
            Dictionary<string, int> dic1 = new Dictionary<string, int>();
            int x = 1;
            int w = 0;
            while (w < txt1.Text.Length)
            {
                if (!dic1.ContainsKey(txt1.Text[w].ToString()))
                {
                    dic1[txt1.Text[w].ToString()] = x;
                    x++;
                }
                w++;
            }


            String myKey = dic1.FirstOrDefault(a => a.Value == int.Parse(outs[0])).Key;

            p1.Text += myKey;

            String _char = outs[0];

            String _string = "";
            int CodeWord = x;

            int i = 1;
            while (i < outs.Count)
            {
                int CurrentCodeWord = int.Parse(outs[i]);
                String thekey = dic1.FirstOrDefault(a => a.Value == int.Parse(outs[i])).Key;

                if (thekey != null) // if exist in dictionary
                {
                    _string = thekey;
                }
                else
                {
                    thekey = dic1.FirstOrDefault(a => a.Value == PreviousCodeWord).Key + _char; // string(previous_code)+char
                    _string = thekey;
                }
                p1.Text += _string;
                _char = _string[0].ToString();
                thekey = dic1.FirstOrDefault(a => a.Value == PreviousCodeWord).Key + _char; // string(previous_code) + char

                dic1[thekey] = CodeWord;

                PreviousCodeWord = CurrentCodeWord;
                CodeWord++;
                i++;
            }
        }

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_Click(object sender, EventArgs e)
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
            p1.Text = "Entropy of " + input.ToString() + " : " + infoC.ToString();
        }
    }
}
