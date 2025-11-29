namespace Calculator
{
    partial class Calculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.OpenBr = new System.Windows.Forms.Button();
            this.CloseBr = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Deciminal = new System.Windows.Forms.Button();
            this.BackSp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(214, 38);
            this.txtDisplay.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(12, 56);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(43, 41);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenBr
            // 
            this.OpenBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenBr.Location = new System.Drawing.Point(61, 56);
            this.OpenBr.Name = "OpenBr";
            this.OpenBr.Size = new System.Drawing.Size(43, 41);
            this.OpenBr.TabIndex = 2;
            this.OpenBr.Text = "(";
            this.OpenBr.UseVisualStyleBackColor = true;
            this.OpenBr.Click += new System.EventHandler(this.OpenBr_Click);
            // 
            // CloseBr
            // 
            this.CloseBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBr.Location = new System.Drawing.Point(110, 56);
            this.CloseBr.Name = "CloseBr";
            this.CloseBr.Size = new System.Drawing.Size(43, 41);
            this.CloseBr.TabIndex = 3;
            this.CloseBr.Text = ")";
            this.CloseBr.UseVisualStyleBackColor = true;
            this.CloseBr.Click += new System.EventHandler(this.CloseBr_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(159, 56);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(43, 41);
            this.Divide.TabIndex = 4;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(159, 103);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(43, 41);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(159, 150);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(43, 41);
            this.Minus.TabIndex = 6;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(159, 197);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(43, 41);
            this.Add.TabIndex = 7;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(159, 244);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(43, 41);
            this.Equal.TabIndex = 8;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(110, 103);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(43, 41);
            this.Nine.TabIndex = 9;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(61, 103);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(43, 41);
            this.Eight.TabIndex = 10;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(12, 103);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(43, 41);
            this.Seven.TabIndex = 11;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(12, 150);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(43, 41);
            this.Four.TabIndex = 12;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(61, 150);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(43, 41);
            this.Five.TabIndex = 13;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(110, 150);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(43, 41);
            this.Six.TabIndex = 14;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(110, 197);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(43, 41);
            this.Three.TabIndex = 15;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(61, 197);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(43, 41);
            this.Two.TabIndex = 16;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(12, 197);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(43, 41);
            this.One.TabIndex = 17;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(61, 243);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(43, 41);
            this.Zero.TabIndex = 18;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Deciminal
            // 
            this.Deciminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deciminal.Location = new System.Drawing.Point(110, 243);
            this.Deciminal.Name = "Deciminal";
            this.Deciminal.Size = new System.Drawing.Size(43, 41);
            this.Deciminal.TabIndex = 19;
            this.Deciminal.Text = ".";
            this.Deciminal.UseVisualStyleBackColor = true;
            this.Deciminal.Click += new System.EventHandler(this.Deciminal_Click);
            // 
            // BackSp
            // 
            this.BackSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSp.Location = new System.Drawing.Point(12, 244);
            this.BackSp.Name = "BackSp";
            this.BackSp.Size = new System.Drawing.Size(43, 41);
            this.BackSp.TabIndex = 20;
            this.BackSp.Text = "<";
            this.BackSp.UseVisualStyleBackColor = true;
            this.BackSp.Click += new System.EventHandler(this.BackSp_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 296);
            this.Controls.Add(this.BackSp);
            this.Controls.Add(this.Deciminal);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.CloseBr);
            this.Controls.Add(this.OpenBr);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenBr;
        private System.Windows.Forms.Button CloseBr;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Deciminal;
        private System.Windows.Forms.Button BackSp;
    }
}

