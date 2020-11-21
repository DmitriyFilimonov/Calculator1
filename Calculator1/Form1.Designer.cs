namespace Calculator1
{
    partial class Form1
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
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(15, 72);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(45, 54);
            this.Four.TabIndex = 0;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(65, 72);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(45, 54);
            this.Five.TabIndex = 0;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(114, 72);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(45, 54);
            this.Six.TabIndex = 0;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(65, 132);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(45, 54);
            this.Two.TabIndex = 0;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(15, 132);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(45, 54);
            this.One.TabIndex = 0;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(114, 132);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(45, 54);
            this.Three.TabIndex = 0;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(15, 192);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(45, 54);
            this.Zero.TabIndex = 0;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Point
            // 
            this.Point.Location = new System.Drawing.Point(65, 192);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(45, 54);
            this.Point.TabIndex = 0;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = true;
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(15, 12);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(45, 54);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(65, 12);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(45, 54);
            this.Eight.TabIndex = 0;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(114, 12);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(45, 54);
            this.Nine.TabIndex = 0;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(165, 72);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(45, 54);
            this.Multiply.TabIndex = 0;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(165, 12);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(45, 54);
            this.Divide.TabIndex = 0;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(114, 192);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(45, 54);
            this.Result.TabIndex = 0;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(165, 132);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(45, 54);
            this.Minus.TabIndex = 0;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(165, 192);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(45, 54);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(228, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(191, 234);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 259);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.TextBox textBox1;
    }
}

