namespace Assignment_3
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
            label1 = new Label();
            label2 = new Label();
            weightTextBox = new TextBox();
            heightTextBox = new TextBox();
            CalculateButton = new Button();
            panel1 = new Panel();
            statusLabel = new Label();
            bmiLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 37);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Weight (pounds):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 73);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Height (inches):";
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(231, 34);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(125, 27);
            weightTextBox.TabIndex = 2;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(231, 70);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(125, 27);
            heightTextBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(192, 114);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(94, 29);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(statusLabel);
            panel1.Controls.Add(bmiLabel);
            panel1.Location = new Point(12, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 90);
            panel1.TabIndex = 5;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(19, 42);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(50, 20);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "label4";
            statusLabel.Visible = false;
            // 
            // bmiLabel
            // 
            bmiLabel.AutoSize = true;
            bmiLabel.Location = new Point(19, 11);
            bmiLabel.Name = "bmiLabel";
            bmiLabel.Size = new Size(50, 20);
            bmiLabel.TabIndex = 0;
            bmiLabel.Text = "label3";
            bmiLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 251);
            Controls.Add(panel1);
            Controls.Add(CalculateButton);
            Controls.Add(heightTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BMI calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox weightTextBox;
        private TextBox heightTextBox;
        private Button CalculateButton;
        private Panel panel1;
        private Label statusLabel;
        private Label bmiLabel;
    }
}