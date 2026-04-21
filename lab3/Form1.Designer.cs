namespace lab3
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
            btnShowInfo = new Button();
            lstBookTypes = new ListBox();
            btnShowAll = new Button();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Anchor = AnchorStyles.None;
            btnShowInfo.BackColor = Color.AntiqueWhite;
            btnShowInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowInfo.Location = new Point(80, 117);
            btnShowInfo.Margin = new Padding(3, 4, 3, 4);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(145, 69);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = false;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // lstBookTypes
            // 
            lstBookTypes.Anchor = AnchorStyles.None;
            lstBookTypes.BackColor = Color.AntiqueWhite;
            lstBookTypes.FormattingEnabled = true;
            lstBookTypes.Location = new Point(304, 34);
            lstBookTypes.Margin = new Padding(3, 4, 3, 4);
            lstBookTypes.Name = "lstBookTypes";
            lstBookTypes.Size = new Size(545, 344);
            lstBookTypes.TabIndex = 1;
            // 
            // btnShowAll
            // 
            btnShowAll.Anchor = AnchorStyles.None;
            btnShowAll.BackColor = Color.AntiqueWhite;
            btnShowAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.Location = new Point(80, 226);
            btnShowAll.Margin = new Padding(3, 4, 3, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(145, 69);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(914, 413);
            Controls.Add(btnShowAll);
            Controls.Add(lstBookTypes);
            Controls.Add(btnShowInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore System";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox lstBookTypes;
        private Button btnShowAll;
    }
}