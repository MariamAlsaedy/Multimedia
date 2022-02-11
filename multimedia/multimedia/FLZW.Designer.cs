namespace multimedia
{
    partial class FLZW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLZW));
            this.p2 = new System.Windows.Forms.PictureBox();
            this.text1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.Incompress = new ePOSOne.btnProduct.Button_WOC();
            this.back = new ePOSOne.btnProduct.Button_WOC();
            this.less = new ePOSOne.btnProduct.Button_WOC();
            this.more = new ePOSOne.btnProduct.Button_WOC();
            this.Compress1 = new ePOSOne.btnProduct.Button_WOC();
            this.entropy = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            this.SuspendLayout();
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(619, 295);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(13, 15);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 23;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(217)))), ((int)(((byte)(248)))));
            this.text1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.text1.Location = new System.Drawing.Point(6, 81);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(239, 56);
            this.text1.TabIndex = 20;
            this.text1.Text = "LZW compression is the compression of\r\na file into a smaller file using a table-b" +
    "ased \r\nlookup algorithm invented by Abraham \r\nLempel, Jacob Ziv, and Terry Welch" +
    ". ";
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(439, 202);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(401, 22);
            this.txt1.TabIndex = 15;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(217)))), ((int)(((byte)(248)))));
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.title.Location = new System.Drawing.Point(9, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(245, 23);
            this.title.TabIndex = 19;
            this.title.Text = "Lempel-Ziv-Welch Algorithm";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(217)))), ((int)(((byte)(248)))));
            this.text2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.text2.Location = new System.Drawing.Point(8, 80);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(239, 140);
            this.text2.TabIndex = 22;
            this.text2.Text = resources.GetString("text2.Text");
            this.text2.Visible = false;
            this.text2.Click += new System.EventHandler(this.text2_Click);
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
            this.L1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.L1.Location = new System.Drawing.Point(537, 165);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(203, 19);
            this.L1.TabIndex = 37;
            this.L1.Text = "Enter message to compress";
            this.L1.Click += new System.EventHandler(this.L1_Click);
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(439, 233);
            this.p1.Multiline = true;
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(401, 48);
            this.p1.TabIndex = 38;
            this.p1.Visible = false;
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // Incompress
            // 
            this.Incompress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.Incompress.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.Incompress.FlatAppearance.BorderSize = 0;
            this.Incompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Incompress.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incompress.ForeColor = System.Drawing.Color.White;
            this.Incompress.Location = new System.Drawing.Point(358, 228);
            this.Incompress.Name = "Incompress";
            this.Incompress.OnHoverBorderColor = System.Drawing.Color.White;
            this.Incompress.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.Incompress.OnHoverTextColor = System.Drawing.Color.White;
            this.Incompress.Size = new System.Drawing.Size(75, 25);
            this.Incompress.TabIndex = 39;
            this.Incompress.Text = "Decompress";
            this.Incompress.TextColor = System.Drawing.Color.White;
            this.Incompress.UseVisualStyleBackColor = true;
            this.Incompress.Click += new System.EventHandler(this.decode_Click);
            // 
            // back
            // 
            this.back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.back.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(604, 287);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.Color.White;
            this.back.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
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
            this.less.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(217)))), ((int)(((byte)(248)))));
            this.less.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.less.ButtonColor = System.Drawing.Color.White;
            this.less.FlatAppearance.BorderSize = 0;
            this.less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.less.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.less.ForeColor = System.Drawing.Color.DarkOrange;
            this.less.Location = new System.Drawing.Point(12, 227);
            this.less.Name = "less";
            this.less.OnHoverBorderColor = System.Drawing.Color.White;
            this.less.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.less.OnHoverTextColor = System.Drawing.Color.White;
            this.less.Size = new System.Drawing.Size(81, 16);
            this.less.TabIndex = 21;
            this.less.Text = "Show less";
            this.less.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.less.UseVisualStyleBackColor = false;
            this.less.Visible = false;
            this.less.Click += new System.EventHandler(this.less_Click);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(217)))), ((int)(((byte)(248)))));
            this.more.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.more.ButtonColor = System.Drawing.Color.White;
            this.more.FlatAppearance.BorderSize = 0;
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.more.Location = new System.Drawing.Point(12, 142);
            this.more.Name = "more";
            this.more.OnHoverBorderColor = System.Drawing.Color.White;
            this.more.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.more.OnHoverTextColor = System.Drawing.Color.White;
            this.more.Size = new System.Drawing.Size(81, 16);
            this.more.TabIndex = 18;
            this.more.Text = "Show more";
            this.more.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.more.UseVisualStyleBackColor = false;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // Compress1
            // 
            this.Compress1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.Compress1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.Compress1.FlatAppearance.BorderSize = 0;
            this.Compress1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compress1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compress1.ForeColor = System.Drawing.Color.White;
            this.Compress1.Location = new System.Drawing.Point(358, 193);
            this.Compress1.Name = "Compress1";
            this.Compress1.OnHoverBorderColor = System.Drawing.Color.White;
            this.Compress1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.Compress1.OnHoverTextColor = System.Drawing.Color.White;
            this.Compress1.Size = new System.Drawing.Size(75, 25);
            this.Compress1.TabIndex = 16;
            this.Compress1.Text = "Comress";
            this.Compress1.TextColor = System.Drawing.Color.White;
            this.Compress1.UseVisualStyleBackColor = true;
            this.Compress1.Click += new System.EventHandler(this.encode_Click);
            // 
            // entropy
            // 
            this.entropy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.entropy.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(167)))), ((int)(((byte)(222)))));
            this.entropy.FlatAppearance.BorderSize = 0;
            this.entropy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entropy.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropy.ForeColor = System.Drawing.Color.White;
            this.entropy.Location = new System.Drawing.Point(358, 263);
            this.entropy.Name = "entropy";
            this.entropy.OnHoverBorderColor = System.Drawing.Color.White;
            this.entropy.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.entropy.OnHoverTextColor = System.Drawing.Color.White;
            this.entropy.Size = new System.Drawing.Size(75, 25);
            this.entropy.TabIndex = 40;
            this.entropy.Text = " Entropy";
            this.entropy.TextColor = System.Drawing.Color.White;
            this.entropy.UseVisualStyleBackColor = true;
            this.entropy.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // FLZW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.entropy);
            this.Controls.Add(this.Incompress);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.less);
            this.Controls.Add(this.more);
            this.Controls.Add(this.Compress1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.p3);
            this.Name = "FLZW";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FLWZ_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FLWZ_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FLWZ_MouseMove);
            this.Resize += new System.EventHandler(this.FLWZ_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p2;
        private ePOSOne.btnProduct.Button_WOC back;
        private ePOSOne.btnProduct.Button_WOC less;
        private System.Windows.Forms.Label text1;
        private ePOSOne.btnProduct.Button_WOC more;
        private ePOSOne.btnProduct.Button_WOC Compress1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox p1;
        private ePOSOne.btnProduct.Button_WOC Incompress;
        private ePOSOne.btnProduct.Button_WOC entropy;
    }
}