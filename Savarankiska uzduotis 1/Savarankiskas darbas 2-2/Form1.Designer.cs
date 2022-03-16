namespace Savarankiskas_darbas_2_2
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateDigitsSumButton = new System.Windows.Forms.Button();
            this.NumbersCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(223, 30);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 23);
            this.InputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sveikuju skaiciu masyvas:";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(223, 59);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.Size = new System.Drawing.Size(100, 23);
            this.SumTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skaitmenu suma";
            // 
            // CalculateDigitsSumButton
            // 
            this.CalculateDigitsSumButton.Location = new System.Drawing.Point(338, 29);
            this.CalculateDigitsSumButton.Name = "CalculateDigitsSumButton";
            this.CalculateDigitsSumButton.Size = new System.Drawing.Size(204, 23);
            this.CalculateDigitsSumButton.TabIndex = 4;
            this.CalculateDigitsSumButton.Text = "Suskaiciuoti skaitmenu suma";
            this.CalculateDigitsSumButton.UseVisualStyleBackColor = true;
            this.CalculateDigitsSumButton.Click += new System.EventHandler(this.CalculateDigitsSumButton_Click);
            // 
            // NumbersCountTextBox
            // 
            this.NumbersCountTextBox.Location = new System.Drawing.Point(223, 88);
            this.NumbersCountTextBox.Name = "NumbersCountTextBox";
            this.NumbersCountTextBox.ReadOnly = true;
            this.NumbersCountTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumbersCountTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elementu skaicius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumbersCountTextBox);
            this.Controls.Add(this.CalculateDigitsSumButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculateDigitsSumButton;
        private System.Windows.Forms.TextBox NumbersCountTextBox;
        private System.Windows.Forms.Label label3;
    }
}
