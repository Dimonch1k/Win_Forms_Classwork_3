namespace _2_WForm
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(381, 484);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(558, 327);
            button1.Name = "button1";
            button1.Size = new Size(268, 34);
            button1.TabIndex = 1;
            button1.Text = "Add to list";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(558, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(558, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(431, 78);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 4;
            label1.Text = "Notification";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(431, 123);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 5;
            label2.Text = "Time (hour)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(431, 181);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 7;
            label3.Text = "Time (minute)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(558, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(431, 234);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 9;
            label4.Text = "Time (sec)";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(558, 232);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Chocolate;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(121, 32);
            label5.Name = "label5";
            label5.Size = new Size(168, 37);
            label5.TabIndex = 10;
            label5.Text = "Notifications";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 687);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
    }
}