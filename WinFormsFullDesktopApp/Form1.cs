namespace WinFormsFullDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            itemFileCreate.Image = Image.FromFile("filecreate.png");
            itemFileOpen.ShortcutKeys = Keys.Control | Keys.O;

            ToolStripMenuItem itemHelp = new();
            itemHelp.Text = "Помощь";
            menuMain.Items.Add(itemHelp);

            ToolStripMenuItem itemEditFont = new ToolStripMenuItem();
            ToolStripMenuItem itemEditColor = new ToolStripMenuItem();
            ToolStripSeparator separator = new ToolStripSeparator();
            ToolStripMenuItem itemEditBuffer = new ToolStripMenuItem();
            itemEditFont.Text = "Шрифт...";
            itemEditColor.Text = "Цвет...";
            itemEditBuffer.Text = "Буфер";

            ToolStripMenuItem itemEditBufferCopy = new ToolStripMenuItem();
            itemEditBufferCopy.Text = "Копировать";
            itemEditBufferCopy.ShortcutKeys = Keys.Control | Keys.C;
            itemEditBuffer.DropDownItems.Add(itemEditBufferCopy);

            ToolStripMenuItem itemContextEditBufferCopy = new();
            itemContextEditBufferCopy.Text = "Копировать";
            itemContextEditBufferCopy.ShortcutKeys = Keys.Control | Keys.C;
            contextBuffer.Items.Add(itemContextEditBufferCopy);

            itemEdit.DropDownItems.AddRange(new ToolStripItem[]
            {
                itemEditFont, itemEditColor, separator, itemEditBuffer
            });

            ToolStripButton toolFileOpen = new ToolStripButton();
            toolFileOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolFileOpen.Image = Image.FromFile("fileopen.png");
            toolFileOpen.Click += itemFileOpen_Click;
            toolMain.Items.Add(toolFileOpen);

            toolMain.Items.Add(new ToolStripSeparator());

        }


        private void itemFileOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void itemFileCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Create");
        }
    }
}