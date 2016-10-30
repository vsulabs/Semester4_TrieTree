namespace TrieTree
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClearResult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCondition = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileD = new System.Windows.Forms.OpenFileDialog();
            this.saveFileD = new System.Windows.Forms.SaveFileDialog();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlOutPut = new System.Windows.Forms.Panel();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnRun = new System.Windows.Forms.ToolStripButton();
            this.tsBtnTask = new System.Windows.Forms.ToolStripButton();
            this.msMenu.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlOutPut.SuspendLayout();
            this.tsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmEdit,
            this.taskToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(558, 24);
            this.msMenu.TabIndex = 2;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNew,
            this.tsmOpen,
            this.tsmSave,
            this.tsmSaveAs,
            this.tsmClose,
            this.toolStripSeparator1,
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(40, 20);
            this.tsmFile.Text = "FILE";
            // 
            // tsmNew
            // 
            this.tsmNew.Image = global::TrieTree.Properties.Resources.add;
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmNew.Size = new System.Drawing.Size(195, 22);
            this.tsmNew.Text = "New";
            this.tsmNew.Click += new System.EventHandler(this.tsmNew_Click);
            // 
            // tsmOpen
            // 
            this.tsmOpen.Image = global::TrieTree.Properties.Resources.folder;
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmOpen.Size = new System.Drawing.Size(195, 22);
            this.tsmOpen.Text = "Open...";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Image = global::TrieTree.Properties.Resources.save;
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmSave.Size = new System.Drawing.Size(195, 22);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmSaveAs.Size = new System.Drawing.Size(195, 22);
            this.tsmSaveAs.Text = "Save As...";
            this.tsmSaveAs.Click += new System.EventHandler(this.tsmSaveAs_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.Image = global::TrieTree.Properties.Resources.close;
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(195, 22);
            this.tsmClose.Text = "Close";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Image = global::TrieTree.Properties.Resources.power;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(195, 22);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmSearch,
            this.tsmDelete,
            this.toolStripSeparator2,
            this.tsmClear});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(43, 20);
            this.tsmEdit.Text = "EDIT";
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::TrieTree.Properties.Resources.down;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmAdd.Size = new System.Drawing.Size(158, 22);
            this.tsmAdd.Text = "Add...";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmSearch
            // 
            this.tsmSearch.Image = global::TrieTree.Properties.Resources.search;
            this.tsmSearch.Name = "tsmSearch";
            this.tsmSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmSearch.Size = new System.Drawing.Size(158, 22);
            this.tsmSearch.Text = "Search...";
            this.tsmSearch.Click += new System.EventHandler(this.tsmSearch_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::TrieTree.Properties.Resources.delete;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(158, 22);
            this.tsmDelete.Text = "Delete...";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmClear
            // 
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(158, 22);
            this.tsmClear.Text = "Clear";
            this.tsmClear.Click += new System.EventHandler(this.tsmClear_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRun,
            this.tsmClearResult,
            this.tsmSaveResult,
            this.toolStripSeparator5,
            this.tsmCondition});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.taskToolStripMenuItem.Text = "TASK";
            // 
            // tsmRun
            // 
            this.tsmRun.Image = global::TrieTree.Properties.Resources.success;
            this.tsmRun.Name = "tsmRun";
            this.tsmRun.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.tsmRun.Size = new System.Drawing.Size(146, 22);
            this.tsmRun.Text = "Run";
            this.tsmRun.Click += new System.EventHandler(this.tsmRun_Click);
            // 
            // tsmClearResult
            // 
            this.tsmClearResult.Name = "tsmClearResult";
            this.tsmClearResult.Size = new System.Drawing.Size(146, 22);
            this.tsmClearResult.Text = "Clear Result";
            this.tsmClearResult.Click += new System.EventHandler(this.tsmClearResult_Click);
            // 
            // tsmSaveResult
            // 
            this.tsmSaveResult.Name = "tsmSaveResult";
            this.tsmSaveResult.Size = new System.Drawing.Size(146, 22);
            this.tsmSaveResult.Text = "Save Result";
            this.tsmSaveResult.Click += new System.EventHandler(this.tsmSaveResult_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(143, 6);
            // 
            // tsmCondition
            // 
            this.tsmCondition.Image = global::TrieTree.Properties.Resources.information;
            this.tsmCondition.Name = "tsmCondition";
            this.tsmCondition.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmCondition.Size = new System.Drawing.Size(146, 22);
            this.tsmCondition.Text = "Condition";
            this.tsmCondition.Click += new System.EventHandler(this.tsmCondition_Click);
            // 
            // openFileD
            // 
            this.openFileD.FileName = "openFileDialog1";
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "cancel.png");
            this.ilIcons.Images.SetKeyName(1, "close.png");
            this.ilIcons.Images.SetKeyName(2, "delete.png");
            this.ilIcons.Images.SetKeyName(3, "down.png");
            this.ilIcons.Images.SetKeyName(4, "information.png");
            this.ilIcons.Images.SetKeyName(5, "save.png");
            this.ilIcons.Images.SetKeyName(6, "success.png");
            this.ilIcons.Images.SetKeyName(7, "edit.png");
            this.ilIcons.Images.SetKeyName(8, "folder.png");
            this.ilIcons.Images.SetKeyName(9, "search.png");
            // 
            // tbInput
            // 
            this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(0, 0);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(258, 340);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOutput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(0, 0);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(255, 312);
            this.tbOutput.TabIndex = 0;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.AutoSize = true;
            this.pnlInput.Controls.Add(this.tbInput);
            this.pnlInput.Location = new System.Drawing.Point(0, 52);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(258, 340);
            this.pnlInput.TabIndex = 0;
            // 
            // pnlOutPut
            // 
            this.pnlOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutPut.Controls.Add(this.tbOutput);
            this.pnlOutPut.Location = new System.Drawing.Point(297, 52);
            this.pnlOutPut.Name = "pnlOutPut";
            this.pnlOutPut.Size = new System.Drawing.Size(255, 312);
            this.pnlOutPut.TabIndex = 1;
            // 
            // tsTools
            // 
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnOpen,
            this.tsBtnSave,
            this.tsBtnClose,
            this.toolStripSeparator3,
            this.tsBtnAdd,
            this.tsBtnSearch,
            this.tsBtnDelete,
            this.toolStripSeparator4,
            this.tsBtnRun,
            this.tsBtnTask});
            this.tsTools.Location = new System.Drawing.Point(0, 24);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(558, 25);
            this.tsTools.TabIndex = 3;
            this.tsTools.Text = "toolStrip1";
            // 
            // tsBtnOpen
            // 
            this.tsBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnOpen.Image = global::TrieTree.Properties.Resources.folder;
            this.tsBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpen.Name = "tsBtnOpen";
            this.tsBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tsBtnOpen.Text = "Open";
            this.tsBtnOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = global::TrieTree.Properties.Resources.save;
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "Save";
            this.tsBtnSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnClose.Image = global::TrieTree.Properties.Resources.close;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(23, 22);
            this.tsBtnClose.Text = "Close";
            this.tsBtnClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAdd.Image = global::TrieTree.Properties.Resources.down;
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.tsBtnAdd.Text = "Add";
            this.tsBtnAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsBtnSearch
            // 
            this.tsBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSearch.Image = global::TrieTree.Properties.Resources.search;
            this.tsBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearch.Name = "tsBtnSearch";
            this.tsBtnSearch.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSearch.Text = "Search";
            this.tsBtnSearch.Click += new System.EventHandler(this.tsmSearch_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelete.Image = global::TrieTree.Properties.Resources.delete;
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelete.Text = "Delete";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnRun
            // 
            this.tsBtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRun.Image = global::TrieTree.Properties.Resources.success;
            this.tsBtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRun.Name = "tsBtnRun";
            this.tsBtnRun.Size = new System.Drawing.Size(23, 22);
            this.tsBtnRun.Text = "Run";
            this.tsBtnRun.Click += new System.EventHandler(this.tsmRun_Click);
            // 
            // tsBtnTask
            // 
            this.tsBtnTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnTask.Image = global::TrieTree.Properties.Resources.information;
            this.tsBtnTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTask.Name = "tsBtnTask";
            this.tsBtnTask.Size = new System.Drawing.Size(23, 22);
            this.tsBtnTask.Text = "Condition";
            this.tsBtnTask.Click += new System.EventHandler(this.tsmCondition_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 361);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlOutPut);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmMain";
            this.Text = "Задание 1 номер 15";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlOutPut.ResumeLayout(false);
            this.pnlOutPut.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileD;
        private System.Windows.Forms.SaveFileDialog saveFileD;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.ToolStripMenuItem tsmNew;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmClear;
        private System.Windows.Forms.ToolStripMenuItem tsmRun;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveResult;
        private System.Windows.Forms.ToolStripMenuItem tsmClearResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlOutPut;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsBtnOpen;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.ToolStripButton tsBtnSearch;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.ToolStripButton tsBtnTask;
        private System.Windows.Forms.ToolStripButton tsBtnRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmCondition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

