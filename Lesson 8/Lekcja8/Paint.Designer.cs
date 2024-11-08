namespace Lekcja8
{
    partial class Paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penzelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzyćObrazekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobraćObrazekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmyćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pctColor = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(48, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctPaint_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penzelToolStripMenuItem,
            this.wyczyśćObrazToolStripMenuItem,
            this.otworzyćObrazekToolStripMenuItem,
            this.pobraćObrazekToolStripMenuItem,
            this.szaryToolStripMenuItem,
            this.rozmyćToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // penzelToolStripMenuItem
            // 
            this.penzelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.penzelToolStripMenuItem.Name = "penzelToolStripMenuItem";
            this.penzelToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.penzelToolStripMenuItem.Text = "penzel";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.colorToolStripMenuItem.Text = "color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // wyczyśćObrazToolStripMenuItem
            // 
            this.wyczyśćObrazToolStripMenuItem.Name = "wyczyśćObrazToolStripMenuItem";
            this.wyczyśćObrazToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.wyczyśćObrazToolStripMenuItem.Text = "wyczyść obraz";
            this.wyczyśćObrazToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćObrazToolStripMenuItem_Click);
            // 
            // otworzyćObrazekToolStripMenuItem
            // 
            this.otworzyćObrazekToolStripMenuItem.Name = "otworzyćObrazekToolStripMenuItem";
            this.otworzyćObrazekToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.otworzyćObrazekToolStripMenuItem.Text = "otworzyć obrazek";
            this.otworzyćObrazekToolStripMenuItem.Click += new System.EventHandler(this.otworzyćObrazekToolStripMenuItem_Click);
            // 
            // pobraćObrazekToolStripMenuItem
            // 
            this.pobraćObrazekToolStripMenuItem.Name = "pobraćObrazekToolStripMenuItem";
            this.pobraćObrazekToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.pobraćObrazekToolStripMenuItem.Text = "pobrać obrazek";
            this.pobraćObrazekToolStripMenuItem.Click += new System.EventHandler(this.pobraćObrazekToolStripMenuItem_Click);
            // 
            // szaryToolStripMenuItem
            // 
            this.szaryToolStripMenuItem.Name = "szaryToolStripMenuItem";
            this.szaryToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.szaryToolStripMenuItem.Text = "szary";
            this.szaryToolStripMenuItem.Click += new System.EventHandler(this.szaryToolStripMenuItem_Click);
            // 
            // rozmyćToolStripMenuItem
            // 
            this.rozmyćToolStripMenuItem.Name = "rozmyćToolStripMenuItem";
            this.rozmyćToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.rozmyćToolStripMenuItem.Text = "rozmyć";
            this.rozmyćToolStripMenuItem.Click += new System.EventHandler(this.rozmyćToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(598, 436);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pctColor
            // 
            this.pctColor.Location = new System.Drawing.Point(48, 436);
            this.pctColor.Name = "pctColor";
            this.pctColor.Size = new System.Drawing.Size(57, 45);
            this.pctColor.TabIndex = 3;
            this.pctColor.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(806, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctColor);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penzelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćObrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem pobraćObrazekToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem otworzyćObrazekToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem szaryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctColor;
        private System.Windows.Forms.ToolStripMenuItem rozmyćToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}