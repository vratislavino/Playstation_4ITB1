namespace Playstation_4ITB1
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
            canvas1 = new Canvas();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // canvas1
            // 
            canvas1.BackColor = Color.DarkGray;
            canvas1.BorderStyle = BorderStyle.FixedSingle;
            canvas1.Location = new Point(883, 32);
            canvas1.Name = "canvas1";
            canvas1.Size = new Size(372, 372);
            canvas1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(43, 39);
            button1.Name = "button1";
            button1.Size = new Size(289, 121);
            button1.TabIndex = 1;
            button1.Text = "Square";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(43, 166);
            button2.Name = "button2";
            button2.Size = new Size(289, 121);
            button2.TabIndex = 2;
            button2.Text = "Circle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(338, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 87);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox2.Location = new Point(338, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(507, 87);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(52, 554);
            label1.Name = "label1";
            label1.Size = new Size(0, 62);
            label1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.Location = new Point(43, 293);
            button3.Name = "button3";
            button3.Size = new Size(289, 121);
            button3.TabIndex = 6;
            button3.Text = "Cross";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button4.Location = new Point(43, 430);
            button4.Name = "button4";
            button4.Size = new Size(289, 121);
            button4.TabIndex = 7;
            button4.Text = "Triangle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.HotTrack;
            textBox3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox3.Location = new Point(338, 317);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(507, 87);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.HotTrack;
            textBox4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox4.Location = new Point(338, 438);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(507, 87);
            textBox4.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 842);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(canvas1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Canvas canvas1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
