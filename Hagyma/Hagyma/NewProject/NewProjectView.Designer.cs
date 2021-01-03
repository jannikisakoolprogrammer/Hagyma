
namespace Hagyma
{
    partial class NewProjectView
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
            this.textBoxNewProject = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNewProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewProject
            // 
            this.textBoxNewProject.Location = new System.Drawing.Point(14, 29);
            this.textBoxNewProject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNewProject.Name = "textBoxNewProject";
            this.textBoxNewProject.Size = new System.Drawing.Size(285, 23);
            this.textBoxNewProject.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(14, 59);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(146, 27);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOk_MouseClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(167, 59);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 27);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelNewProject
            // 
            this.labelNewProject.AutoSize = true;
            this.labelNewProject.Location = new System.Drawing.Point(15, 7);
            this.labelNewProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewProject.Name = "labelNewProject";
            this.labelNewProject.Size = new System.Drawing.Size(189, 15);
            this.labelNewProject.TabIndex = 3;
            this.labelNewProject.Text = "Enter the name of the new project:";
            // 
            // NewProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 96);
            this.Controls.Add(this.labelNewProject);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxNewProject);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewProjectView";
            this.Text = "New project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewProject;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNewProject;
    }
}