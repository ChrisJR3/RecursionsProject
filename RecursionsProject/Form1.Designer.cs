namespace RecursionsProject
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
            this.enterValueLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.fibonnaciButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterValueLabel
            // 
            this.enterValueLabel.AutoSize = true;
            this.enterValueLabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterValueLabel.Location = new System.Drawing.Point(12, 9);
            this.enterValueLabel.Name = "enterValueLabel";
            this.enterValueLabel.Size = new System.Drawing.Size(179, 23);
            this.enterValueLabel.TabIndex = 0;
            this.enterValueLabel.Text = "Enter Value to Solve:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(197, 3);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 29);
            this.inputTextBox.TabIndex = 1;
            // 
            // fibonnaciButton
            // 
            this.fibonnaciButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibonnaciButton.Location = new System.Drawing.Point(12, 46);
            this.fibonnaciButton.Name = "fibonnaciButton";
            this.fibonnaciButton.Size = new System.Drawing.Size(100, 30);
            this.fibonnaciButton.TabIndex = 2;
            this.fibonnaciButton.Text = "Fibonnaci";
            this.fibonnaciButton.UseVisualStyleBackColor = true;
            this.fibonnaciButton.Click += new System.EventHandler(this.fibonnaciButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.Location = new System.Drawing.Point(197, 46);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(100, 30);
            this.sumButton.TabIndex = 3;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 94);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(285, 164);
            this.outputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 270);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.fibonnaciButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.enterValueLabel);
            this.Name = "Form1";
            this.Text = "Recursive Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterValueLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button fibonnaciButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

