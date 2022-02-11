namespace multimedia
{
    partial class FRLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRLC));
            this.p3 = new System.Windows.Forms.PictureBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.back = new ePOSOne.btnProduct.Button_WOC();
            this.less = new ePOSOne.btnProduct.Button_WOC();
            this.more = new ePOSOne.btnProduct.Button_WOC();
            this.encode = new ePOSOne.btnProduct.Button_WOC();
            this.L1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.entropy = new ePOSOne.btnProduct.Button_WOC();
            this.decode = new ePOSOne.btnProduct.Button_WOC();
            this.CR = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // p3
            // 
            this.p3.Image = ((System.Drawing.Image)(resources.GetObject("p3.Image")));
            this.p3.Location = new System.Drawing.Point(-1, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(362, 556);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 1;
            this.p3.TabStop = false;
            this.p3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(439, 189);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(401, 22);
            this.txt1.TabIndex = 2;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(149)))));
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SaddleBrown;
            this.title.Location = new System.Drawing.Point(13, 73);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 23);
            this.title.TabIndex = 6;
            this.title.Text = "Run length coding ";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(149)))));
            this.text1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.text1.Location = new System.Drawing.Point(9, 102);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(197, 28);
            this.text1.TabIndex = 7;
            this.text1.Text = "(RLC) exploits memory present in  \r\nthe information source.";
            this.text1.Click += new System.EventHandler(this.label2_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(149)))));
            this.text2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.text2.Location = new System.Drawing.Point(10, 102);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(243, 84);
            this.text2.TabIndex = 9;
            this.text2.Text = resources.GetString("text2.Text");
            this.text2.Visible = false;
            this.text2.Click += new System.EventHandler(this.label3_Click);
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.BackColor = System.Drawing.Color.DarkOrange;
            this.p2.Image = ((System.Drawing.Image)(resources.GetObject("p2.Image")));
            this.p2.Location = new System.Drawing.Point(625, 290);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(13, 15);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 10;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // back
            // 
            this.back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.back.ButtonColor = System.Drawing.Color.DarkOrange;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(609, 280);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.Color.White;
            this.back.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.Size = new System.Drawing.Size(71, 33);
            this.back.TabIndex = 13;
            this.back.Text = "     Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.TextColor = System.Drawing.Color.White;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // less
            // 
            this.less.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(149)))));
            this.less.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.less.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.less.FlatAppearance.BorderSize = 0;
            this.less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.less.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.less.ForeColor = System.Drawing.Color.DarkOrange;
            this.less.Location = new System.Drawing.Point(12, 194);
            this.less.Name = "less";
            this.less.OnHoverBorderColor = System.Drawing.Color.White;
            this.less.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.less.OnHoverTextColor = System.Drawing.Color.White;
            this.less.Size = new System.Drawing.Size(81, 16);
            this.less.TabIndex = 8;
            this.less.Text = "Show less";
            this.less.TextColor = System.Drawing.Color.SaddleBrown;
            this.less.UseVisualStyleBackColor = false;
            this.less.Visible = false;
            this.less.Click += new System.EventHandler(this.button_WOC2_Click_1);
            // 
            // more
            // 
            this.more.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(149)))));
            this.more.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.more.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.more.FlatAppearance.BorderSize = 0;
            this.more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.more.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.more.ForeColor = System.Drawing.Color.DarkOrange;
            this.more.Location = new System.Drawing.Point(12, 142);
            this.more.Name = "more";
            this.more.OnHoverBorderColor = System.Drawing.Color.White;
            this.more.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.more.OnHoverTextColor = System.Drawing.Color.White;
            this.more.Size = new System.Drawing.Size(81, 16);
            this.more.TabIndex = 5;
            this.more.Text = "Show more";
            this.more.TextColor = System.Drawing.Color.SaddleBrown;
            this.more.UseVisualStyleBackColor = false;
            this.more.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // encode
            // 
            this.encode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.encode.ButtonColor = System.Drawing.Color.DarkOrange;
            this.encode.FlatAppearance.BorderSize = 0;
            this.encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encode.ForeColor = System.Drawing.Color.White;
            this.encode.Location = new System.Drawing.Point(360, 170);
            this.encode.Name = "encode";
            this.encode.OnHoverBorderColor = System.Drawing.Color.White;
            this.encode.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.encode.OnHoverTextColor = System.Drawing.Color.White;
            this.encode.Size = new System.Drawing.Size(75, 25);
            this.encode.TabIndex = 3;
            this.encode.Text = "Encode";
            this.encode.TextColor = System.Drawing.Color.White;
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(67)))), ((int)(((byte)(18)))));
            this.L1.Location = new System.Drawing.Point(528, 147);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(223, 23);
            this.L1.TabIndex = 37;
            this.L1.Text = "Enter message to encode";
            this.L1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.Location = new System.Drawing.Point(439, 220);
            this.p1.Multiline = true;
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(401, 48);
            this.p1.TabIndex = 38;
            this.p1.Visible = false;
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // entropy
            // 
            this.entropy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.entropy.ButtonColor = System.Drawing.Color.DarkOrange;
            this.entropy.FlatAppearance.BorderSize = 0;
            this.entropy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entropy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entropy.ForeColor = System.Drawing.Color.White;
            this.entropy.Location = new System.Drawing.Point(360, 232);
            this.entropy.Name = "entropy";
            this.entropy.OnHoverBorderColor = System.Drawing.Color.White;
            this.entropy.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.entropy.OnHoverTextColor = System.Drawing.Color.White;
            this.entropy.Size = new System.Drawing.Size(75, 25);
            this.entropy.TabIndex = 39;
            this.entropy.Text = "Entropy";
            this.entropy.TextColor = System.Drawing.Color.White;
            this.entropy.UseVisualStyleBackColor = true;
            this.entropy.Click += new System.EventHandler(this.button_WOC1_Click_1);
            // 
            // decode
            // 
            this.decode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.decode.ButtonColor = System.Drawing.Color.DarkOrange;
            this.decode.FlatAppearance.BorderSize = 0;
            this.decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decode.ForeColor = System.Drawing.Color.White;
            this.decode.Location = new System.Drawing.Point(360, 201);
            this.decode.Name = "decode";
            this.decode.OnHoverBorderColor = System.Drawing.Color.White;
            this.decode.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.decode.OnHoverTextColor = System.Drawing.Color.White;
            this.decode.Size = new System.Drawing.Size(75, 25);
            this.decode.TabIndex = 40;
            this.decode.Text = "Decode";
            this.decode.TextColor = System.Drawing.Color.White;
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // CR
            // 
            this.CR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.CR.ButtonColor = System.Drawing.Color.DarkOrange;
            this.CR.FlatAppearance.BorderSize = 0;
            this.CR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CR.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CR.ForeColor = System.Drawing.Color.White;
            this.CR.Location = new System.Drawing.Point(360, 263);
            this.CR.Name = "CR";
            this.CR.OnHoverBorderColor = System.Drawing.Color.White;
            this.CR.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.CR.OnHoverTextColor = System.Drawing.Color.White;
            this.CR.Size = new System.Drawing.Size(75, 25);
            this.CR.TabIndex = 41;
            this.CR.Text = "CR";
            this.CR.TextColor = System.Drawing.Color.White;
            this.CR.UseVisualStyleBackColor = true;
            this.CR.Click += new System.EventHandler(this.CR_Click);
            // 
            // FRLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.CR);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.entropy);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.less);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.more);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.p3);
            this.Name = "FRLC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRLC_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRLC_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRLC_MouseMove);
            this.Resize += new System.EventHandler(this.FRLC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.TextBox txt1;
        private ePOSOne.btnProduct.Button_WOC encode;
        private ePOSOne.btnProduct.Button_WOC more;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text1;
        private ePOSOne.btnProduct.Button_WOC less;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.PictureBox p2;
        private ePOSOne.btnProduct.Button_WOC back;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox p1;
        private ePOSOne.btnProduct.Button_WOC entropy;
        private ePOSOne.btnProduct.Button_WOC decode;
        private ePOSOne.btnProduct.Button_WOC CR;
    }
}