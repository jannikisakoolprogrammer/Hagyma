
namespace Hagyma
{
    partial class ViewMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewPages = new System.Windows.Forms.TreeView();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.buttonSavePage = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTestserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTestserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tabControlEditor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSaveCSS = new System.Windows.Forms.Button();
            this.textBoxCSS = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxJS = new System.Windows.Forms.TextBox();
            this.buttonSaveJS = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxHTMLTemplate = new System.Windows.Forms.TextBox();
            this.buttonSaveHTMLTemplate = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.tabControlEditor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewPages
            // 
            this.treeViewPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewPages.Location = new System.Drawing.Point(3, 31);
            this.treeViewPages.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewPages.Name = "treeViewPages";
            this.treeViewPages.Size = new System.Drawing.Size(143, 271);
            this.treeViewPages.TabIndex = 4;
            this.treeViewPages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPages_AfterSelect);
            // 
            // textBoxPage
            // 
            this.textBoxPage.AcceptsTab = true;
            this.textBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPage.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPage.Location = new System.Drawing.Point(150, 31);
            this.textBoxPage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPage.Multiline = true;
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPage.Size = new System.Drawing.Size(507, 271);
            this.textBoxPage.TabIndex = 5;
            this.textBoxPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPage_KeyDown);
            // 
            // buttonSavePage
            // 
            this.buttonSavePage.Location = new System.Drawing.Point(3, 3);
            this.buttonSavePage.Name = "buttonSavePage";
            this.buttonSavePage.Size = new System.Drawing.Size(143, 23);
            this.buttonSavePage.TabIndex = 6;
            this.buttonSavePage.Text = "Save";
            this.buttonSavePage.UseVisualStyleBackColor = true;
            this.buttonSavePage.Click += new System.EventHandler(this.buttonSavePage_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem.Text = "New project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "Open project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.closeProjectToolStripMenuItem.Text = "Close project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageTreeToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // pageTreeToolStripMenuItem
            // 
            this.pageTreeToolStripMenuItem.Name = "pageTreeToolStripMenuItem";
            this.pageTreeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.pageTreeToolStripMenuItem.Text = "Page tree";
            this.pageTreeToolStripMenuItem.Click += new System.EventHandler(this.pageTreeToolStripMenuItem_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.startTestserverToolStripMenuItem,
            this.stopTestserverToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // startTestserverToolStripMenuItem
            // 
            this.startTestserverToolStripMenuItem.Name = "startTestserverToolStripMenuItem";
            this.startTestserverToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.startTestserverToolStripMenuItem.Text = "Start testserver";
            this.startTestserverToolStripMenuItem.Click += new System.EventHandler(this.startTestserverToolStripMenuItem_Click);
            // 
            // stopTestserverToolStripMenuItem
            // 
            this.stopTestserverToolStripMenuItem.Name = "stopTestserverToolStripMenuItem";
            this.stopTestserverToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.stopTestserverToolStripMenuItem.Text = "Stop testserver";
            this.stopTestserverToolStripMenuItem.Click += new System.EventHandler(this.stopTestserverToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htmlMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // htmlMenuItem
            // 
            this.htmlMenuItem.Name = "htmlMenuItem";
            this.htmlMenuItem.Size = new System.Drawing.Size(106, 22);
            this.htmlMenuItem.Text = "HTML";
            this.htmlMenuItem.Click += new System.EventHandler(this.htmlMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(700, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tabControlEditor
            // 
            this.tabControlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEditor.Controls.Add(this.tabPage1);
            this.tabControlEditor.Controls.Add(this.tabPage2);
            this.tabControlEditor.Controls.Add(this.tabPage3);
            this.tabControlEditor.Controls.Add(this.tabPage4);
            this.tabControlEditor.Location = new System.Drawing.Point(12, 27);
            this.tabControlEditor.Name = "tabControlEditor";
            this.tabControlEditor.SelectedIndex = 0;
            this.tabControlEditor.Size = new System.Drawing.Size(676, 342);
            this.tabControlEditor.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSavePage);
            this.tabPage1.Controls.Add(this.textBoxPage);
            this.tabPage1.Controls.Add(this.treeViewPages);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSaveCSS);
            this.tabPage2.Controls.Add(this.textBoxCSS);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CSS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCSS
            // 
            this.buttonSaveCSS.Location = new System.Drawing.Point(4, 4);
            this.buttonSaveCSS.Name = "buttonSaveCSS";
            this.buttonSaveCSS.Size = new System.Drawing.Size(143, 23);
            this.buttonSaveCSS.TabIndex = 2;
            this.buttonSaveCSS.Text = "Save";
            this.buttonSaveCSS.UseVisualStyleBackColor = true;
            this.buttonSaveCSS.Click += new System.EventHandler(this.buttonSaveCSS_Click);
            // 
            // textBoxCSS
            // 
            this.textBoxCSS.AcceptsTab = true;
            this.textBoxCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCSS.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCSS.Location = new System.Drawing.Point(4, 34);
            this.textBoxCSS.Multiline = true;
            this.textBoxCSS.Name = "textBoxCSS";
            this.textBoxCSS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCSS.Size = new System.Drawing.Size(661, 267);
            this.textBoxCSS.TabIndex = 1;
            this.textBoxCSS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCSS_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxJS);
            this.tabPage3.Controls.Add(this.buttonSaveJS);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JavaScript";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxJS
            // 
            this.textBoxJS.AcceptsTab = true;
            this.textBoxJS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJS.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxJS.Location = new System.Drawing.Point(4, 34);
            this.textBoxJS.Multiline = true;
            this.textBoxJS.Name = "textBoxJS";
            this.textBoxJS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxJS.Size = new System.Drawing.Size(661, 267);
            this.textBoxJS.TabIndex = 1;
            this.textBoxJS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJS_KeyDown);
            // 
            // buttonSaveJS
            // 
            this.buttonSaveJS.Location = new System.Drawing.Point(4, 4);
            this.buttonSaveJS.Name = "buttonSaveJS";
            this.buttonSaveJS.Size = new System.Drawing.Size(142, 23);
            this.buttonSaveJS.TabIndex = 0;
            this.buttonSaveJS.Text = "Save";
            this.buttonSaveJS.UseVisualStyleBackColor = true;
            this.buttonSaveJS.Click += new System.EventHandler(this.buttonSaveJS_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxHTMLTemplate);
            this.tabPage4.Controls.Add(this.buttonSaveHTMLTemplate);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(668, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "HTML template";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxHTMLTemplate
            // 
            this.textBoxHTMLTemplate.AcceptsTab = true;
            this.textBoxHTMLTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHTMLTemplate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHTMLTemplate.Location = new System.Drawing.Point(4, 34);
            this.textBoxHTMLTemplate.Multiline = true;
            this.textBoxHTMLTemplate.Name = "textBoxHTMLTemplate";
            this.textBoxHTMLTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxHTMLTemplate.Size = new System.Drawing.Size(661, 277);
            this.textBoxHTMLTemplate.TabIndex = 1;
            this.textBoxHTMLTemplate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHTMLTemplate_KeyDown);
            // 
            // buttonSaveHTMLTemplate
            // 
            this.buttonSaveHTMLTemplate.Location = new System.Drawing.Point(4, 4);
            this.buttonSaveHTMLTemplate.Name = "buttonSaveHTMLTemplate";
            this.buttonSaveHTMLTemplate.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveHTMLTemplate.TabIndex = 0;
            this.buttonSaveHTMLTemplate.Text = "Save";
            this.buttonSaveHTMLTemplate.UseVisualStyleBackColor = true;
            this.buttonSaveHTMLTemplate.Click += new System.EventHandler(this.buttonSaveHTMLTemplate_Click);
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 377);
            this.Controls.Add(this.tabControlEditor);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewMain";
            this.Text = "Hagyma - Release 20210117";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControlEditor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PageTreeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TreeView treeViewPages;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Button buttonSavePage;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTestserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTestserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TabControl tabControlEditor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonSaveCSS;
        private System.Windows.Forms.TextBox textBoxCSS;
        private System.Windows.Forms.Button buttonSaveJS;
        private System.Windows.Forms.TextBox textBoxJS;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxHTMLTemplate;
        private System.Windows.Forms.Button buttonSaveHTMLTemplate;
    }
}

