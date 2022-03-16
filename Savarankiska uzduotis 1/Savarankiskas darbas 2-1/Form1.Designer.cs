namespace Savarankiskas_darbas_2_1
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
            this.TextInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpaceCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextInputTextBox
            // 
            this.TextInputTextBox.Location = new System.Drawing.Point(121, 23);
            this.TextInputTextBox.Name = "TextInputTextBox";
            this.TextInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.TextInputTextBox.TabIndex = 0;
            this.TextInputTextBox.TextChanged += new System.EventHandler(this.TextInputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tekstas";
            // 
            // SpaceCountTextBox
            // 
            this.SpaceCountTextBox.Location = new System.Drawing.Point(121, 52);
            this.SpaceCountTextBox.Name = "SpaceCountTextBox";
            this.SpaceCountTextBox.ReadOnly = true;
            this.SpaceCountTextBox.Size = new System.Drawing.Size(100, 23);
            this.SpaceCountTextBox.TabIndex = 2;
            this.SpaceCountTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarpu skaicius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpaceCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextInputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpaceCountTextBox;
        private System.Windows.Forms.Label label2;
    }
}
