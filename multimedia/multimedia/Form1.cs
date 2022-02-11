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
    public partial class intro : Form
    {   
        private Rectangle RLCOriginalRect;
        private Rectangle ShannonOriginalRect;
        private Rectangle HuffmanOriginalRect;
        private Rectangle AdaptiveHuffmanOriginalRect;
        private Rectangle LWZOriginalRect;
        private Rectangle Labl1OriginalRect;
        private Rectangle Labl2OriginalRect;
        private Rectangle Labl3OriginalRect;
        private Rectangle btnOriginalRect;
        private Rectangle btn2OriginalRect;
        private Size IntroOriginalSize;
        public Point mouseLocation;
        public intro()
        {
            InitializeComponent();
        }

        private void intro_Load(object sender, EventArgs e)
        {
            IntroOriginalSize = this.Size;

            RLCOriginalRect = new Rectangle(btnRLC.Location.X, btnRLC.Location.Y, btnRLC.Width, btnRLC.Height);
            ShannonOriginalRect = new Rectangle(btnShannon.Location.X, btnShannon.Location.Y, btnShannon.Width, btnShannon.Height);
            HuffmanOriginalRect = new Rectangle(btnHuffman.Location.X, btnHuffman.Location.Y, btnHuffman.Width, btnHuffman.Height);
            AdaptiveHuffmanOriginalRect = new Rectangle(btnAdaptiveHuffman.Location.X, btnAdaptiveHuffman.Location.Y, btnAdaptiveHuffman.Width, btnAdaptiveHuffman.Height);
            LWZOriginalRect = new Rectangle(btnLWZ.Location.X, btnLWZ.Location.Y, btnLWZ.Width, btnLWZ.Height);
            Labl1OriginalRect = new Rectangle(title.Location.X, title.Location.Y, title.Width, title.Height);
            Labl2OriginalRect = new Rectangle(text.Location.X, text.Location.Y, text.Width, text.Height);
            Labl3OriginalRect = new Rectangle(text2.Location.X, text2.Location.Y, text2.Width, text2.Height);
            btn2OriginalRect = new Rectangle(btn2.Location.X, btn2.Location.Y, btn2.Width, btn2.Height);
            btnOriginalRect = new Rectangle(btn.Location.X, btn.Location.Y, btn.Width, btn.Height);

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
            resizeControl(RLCOriginalRect, btnRLC);
            resizeControl(ShannonOriginalRect, btnShannon);
            resizeControl(HuffmanOriginalRect, btnHuffman);
            resizeControl(AdaptiveHuffmanOriginalRect, btnAdaptiveHuffman);
            resizeControl(LWZOriginalRect, btnLWZ);
            resizeControl(Labl1OriginalRect, title);
            resizeControl(Labl2OriginalRect, text);
            resizeControl(Labl3OriginalRect, text2);
            resizeControl(btnOriginalRect, btn);
            resizeControl(btn2OriginalRect, btn2);
            
        }
        private void RLC_Click(object sender, EventArgs e)
        {
            var next = new FRLC();
            next.Show();
            this.Hide();
        }

        private void Shannon_Click(object sender, EventArgs e)
        {
            var next = new FShannon();
            next.Show();
            this.Hide();
        }

        private void Huffman_Click(object sender, EventArgs e)
        {
            var next = new FHuffman();
            next.Show();
            this.Hide();
        }

        private void AdaptiveHuffman_Click(object sender, EventArgs e)
        {
            var next = new FAdaptiveHuffman();
            next.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLWZ_Click(object sender, EventArgs e)
        {
            var next = new FLZW();
            next.Show();
            this.Hide();
        }

        private void intro_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void intro_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void intro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            text2.Hide();
            btn2.Hide();
            text.Show();
            btn.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            text.Hide();
            btn.Hide();
            text2.Show();
            btn2.Show();
        }

        private void text2_Click(object sender, EventArgs e)
        {

        }
    }
}
