namespace multimedia
{
    partial class FShannon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FShannon));
            this.p2 = new System.Windows.Forms.PictureBox();
            this.text2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.draw = new ePOSOne.btnProduct.Button_WOC();
            this.back = new ePOSOne.btnProduct.Button_WOC();
            this.less = new ePOSOne.btnProduct.Button_WOC();
            this.more = new ePOSOne.btnProduct.Button_WOC();
            this.entropy = new ePOSOne.btnProduct.Button_WOC();
            this.btntable = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(619, 278);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(13, 15);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 23;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.text2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.DarkRed;
            this.text2.Location = new System.Drawing.Point(10, 84);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(270, 112);
            this.text2.TabIndex = 20;
            this.text2.Text = resources.GetString("text2.Text");
            this.text2.Visible = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkRed;
            this.title.Location = new System.Drawing.Point(9, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(218, 23);
            this.title.TabIndex = 19;
            this.title.Text = "Shannon Fano Algorithm";
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(438, 201);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(401, 22);
            this.txt1.TabIndex = 15;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.text1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.DarkRed;
            this.text1.Location = new System.Drawing.Point(7, 86);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(225, 28);
            this.text1.TabIndex = 22;
            this.text1.Text = "It is an entropy encoding technique for\r\nlossless data compression of multimedia." +
    "\r\n";
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(-1, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(362, 556);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 14;
            this.p3.TabStop = false;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.DarkRed;
            this.L1.Location = new System.Drawing.Point(497, 162);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(283, 19);
            this.L1.TabIndex = 38;
            this.L1.Text = "Enter message to calculate the Entropy\r\n";
            this.L1.Click += new System.EventHandler(this.L1_Click);
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.Location = new System.Drawing.Point(438, 235);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(401, 20);
            this.p1.TabIndex = 39;
            this.p1.Visible = false;
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.close);
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
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(10, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 44;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // draw
            // 
            this.draw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.draw.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.draw.FlatAppearance.BorderSize = 0;
            this.draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.ForeColor = System.Drawing.Color.White;
            this.draw.Location = new System.Drawing.Point(357, 187);
            this.draw.Name = "draw";
            this.draw.OnHoverBorderColor = System.Drawing.Color.White;
            this.draw.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.draw.OnHoverTextColor = System.Drawing.Color.White;
            this.draw.Size = new System.Drawing.Size(75, 25);
            this.draw.TabIndex = 40;
            this.draw.Text = "Draw";
            this.draw.TextColor = System.Drawing.Color.White;
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // back
            // 
            this.back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.back.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(603, 269);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.Color.White;
            this.back.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.Size = new System.Drawing.Size(71, 33);
            this.back.TabIndex = 24;
            this.back.Text = "     Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.TextColor = System.Drawing.Color.White;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // less
            // 
            this.less.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.less.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.less.ButtonColor = System.Drawing.Color.White;
            this.less.FlatAppearance.BorderSize = 0;
            this.less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.less.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.less.ForeColor = System.Drawing.Color.DarkOrange;
            this.less.Location = new System.Drawing.Point(9, 206);
            this.less.Name = "less";
            this.less.OnHoverBorderColor = System.Drawing.Color.White;
            this.less.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.less.OnHoverTextColor = System.Drawing.Color.White;
            this.less.Size = new System.Drawing.Size(81, 16);
            this.less.TabIndex = 21;
            this.less.Text = "Show less";
            this.less.TextColor = System.Drawing.Color.DarkRed;
            this.less.UseVisualStyleBackColor = false;
            this.less.Visible = false;
            this.less.Click += new System.EventHandler(this.less_Click);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.more.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.more.ButtonColor = System.Drawing.Color.White;
            this.more.FlatAppearance.BorderSize = 0;
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.ForeColor = System.Drawing.Color.DarkOrange;
            this.more.Location = new System.Drawing.Point(9, 125);
            this.more.Name = "more";
            this.more.OnHoverBorderColor = System.Drawing.Color.White;
            this.more.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.more.OnHoverTextColor = System.Drawing.Color.White;
            this.more.Size = new System.Drawing.Size(81, 16);
            this.more.TabIndex = 18;
            this.more.Text = "Show more";
            this.more.TextColor = System.Drawing.Color.DarkRed;
            this.more.UseVisualStyleBackColor = false;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // entropy
            // 
            this.entropy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.entropy.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.entropy.FlatAppearance.BorderSize = 0;
            this.entropy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entropy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropy.ForeColor = System.Drawing.Color.White;
            this.entropy.Location = new System.Drawing.Point(357, 218);
            this.entropy.Name = "entropy";
            this.entropy.OnHoverBorderColor = System.Drawing.Color.White;
            this.entropy.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.entropy.OnHoverTextColor = System.Drawing.Color.White;
            this.entropy.Size = new System.Drawing.Size(75, 25);
            this.entropy.TabIndex = 16;
            this.entropy.Text = " Entropy";
            this.entropy.TextColor = System.Drawing.Color.White;
            this.entropy.UseVisualStyleBackColor = true;
            this.entropy.Click += new System.EventHandler(this.encode_Click);
            // 
            // btntable
            // 
            this.btntable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btntable.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btntable.FlatAppearance.BorderSize = 0;
            this.btntable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntable.ForeColor = System.Drawing.Color.White;
            this.btntable.Location = new System.Drawing.Point(358, 248);
            this.btntable.Name = "btntable";
            this.btntable.OnHoverBorderColor = System.Drawing.Color.White;
            this.btntable.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btntable.OnHoverTextColor = System.Drawing.Color.White;
            this.btntable.Size = new System.Drawing.Size(75, 25);
            this.btntable.TabIndex = 42;
            this.btntable.Text = "Table";
            this.btntable.TextColor = System.Drawing.Color.White;
            this.btntable.UseVisualStyleBackColor = true;
            this.btntable.Click += new System.EventHandler(this.btntable_Click);
            // 
            // FShannon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.less);
            this.Controls.Add(this.title);
            this.Controls.Add(this.more);
            this.Controls.Add(this.entropy);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.btntable);
            this.Name = "FShannon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FShannon_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FShannon_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FShannon_MouseMove);
            this.Resize += new System.EventHandler(this.FShannon_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p2;
        private ePOSOne.btnProduct.Button_WOC back;
        private ePOSOne.btnProduct.Button_WOC less;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label title;
        private ePOSOne.btnProduct.Button_WOC more;
        private ePOSOne.btnProduct.Button_WOC entropy;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox p1;
        private ePOSOne.btnProduct.Button_WOC draw;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC btntable;
        private System.Windows.Forms.PictureBox close;
    }
}