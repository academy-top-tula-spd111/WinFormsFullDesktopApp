namespace WinFormsFullDesktopApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditor = new System.Windows.Forms.TextBox();
            this.contextBuffer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.toolFileCreate = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemEdit});
            this.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 23);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFileCreate,
            this.itemFileOpen,
            this.itemFileSave,
            this.itemFileSaveAs,
            this.itemFileClose,
            this.toolStripMenuItem1,
            this.itemExit});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(48, 19);
            this.itemFile.Text = "Файл";
            // 
            // itemFileCreate
            // 
            this.itemFileCreate.Name = "itemFileCreate";
            this.itemFileCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itemFileCreate.Size = new System.Drawing.Size(160, 22);
            this.itemFileCreate.Text = "Создать";
            // 
            // itemFileOpen
            // 
            this.itemFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("itemFileOpen.Image")));
            this.itemFileOpen.Name = "itemFileOpen";
            this.itemFileOpen.Size = new System.Drawing.Size(160, 22);
            this.itemFileOpen.Text = "Открыть";
            this.itemFileOpen.Click += new System.EventHandler(this.itemFileOpen_Click);
            // 
            // itemFileSave
            // 
            this.itemFileSave.Name = "itemFileSave";
            this.itemFileSave.Size = new System.Drawing.Size(160, 22);
            this.itemFileSave.Text = "Сохранить";
            // 
            // itemFileSaveAs
            // 
            this.itemFileSaveAs.Name = "itemFileSaveAs";
            this.itemFileSaveAs.Size = new System.Drawing.Size(160, 22);
            this.itemFileSaveAs.Text = "Сохранить как";
            // 
            // itemFileClose
            // 
            this.itemFileClose.Name = "itemFileClose";
            this.itemFileClose.Size = new System.Drawing.Size(160, 22);
            this.itemFileClose.Text = "Закрыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(160, 22);
            this.itemExit.Text = "Выход";
            // 
            // itemEdit
            // 
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(59, 19);
            this.itemEdit.Text = "Правка";
            // 
            // textEditor
            // 
            this.textEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditor.ContextMenuStrip = this.contextBuffer;
            this.textEditor.Location = new System.Drawing.Point(0, 51);
            this.textEditor.Multiline = true;
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(800, 374);
            this.textEditor.TabIndex = 1;
            // 
            // contextBuffer
            // 
            this.contextBuffer.Name = "contextBuffer";
            this.contextBuffer.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // toolMain
            // 
            this.toolMain.CanOverflow = false;
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileCreate});
            this.toolMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolMain.Location = new System.Drawing.Point(0, 23);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(800, 25);
            this.toolMain.TabIndex = 2;
            this.toolMain.Text = "toolStrip1";
            // 
            // toolFileCreate
            // 
            this.toolFileCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFileCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolFileCreate.Image")));
            this.toolFileCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFileCreate.Name = "toolFileCreate";
            this.toolFileCreate.Size = new System.Drawing.Size(23, 22);
            this.toolFileCreate.Text = "toolStripButton1";
            this.toolFileCreate.Click += new System.EventHandler(this.itemFileCreate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuMain;
        private ToolStripMenuItem itemFile;
        private ToolStripMenuItem itemFileOpen;
        private ToolStripMenuItem itemFileSave;
        private ToolStripMenuItem itemFileSaveAs;
        private ToolStripMenuItem itemFileClose;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem itemExit;
        private ToolStripMenuItem itemEdit;
        private TextBox textEditor;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem itemFileCreate;
        private ToolStrip toolMain;
        private ToolStripButton toolFileCreate;
        private ContextMenuStrip contextBuffer;
        private StatusStrip statusStrip1;
    }
}