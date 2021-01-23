
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
            this.linkLabelOnlineHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelOnlineHelp
            // 
            this.linkLabelOnlineHelp.AutoSize = true;
            this.linkLabelOnlineHelp.Location = new System.Drawing.Point(13, 13);
            this.linkLabelOnlineHelp.Name = "linkLabelOnlineHelp";
            this.linkLabelOnlineHelp.Size = new System.Drawing.Size(68, 15);
            this.linkLabelOnlineHelp.TabIndex = 0;
            this.linkLabelOnlineHelp.TabStop = true;
            this.linkLabelOnlineHelp.Text = "Online help";
            this.linkLabelOnlineHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOnlineHelp_LinkClicked);
            // 
            // HTMLView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 92);
            this.Controls.Add(this.linkLabelOnlineHelp);
            this.Name = "HTMLView";
            this.Text = "HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelOnlineHelp;
    }
}