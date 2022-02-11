namespace multimedia
{
    partial class intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intro));
            this.btnRLC = new System.Windows.Forms.Button();
            this.btnShannon = new System.Windows.Forms.Button();
            this.btnHuffman = new System.Windows.Forms.Button();
            this.btnAdaptiveHuffman = new System.Windows.Forms.Button();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.btnLWZ = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.btn = new ePOSOne.btnProduct.Button_WOC();
            this.btn2 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRLC
            // 
            this.btnRLC.BackColor = System.Drawing.Color.White;
            this.btnRLC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRLC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnRLC.Location = new System.Drawing.Point(422, 220);
            this.btnRLC.Name = "btnRLC";
            this.btnRLC.Size = new System.Drawing.Size(75, 27);
            this.btnRLC.TabIndex = 1;
            this.btnRLC.Text = "RLC";
            this.btnRLC.UseVisualStyleBackColor = false;
            this.btnRLC.Click += new System.EventHandler(this.RLC_Click);
            // 
            // btnShannon
            // 
            this.btnShannon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btnShannon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShannon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShannon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShannon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnShannon.Location = new System.Drawing.Point(405, 322);
            this.btnShannon.Name = "btnShannon";
            this.btnShannon.Size = new System.Drawing.Size(77, 27);
            this.btnShannon.TabIndex = 2;
            this.btnShannon.Text = "Shannon";
            this.btnShannon.UseVisualStyleBackColor = false;
            this.btnShannon.Click += new System.EventHandler(this.Shannon_Click);
            // 
            // btnHuffman
            // 
            this.btnHuffman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(236)))));
            this.btnHuffman.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuffman.FlatAppearance.BorderSize = 0;
            this.btnHuffman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuffman.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuffman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnHuffman.Location = new System.Drawing.Point(583, 432);
            this.btnHuffman.Name = "btnHuffman";
            this.btnHuffman.Size = new System.Drawing.Size(77, 29);
            this.btnHuffman.TabIndex = 3;
            this.btnHuffman.Text = "Huffman";
            this.btnHuffman.UseVisualStyleBackColor = false;
            this.btnHuffman.Click += new System.EventHandler(this.Huffman_Click);
            // 
            // btnAdaptiveHuffman
            // 
            this.btnAdaptiveHuffman.BackColor = System.Drawing.Color.White;
            this.btnAdaptiveHuffman.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdaptiveHuffman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaptiveHuffman.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaptiveHuffman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnAdaptiveHuffman.Location = new System.Drawing.Point(549, 134);
            this.btnAdaptiveHuffman.Name = "btnAdaptiveHuffman";
            this.btnAdaptiveHuffman.Size = new System.Drawing.Size(148, 34);
            this.btnAdaptiveHuffman.TabIndex = 4;
            this.btnAdaptiveHuffman.Text = "Adaptive Huffman";
            this.btnAdaptiveHuffman.UseVisualStyleBackColor = false;
            this.btnAdaptiveHuffman.Click += new System.EventHandler(this.AdaptiveHuffman_Click);
            // 
            // pct1
            // 
            this.pct1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pct1.Image = ((System.Drawing.Image)(resources.GetObject("pct1.Image")));
            this.pct1.Location = new System.Drawing.Point(-5, -5);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(906, 554);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 6;
            this.pct1.TabStop = false;
            this.pct1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLWZ
            // 
            this.btnLWZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btnLWZ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLWZ.FlatAppearance.BorderSize = 0;
            this.btnLWZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLWZ.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLWZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnLWZ.Location = new System.Drawing.Point(721, 335);
            this.btnLWZ.Name = "btnLWZ";
            this.btnLWZ.Size = new System.Drawing.Size(77, 26);
            this.btnLWZ.TabIndex = 7;
            this.btnLWZ.Text = "LZW";
            this.btnLWZ.UseVisualStyleBackColor = false;
            this.btnLWZ.Click += new System.EventHandler(this.btnLWZ_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.title.Location = new System.Drawing.Point(27, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 38);
            this.title.TabIndex = 8;
            this.title.Text = "Multimedia Project";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.text.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(111)))));
            this.text.Location = new System.Drawing.Point(24, 63);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(267, 38);
            this.text.TabIndex = 9;
            this.text.Text = "This project is about the compression\r\nalgorithms that used in the Multimedia.  \r" +
    "\n\r\n";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // text2
            // 
            this.text2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.text2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(78)))), ((int)(((byte)(111)))));
            this.text2.Location = new System.Drawing.Point(27, 62);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(375, 257);
            this.text2.TabIndex = 11;
            this.text2.Text = resources.GetString("text2.Text");
            this.text2.Visible = false;
            this.text2.Click += new System.EventHandler(this.text2_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(253)))));
            this.btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.btn.ButtonColor = System.Drawing.Color.DarkOrange;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(32, 105);
            this.btn.Name = "btn";
            this.btn.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.btn.OnHoverTextColor = System.Drawing.Color.White;
            this.btn.Size = new System.Drawing.Size(88, 25);
            this.btn.TabIndex = 14;
            this.btn.Text = "Show more";
            this.btn.TextColor = System.Drawing.Color.White;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.btn2.ButtonColor = System.Drawing.Color.DarkOrange;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(32, 322);
            this.btn2.Name = "btn2";
            this.btn2.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.btn2.OnHoverTextColor = System.Drawing.Color.White;
            this.btn2.Size = new System.Drawing.Size(88, 25);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "Show less";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.text);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnLWZ);
            this.Controls.Add(this.btnShannon);
            this.Controls.Add(this.btnRLC);
            this.Controls.Add(this.btnAdaptiveHuffman);
            this.Controls.Add(this.btnHuffman);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.pct1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "intro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.intro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.intro_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.intro_MouseMove);
            this.Resize += new System.EventHandler(this.intro_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRLC;
        private System.Windows.Forms.Button btnShannon;
        private System.Windows.Forms.Button btnHuffman;
        private System.Windows.Forms.Button btnAdaptiveHuffman;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.Button btnLWZ;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label text2;
        private ePOSOne.btnProduct.Button_WOC btn2;
        private ePOSOne.btnProduct.Button_WOC btn;
    }
}

