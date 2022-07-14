namespace Мои_проекты
{
    partial class Form3
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.Increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirst.Location = new System.Drawing.Point(12, 23);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(155, 23);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Первое число:";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecond.Location = new System.Drawing.Point(12, 84);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(153, 23);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Второе число:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(196, 26);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(193, 84);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 3;
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Increment
            // 
            this.Increment.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Increment.Location = new System.Drawing.Point(19, 137);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(50, 50);
            this.Increment.TabIndex = 4;
            this.Increment.Text = "+";
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.btn_click);
            // 
            // Decrement
            // 
            this.Decrement.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrement.Location = new System.Drawing.Point(93, 137);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(50, 50);
            this.Decrement.TabIndex = 5;
            this.Decrement.Text = "-";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // Increase
            // 
            this.Increase.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Increase.Location = new System.Drawing.Point(170, 137);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(50, 50);
            this.Increase.TabIndex = 6;
            this.Increase.Text = "*";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.btn_click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Divide.Location = new System.Drawing.Point(246, 137);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 7;
            this.Divide.Text = ":";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.btn_click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(17, 233);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(151, 31);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Результат:";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(190, 233);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(30, 31);
            this.txtResult.TabIndex = 9;
            this.txtResult.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(320, 309);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Name = "Form3";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label txtResult;
    }
}