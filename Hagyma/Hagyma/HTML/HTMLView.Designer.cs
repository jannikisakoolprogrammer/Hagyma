﻿
namespace Hagyma
{
    partial class HTMLView
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
            this.textBoxHTML = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxHTML
            // 
            this.textBoxHTML.Enabled = false;
            this.textBoxHTML.Location = new System.Drawing.Point(13, 13);
            this.textBoxHTML.Multiline = true;
            this.textBoxHTML.Name = "textBoxHTML";
            this.textBoxHTML.Size = new System.Drawing.Size(485, 346);
            this.textBoxHTML.TabIndex = 0;
            // 
            // HTMLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 371);
            this.Controls.Add(this.textBoxHTML);
            this.Name = "HTMLView";
            this.Text = "HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHTML;
    }
}