using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Custom_Descending_Order
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
            listBoxResults = new ListBox();
            btnSort = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(350, 69);
            listBoxResults.Margin = new Padding(3, 4, 3, 4);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(505, 364);
            listBoxResults.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(71, 69);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(228, 62);
            btnSort.TabIndex = 1;
            btnSort.Text = "Custom Descending Order";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(914, 487);
            Controls.Add(btnSort);
            Controls.Add(listBoxResults);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Custom Descending Order OOP";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSort;
    }
}