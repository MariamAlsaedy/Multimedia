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
    public partial class FRLC : Form
    {
        private Rectangle encodeOriginalRect;
        private Rectangle decodeOriginalRect;
        private Rectangle entropyOriginalRect;
        private Rectangle crOriginalRect;
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
        public Point mouseLocation;
        public FRLC()
        {
            InitializeComponent();
        }

        private void FRLC_Load(object sender, EventArgs e)
        {
            IntroOriginalSize = this.Size;

            encodeOriginalRect = new Rectangle(encode.Location.X, encode.Location.Y, encode.Width, encode.Height);
            decodeOriginalRect = new Rectangle(decode.Location.X, decode.Location.Y, decode.Width, decode.Height);
            entropyOriginalRect = new Rectangle(entropy.Location.X, entropy.Location.Y, entropy.Width, entropy.Height);
            crOriginalRect = new Rectangle(CR.Location.X, CR.Location.Y, CR.Width, CR.Height);
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
            resizeControl(encodeOriginalRect, encode);
            resizeControl(decodeOriginalRect, decode);
            resizeControl(entropyOriginalRect, entropy);
            resizeControl(crOriginalRect, CR);
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

        String message;
        String Solution;
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            // Show the output textbox 
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();

            // [*] Read the string that you want to encode
            message = txt1.Text;

            char[] chars = new char[message.Length + 1]; // 2.) prevents falling of edge of array

            // [1] contents of 'message' copied into 'characters' as Char form to mange loop
            int i = 0;
            while (i < message.Length) {
                chars[i] = message[i];
                i++;
            }
            int chCount = 1;
            // [*] prevents falling off edge of array
            int j = 0;
            while (j < chars.Length - 1)
            {

                try
                {
                    // [2] is current element 0 or 'a' compared to 1 which is also 'a' ?
                    if (chars[j] == chars[j + 1])
                    {
                        // [3] as element 0 or 'a' is similar to element 1 or 'a' the count is incremented
                        chCount += 1;
                    }

                    else
                    {
                        // [4] once element 3 or 'a' is compared to element 4 or 'b' the character and its count is outputted
                        p1.Text += chCount.ToString() + chars[j].ToString();
                        chCount = 1;
                        Solution = p1.Text;

                    }

                }
                // [5] try catch loop ensures program does not crash if it falls of characters
                catch (IndexOutOfRangeException exp)
                {
                    MessageBox.Show(exp.StackTrace);
                }

                j++;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            text1.Hide();
            more.Hide();
            text2.Show();
            less.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            text2.Hide();
            less.Hide();
            text1.Show();
            more.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FRLC_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void FRLC_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void FRLC_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            var next = new intro();
            next.Show();
            this.Hide();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public static double log2(double num)
        {
            return Math.Log(num) / Math.Log(2);
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            if (p1.Visible == false)
                p1.Show();
            p1.Clear();
            string In = txt1.Text;
            double infoC = 0;
            Dictionary<char, double> table = new Dictionary<char, double>();


            foreach (char c in In)
            {
                if (table.ContainsKey(c))
                    table[c]++;
                else
                    table.Add(c, 1);

            }
            double freq;
            foreach (KeyValuePair<char, double> letter in table)
            {
                freq = letter.Value / In.Length;
                infoC += freq * log2(freq);
            }
            infoC *= -1;
            p1.Text = "Entropy of " + In.ToString() + " : " + infoC.ToString();
        }

        private void decode_Click(object sender, EventArgs e)
        {
            try
            {

                if (p1.Visible == false)
                    p1.Show();
                p1.Clear();
                message = txt1.Text;
                String S = "";
                int i = 0;
                while (i < message.Length)
                {
                    int num = int.Parse(message[i].ToString());
                    char sympol = message[i + 1];
                    for (int j = 0; j < num; j++)
                    {
                        S += sympol;
                    }
                    i += 2;
                }
                p1.Text = S;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void CR_Click(object sender, EventArgs e)
        {
            try 
            {
                p1.Clear();
                float cr_before = message.Length * 8;
                p1.Text = "Before:" + cr_before.ToString("0.00") + Environment.NewLine;
                float cr_after = ((Solution.Length / 2) * 8) + ((Solution.Length / 2) * 2);
                p1.Text += "After:" + cr_after.ToString("0.00") + Environment.NewLine;
                float cr = (((cr_before - cr_after) / 2) * 8) / cr_before;
                p1.Text += "Compression Ratio: " + cr.ToString("0.00");
            }
            catch (Exception ee)
            { 
                MessageBox.Show(ee.Message.ToString());
            }
        }
    
    }
}
