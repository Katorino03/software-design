namespace RecursiveFibonacciSequence
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
            lblFibonacciResult = new Label();
            btnCalculateFibonacci = new Button();
            txtFibonacciInput = new TextBox();
            SuspendLayout();
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.Anchor = AnchorStyles.None;
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.BackColor = Color.DarkOliveGreen;
            lblFibonacciResult.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFibonacciResult.ForeColor = SystemColors.ButtonHighlight;
            lblFibonacciResult.Location = new Point(215, 53);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(443, 62);
            lblFibonacciResult.TabIndex = 8;
            lblFibonacciResult.Text = "Fibonacci Number:";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Anchor = AnchorStyles.None;
            btnCalculateFibonacci.BackColor = Color.DarkOliveGreen;
            btnCalculateFibonacci.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculateFibonacci.ForeColor = SystemColors.ButtonHighlight;
            btnCalculateFibonacci.Location = new Point(349, 244);
            btnCalculateFibonacci.Margin = new Padding(3, 4, 3, 4);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(153, 76);
            btnCalculateFibonacci.TabIndex = 7;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = false;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Anchor = AnchorStyles.None;
            txtFibonacciInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFibonacciInput.Location = new Point(232, 180);
            txtFibonacciInput.Margin = new Padding(3, 4, 3, 4);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(387, 34);
            txtFibonacciInput.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(914, 443);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtFibonacciInput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFibonacciResult;
        private Button btnCalculateFibonacci;
        private TextBox txtFibonacciInput;
    }
}