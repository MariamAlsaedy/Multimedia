namespace multimedia
{
    partial class FAdaptiveHuffman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdaptiveHuffman));
            this.p2 = new System.Windows.Forms.PictureBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.draw = new ePOSOne.btnProduct.Button_WOC();
            this.entropy = new ePOSOne.btnProduct.Button_WOC();
            this.decode = new ePOSOne.btnProduct.Button_WOC();
            this.back = new ePOSOne.btnProduct.Button_WOC();
            this.less = new ePOSOne.btnProduct.Button_WOC();
            this.more = new ePOSOne.btnProduct.Button_WOC();
            this.encode = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(625, 296);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(13, 15);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 34;
            this.p2.TabStop = false;
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(445, 196);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(401, 22);
            this.txt1.TabIndex = 26;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(197)))), ((int)(((byte)(227)))));
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(185)))));
            this.title.Location = new System.Drawing.Point(10, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(223, 23);
            this.title.TabIndex = 30;
            this.title.Text = "Adaptive Huffman coding";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(197)))), ((int)(((byte)(227)))));
            this.text1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(185)))));
            this.text1.Location = new System.Drawing.Point(12, 82);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(223, 42);
            this.text1.TabIndex = 31;
            this.text1.Text = "It (also called Dynamic Huffman coding)\r\nis an adaptive coding technique based \r\n" +
    "on Huffman coding. ";
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(197)))), ((int)(((byte)(227)))));
            this.text2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(185)))));
            this.text2.Location = new System.Drawing.Point(8, 80);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(247, 112);
            this.text2.TabIndex = 33;
            this.text2.Text = resources.GetString("text2.Text");
            this.text2.Visible = false;
            this.text2.Click += new System.EventHandler(this.text2_Click);
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(0, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(362, 556);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 25;
            this.p3.TabStop = false;
            this.p3.Click += new System.EventHandler(this.p3_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(185)))));
            this.L1.Location = new System.Drawing.Point(545, 160);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(201, 19);
            this.L1.TabIndex = 36;
            this.L1.Text = "   Enter message to encode";
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(445, 229);
            this.p1.Multiline = true;
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(401, 44);
            this.p1.TabIndex = 39;
            this.p1.Visible = false;
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 100);
            this.panel1.TabIndex = 41;
            this.panel1.Visible = false;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(14, 22);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 43;
            this.close.TabStop = false;
            this.close.Visible = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // draw
            // 
            this.draw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.draw.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.draw.FlatAppearance.BorderSize = 0;
            this.draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.ForeColor = System.Drawing.Color.White;
            this.draw.Location = new System.Drawing.Point(361, 273);
            this.draw.Name = "draw";
            this.draw.OnHoverBorderColor = System.Drawing.Color.White;
            this.draw.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.draw.OnHoverTextColor = System.Drawing.Color.White;
            this.draw.Size = new System.Drawing.Size(75, 25);
            this.draw.TabIndex = 42;
            this.draw.Text = "Draw";
            this.draw.TextColor = System.Drawing.Color.White;
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // entropy
            // 
            this.entropy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.entropy.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.entropy.FlatAppearance.BorderSize = 0;
            this.entropy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entropy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropy.ForeColor = System.Drawing.Color.White;
            this.entropy.Location = new System.Drawing.Point(361, 238);
            this.entropy.Name = "entropy";
            this.entropy.OnHoverBorderColor = System.Drawing.Color.White;
            this.entropy.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.entropy.OnHoverTextColor = System.Drawing.Color.White;
            this.entropy.Size = new System.Drawing.Size(75, 25);
            this.entropy.TabIndex = 40;
            this.entropy.Text = "Entropy";
            this.entropy.TextColor = System.Drawing.Color.White;
            this.entropy.UseVisualStyleBackColor = true;
            this.entropy.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // decode
            // 
            this.decode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.decode.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.decode.FlatAppearance.BorderSize = 0;
            this.decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decode.ForeColor = System.Drawing.Color.White;
            this.decode.Location = new System.Drawing.Point(361, 205);
            this.decode.Name = "decode";
            this.decode.OnHoverBorderColor = System.Drawing.Color.White;
            this.decode.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.decode.OnHoverTextColor = System.Drawing.Color.White;
            this.decode.Size = new System.Drawing.Size(75, 25);
            this.decode.TabIndex = 37;
            this.decode.Text = "Decode";
            this.decode.TextColor = System.Drawing.Color.White;
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // back
            // 
            this.back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.back.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(610, 287);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.Color.White;
            this.back.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.Size = new System.Drawing.Size(71, 33);
            this.back.TabIndex = 35;
            this.back.Text = "     Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.TextColor = System.Drawing.Color.White;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // less
            // 
            this.less.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(197)))), ((int)(((byte)(227)))));
            this.less.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.less.ButtonColor = System.Drawing.Color.White;
            this.less.FlatAppearance.BorderSize = 0;
            this.less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.less.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.less.ForeColor = System.Drawing.Color.DarkOrange;
            this.less.Location = new System.Drawing.Point(14, 198);
            this.less.Name = "less";
            this.less.OnHoverBorderColor = System.Drawing.Color.White;
            this.less.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.less.OnHoverTextColor = System.Drawing.Color.White;
            this.less.Size = new System.Drawing.Size(81, 16);
            this.less.TabIndex = 32;
            this.less.Text = "Show less";
            this.less.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(185)))));
            this.less.UseVisualStyleBackColor = false;
            this.less.Visible = false;
            this.less.Click += new System.EventHandler(this.less_Click);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(197)))), ((int)(((byte)(227)))));
            this.more.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.more.ButtonColor = System.Drawing.Color.White;
            this.more.FlatAppearance.BorderSize = 0;
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.ForeColor = System.Drawing.Color.DarkOrange;
            this.more.Location = new System.Drawing.Point(14, 130);
            this.more.Name = "more";
            this.more.OnHoverBorderColor = System.Drawing.Color.White;
            this.more.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.more.OnHoverTextColor = System.Drawing.Color.White;
            this.more.Size = new System.Drawing.Size(81, 16);
            this.more.TabIndex = 29;
            this.more.Text = "Show more";
            this.more.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(95)))), ((int)(((byte)(185)))));
            this.more.UseVisualStyleBackColor = false;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // encode
            // 
            this.encode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.encode.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(117)))), ((int)(((byte)(163)))));
            this.encode.FlatAppearance.BorderSize = 0;
            this.encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encode.ForeColor = System.Drawing.Color.White;
            this.encode.Location = new System.Drawing.Point(361, 172);
            this.encode.Name = "encode";
            this.encode.OnHoverBorderColor = System.Drawing.Color.White;
            this.encode.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.encode.OnHoverTextColor = System.Drawing.Color.White;
            this.encode.Size = new System.Drawing.Size(75, 25);
            this.encode.TabIndex = 27;
            this.encode.Text = "Encode";
            this.encode.TextColor = System.Drawing.Color.White;
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // FAdaptiveHuffman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.more);
            this.Controls.Add(this.less);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.entropy);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.L1);
            this.Name = "FAdaptiveHuffman";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FAdaptiveHuffman_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FAdaptiveHuffman_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FAdaptiveHuffman_MouseMove);
            this.Resize += new System.EventHandler(this.FAdaptiveHuffman_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p2;
        private ePOSOne.btnProduct.Button_WOC back;
        private ePOSOne.btnProduct.Button_WOC less;
        private ePOSOne.btnProduct.Button_WOC more;
        private ePOSOne.btnProduct.Button_WOC encode;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Label L1;
        private ePOSOne.btnProduct.Button_WOC decode;
        private System.Windows.Forms.TextBox p1;
        private ePOSOne.btnProduct.Button_WOC entropy;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC draw;
        private System.Windows.Forms.PictureBox close;
    }
}