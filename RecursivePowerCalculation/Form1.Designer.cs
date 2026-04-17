namespace RecursivePowerCalculation
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
            lblPowerResult = new Label();
            btnCalculatePower = new Button();
            txtExponentInput = new TextBox();
            txtBaseInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblPowerResult
            // 
            lblPowerResult.Anchor = AnchorStyles.None;
            lblPowerResult.AutoSize = true;
            lblPowerResult.BackColor = Color.DarkOliveGreen;
            lblPowerResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPowerResult.ForeColor = SystemColors.ButtonHighlight;
            lblPowerResult.Location = new Point(208, 109);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(188, 62);
            lblPowerResult.TabIndex = 11;
            lblPowerResult.Text = "Result: ";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Anchor = AnchorStyles.None;
            btnCalculatePower.BackColor = Color.DarkOliveGreen;
            btnCalculatePower.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculatePower.ForeColor = SystemColors.ButtonHighlight;
            btnCalculatePower.Location = new Point(381, 355);
            btnCalculatePower.Margin = new Padding(3, 4, 3, 4);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(153, 76);
            btnCalculatePower.TabIndex = 10;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = false;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Anchor = AnchorStyles.None;
            txtExponentInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExponentInput.Location = new Point(312, 278);
            txtExponentInput.Margin = new Padding(3, 4, 3, 4);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(291, 34);
            txtExponentInput.TabIndex = 12;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Anchor = AnchorStyles.None;
            txtBaseInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBaseInput.Location = new Point(312, 203);
            txtBaseInput.Margin = new Padding(3, 4, 3, 4);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(291, 34);
            txtBaseInput.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 209);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 14;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 281);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 15;
            label2.Text = "Exponent";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(914, 471);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBaseInput);
            Controls.Add(txtExponentInput);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Power";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPowerResult;
        private Button btnCalculatePower;
        private TextBox txtExponentInput;
        private TextBox txtBaseInput;
        private Label label1;
        private Label label2;
    }
}