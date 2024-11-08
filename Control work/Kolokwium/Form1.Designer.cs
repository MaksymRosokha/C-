namespace Kolokwium
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(172, 165);
            button1.Name = "button1";
            button1.Size = new Size(152, 64);
            button1.TabIndex = 0;
            button1.Text = "oblicz sin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 121);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 270);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Odpowiedź";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 115);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 5;
            label3.Text = "sin";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(644, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(552, 331);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 9;
            label5.Text = "Odpowiedź";
            // 
            // button2
            // 
            button2.Location = new Point(653, 248);
            button2.Name = "button2";
            button2.Size = new Size(152, 64);
            button2.TabIndex = 6;
            button2.Text = "oblicz całkę oznaczoną";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(592, 112);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 14;
            label7.Text = "od";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(639, 118);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(625, 109);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 27);
            textBox5.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(592, 151);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 17;
            label9.Text = "do";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(639, 157);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(625, 148);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 27);
            textBox6.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(210, 48);
            label4.Name = "label4";
            label4.Size = new Size(58, 41);
            label4.TabIndex = 18;
            label4.Text = "sin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(578, 48);
            label6.Name = "label6";
            label6.Size = new Size(314, 41);
            label6.TabIndex = 19;
            label6.Text = "całka oznaczona z sin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 450);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private Label label4;
        private Label label6;
    }
}
