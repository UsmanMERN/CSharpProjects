namespace calculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 42);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 90);
            button1.Name = "button1";
            button1.Size = new Size(63, 32);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += getValue;
            // 
            // button2
            // 
            button2.Location = new Point(189, 90);
            button2.Name = "button2";
            button2.Size = new Size(63, 32);
            button2.TabIndex = 1;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += getValue;
            // 
            // button3
            // 
            button3.Location = new Point(99, 90);
            button3.Name = "button3";
            button3.Size = new Size(63, 32);
            button3.TabIndex = 1;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += getValue;
            // 
            // button4
            // 
            button4.Location = new Point(275, 90);
            button4.Name = "button4";
            button4.Size = new Size(63, 32);
            button4.TabIndex = 1;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = true;
            button4.Click += getOperator;
            // 
            // button5
            // 
            button5.Location = new Point(12, 146);
            button5.Name = "button5";
            button5.Size = new Size(63, 32);
            button5.TabIndex = 1;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += getValue;
            // 
            // button6
            // 
            button6.Location = new Point(189, 146);
            button6.Name = "button6";
            button6.Size = new Size(63, 32);
            button6.TabIndex = 1;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += getValue;
            // 
            // button7
            // 
            button7.Location = new Point(275, 146);
            button7.Name = "button7";
            button7.Size = new Size(63, 32);
            button7.TabIndex = 1;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = true;
            button7.Click += getOperator;
            // 
            // button8
            // 
            button8.Location = new Point(99, 146);
            button8.Name = "button8";
            button8.Size = new Size(63, 32);
            button8.TabIndex = 1;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += getValue;
            // 
            // button9
            // 
            button9.Location = new Point(12, 196);
            button9.Name = "button9";
            button9.Size = new Size(63, 32);
            button9.TabIndex = 1;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += getValue;
            // 
            // button10
            // 
            button10.Location = new Point(189, 196);
            button10.Name = "button10";
            button10.Size = new Size(63, 32);
            button10.TabIndex = 1;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += getValue;
            // 
            // button11
            // 
            button11.Location = new Point(275, 196);
            button11.Name = "button11";
            button11.Size = new Size(63, 32);
            button11.TabIndex = 1;
            button11.Text = "_";
            button11.UseVisualStyleBackColor = true;
            button11.Click += getOperator;
            // 
            // button12
            // 
            button12.Location = new Point(99, 196);
            button12.Name = "button12";
            button12.Size = new Size(63, 32);
            button12.TabIndex = 1;
            button12.Text = "8";
            button12.UseVisualStyleBackColor = true;
            button12.Click += getValue;
            // 
            // button13
            // 
            button13.Location = new Point(12, 245);
            button13.Name = "button13";
            button13.Size = new Size(63, 32);
            button13.TabIndex = 1;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = true;
            button13.Click += getValue;
            // 
            // button14
            // 
            button14.Location = new Point(99, 245);
            button14.Name = "button14";
            button14.Size = new Size(153, 32);
            button14.TabIndex = 1;
            button14.Text = "clear";
            button14.UseVisualStyleBackColor = true;
            button14.Click += getOperator;
            // 
            // button15
            // 
            button15.Location = new Point(275, 245);
            button15.Name = "button15";
            button15.Size = new Size(63, 32);
            button15.TabIndex = 1;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            button15.Click += getOperator;
            // 
            // button17
            // 
            button17.Location = new Point(12, 293);
            button17.Name = "button17";
            button17.Size = new Size(326, 32);
            button17.TabIndex = 1;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += getEqualTo;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 351);
            Controls.Add(button12);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button17);
            Controls.Add(button15);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button14);
            Controls.Add(button10);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button13);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button17;
    }
}