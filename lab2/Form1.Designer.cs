namespace lab2
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
            txtInput = new TextBox();
            btnCalculateFactorial = new Button();
            lblResult = new Label();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.None;
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(27, 236);
            txtInput.Margin = new Padding(3, 5, 3, 5);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(297, 34);
            txtInput.TabIndex = 0;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Anchor = AnchorStyles.None;
            btnCalculateFactorial.BackColor = Color.DodgerBlue;
            btnCalculateFactorial.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateFactorial.ForeColor = SystemColors.ButtonHighlight;
            btnCalculateFactorial.Location = new Point(27, 289);
            btnCalculateFactorial.Margin = new Padding(3, 5, 3, 5);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(297, 68);
            btnCalculateFactorial.TabIndex = 1;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = false;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.DodgerBlue;
            lblResult.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = SystemColors.ButtonHighlight;
            lblResult.Location = new Point(53, 112);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(237, 46);
            lblResult.TabIndex = 2;
            lblResult.Text = "Enter Number";
            // 
            // lblSumResult
            // 
            lblSumResult.Anchor = AnchorStyles.None;
            lblSumResult.AutoSize = true;
            lblSumResult.BackColor = Color.DodgerBlue;
            lblSumResult.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSumResult.ForeColor = SystemColors.ButtonHighlight;
            lblSumResult.Location = new Point(469, 112);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(237, 46);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "Enter Number";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Anchor = AnchorStyles.None;
            btnCalculateSum.BackColor = Color.DodgerBlue;
            btnCalculateSum.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateSum.ForeColor = SystemColors.ButtonHighlight;
            btnCalculateSum.Location = new Point(445, 289);
            btnCalculateSum.Margin = new Padding(3, 4, 3, 4);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(297, 68);
            btnCalculateSum.TabIndex = 4;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = false;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Anchor = AnchorStyles.None;
            txtArrayInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArrayInput.Location = new Point(445, 236);
            txtArrayInput.Margin = new Padding(3, 4, 3, 4);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(297, 34);
            txtArrayInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 51);
            label1.Name = "label1";
            label1.Size = new Size(146, 46);
            label1.TabIndex = 6;
            label1.Text = "Factorial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 51);
            label2.Name = "label2";
            label2.Size = new Size(174, 46);
            label2.TabIndex = 7;
            label2.Text = "Array Sum";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(914, 483);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(txtInput);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Factorial/Sum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculateFactorial;
        private Label lblResult;

        private Label lblSumResult;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
        private Label label1;
        private Label label2;
    }
}