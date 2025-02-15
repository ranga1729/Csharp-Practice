namespace Calculator_GUI
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
            display = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn_add = new Button();
            btn_sub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn_multi = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn_divide = new Button();
            btn_equal = new Button();
            btn0 = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display.Location = new Point(12, 12);
            display.Name = "display";
            display.Size = new Size(198, 33);
            display.TabIndex = 0;
            display.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.Cursor = Cursors.Hand;
            btn7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn7.Location = new Point(12, 59);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 46);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button1_Click;
            // 
            // btn8
            // 
            btn8.Cursor = Cursors.Hand;
            btn8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn8.Location = new Point(63, 59);
            btn8.Name = "btn8";
            btn8.Size = new Size(45, 46);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button2_Click;
            // 
            // btn9
            // 
            btn9.Cursor = Cursors.Hand;
            btn9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn9.Location = new Point(114, 59);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 46);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ButtonFace;
            btn_add.Cursor = Cursors.Hand;
            btn_add.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn_add.Location = new Point(165, 59);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(45, 46);
            btn_add.TabIndex = 4;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_sub
            // 
            btn_sub.BackColor = SystemColors.ButtonFace;
            btn_sub.Cursor = Cursors.Hand;
            btn_sub.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn_sub.Location = new Point(165, 111);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(45, 46);
            btn_sub.TabIndex = 8;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = false;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn6
            // 
            btn6.Cursor = Cursors.Hand;
            btn6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn6.Location = new Point(114, 111);
            btn6.Name = "btn6";
            btn6.Size = new Size(45, 46);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Cursor = Cursors.Hand;
            btn5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn5.Location = new Point(63, 111);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 46);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn4.Location = new Point(12, 111);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 46);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn_multi
            // 
            btn_multi.BackColor = SystemColors.ButtonFace;
            btn_multi.Cursor = Cursors.Hand;
            btn_multi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn_multi.Location = new Point(165, 163);
            btn_multi.Name = "btn_multi";
            btn_multi.Size = new Size(45, 46);
            btn_multi.TabIndex = 12;
            btn_multi.Text = "x";
            btn_multi.UseVisualStyleBackColor = false;
            btn_multi.Click += btn_multi_Click;
            // 
            // btn3
            // 
            btn3.Cursor = Cursors.Hand;
            btn3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn3.Location = new Point(114, 163);
            btn3.Name = "btn3";
            btn3.Size = new Size(45, 46);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn2.Location = new Point(63, 163);
            btn2.Name = "btn2";
            btn2.Size = new Size(45, 46);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn1.Location = new Point(12, 163);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 46);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = SystemColors.ButtonFace;
            btn_divide.Cursor = Cursors.Hand;
            btn_divide.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn_divide.Location = new Point(165, 215);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(45, 46);
            btn_divide.TabIndex = 16;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = SystemColors.ButtonFace;
            btn_equal.Cursor = Cursors.Hand;
            btn_equal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn_equal.Location = new Point(114, 215);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(45, 46);
            btn_equal.TabIndex = 15;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn0
            // 
            btn0.Cursor = Cursors.Hand;
            btn0.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn0.Location = new Point(63, 215);
            btn0.Name = "btn0";
            btn0.Size = new Size(45, 46);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ButtonFace;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn_clear.Location = new Point(12, 215);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(45, 46);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 276);
            Controls.Add(btn_divide);
            Controls.Add(btn_equal);
            Controls.Add(btn0);
            Controls.Add(btn_clear);
            Controls.Add(btn_multi);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn_sub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn_add);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(display);
            Name = "Form1";
            Text = "Calculator GUI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn_add;
        private Button btn_sub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn_multi;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn_divide;
        private Button btn_equal;
        private Button btn0;
        private Button btn_clear;
    }
}
