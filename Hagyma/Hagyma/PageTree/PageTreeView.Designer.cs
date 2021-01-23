
namespace Hagyma
{
    partial class PageTreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMovePageUp = new System.Windows.Forms.Button();
            this.buttonMovePageDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(217, 414);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(
                this.TreeView1_AfterSelect_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(236, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(237, 42);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(101, 23);
            this.buttonRename.TabIndex = 2;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(237, 72);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMovePageUp
            // 
            this.buttonMovePageUp.Location = new System.Drawing.Point(237, 102);
            this.buttonMovePageUp.Name = "buttonMovePageUp";
            this.buttonMovePageUp.Size = new System.Drawing.Size(101, 23);
            this.buttonMovePageUp.TabIndex = 4;
            this.buttonMovePageUp.Text = "Up";
            this.buttonMovePageUp.UseVisualStyleBackColor = true;
            this.buttonMovePageUp.Click += new System.EventHandler(this.buttonMovePageUp_Click);
            // 
            // buttonMovePageDown
            // 
            this.buttonMovePageDown.Location = new System.Drawing.Point(237, 132);
            this.buttonMovePageDown.Name = "buttonMovePageDown";
            this.buttonMovePageDown.Size = new System.Drawing.Size(101, 23);
            this.buttonMovePageDown.TabIndex = 5;
            this.buttonMovePageDown.Text = "Down";
            this.buttonMovePageDown.UseVisualStyleBackColor = true;
            this.buttonMovePageDown.Click += new System.EventHandler(this.buttonMovePageDown_Click);
            // 
            // PageTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 439);
            this.Controls.Add(this.buttonMovePageDown);
            this.Controls.Add(this.buttonMovePageUp);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.treeView1);
            this.Name = "PageTreeView";
            this.Text = "Page tree";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PageTreeView_FormClosed);
            this.ResumeLayout(false);

        }

        private void TreeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMovePageUp;
        private System.Windows.Forms.Button buttonMovePageDown;
    }
}