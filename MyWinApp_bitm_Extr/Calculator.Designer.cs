namespace MyWinApp_bitm_Extr
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNumtextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondNumtextBox = new System.Windows.Forms.TextBox();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.Substractbutton = new System.Windows.Forms.Button();
            this.Multiplybutton = new System.Windows.Forms.Button();
            this.Dividebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // FirstNumtextBox
            // 
            this.FirstNumtextBox.Location = new System.Drawing.Point(216, 44);
            this.FirstNumtextBox.Name = "FirstNumtextBox";
            this.FirstNumtextBox.Size = new System.Drawing.Size(139, 26);
            this.FirstNumtextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 308);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 36);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result";
            // 
            // SecondNumtextBox
            // 
            this.SecondNumtextBox.Location = new System.Drawing.Point(216, 105);
            this.SecondNumtextBox.Name = "SecondNumtextBox";
            this.SecondNumtextBox.Size = new System.Drawing.Size(139, 26);
            this.SecondNumtextBox.TabIndex = 1;
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.Location = new System.Drawing.Point(216, 172);
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(139, 26);
            this.ResulttextBox.TabIndex = 1;
            // 
            // Substractbutton
            // 
            this.Substractbutton.Location = new System.Drawing.Point(145, 308);
            this.Substractbutton.Name = "Substractbutton";
            this.Substractbutton.Size = new System.Drawing.Size(94, 36);
            this.Substractbutton.TabIndex = 2;
            this.Substractbutton.Text = "Substract";
            this.Substractbutton.UseVisualStyleBackColor = true;
            this.Substractbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Multiplybutton
            // 
            this.Multiplybutton.Location = new System.Drawing.Point(269, 308);
            this.Multiplybutton.Name = "Multiplybutton";
            this.Multiplybutton.Size = new System.Drawing.Size(75, 36);
            this.Multiplybutton.TabIndex = 2;
            this.Multiplybutton.Text = "Multiply";
            this.Multiplybutton.UseVisualStyleBackColor = true;
            this.Multiplybutton.Click += new System.EventHandler(this.Multiplybutton_Click);
            // 
            // Dividebutton
            // 
            this.Dividebutton.Location = new System.Drawing.Point(390, 308);
            this.Dividebutton.Name = "Dividebutton";
            this.Dividebutton.Size = new System.Drawing.Size(75, 36);
            this.Dividebutton.TabIndex = 2;
            this.Dividebutton.Text = "Divide";
            this.Dividebutton.UseVisualStyleBackColor = true;
            this.Dividebutton.Click += new System.EventHandler(this.Dividebutton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 587);
            this.Controls.Add(this.Dividebutton);
            this.Controls.Add(this.Multiplybutton);
            this.Controls.Add(this.Substractbutton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.SecondNumtextBox);
            this.Controls.Add(this.FirstNumtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNumtextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecondNumtextBox;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.Button Substractbutton;
        private System.Windows.Forms.Button Multiplybutton;
        private System.Windows.Forms.Button Dividebutton;
    }
}