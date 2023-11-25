namespace simulador_notepad_desafio
{
    public partial class Form1 : Form
    {

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private TextBox textBox;

        public Form1()
        {
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem("Arquivo");
            newMenuItem = new ToolStripMenuItem("Novo");
            openMenuItem = new ToolStripMenuItem("Abrir");
            saveMenuItem = new ToolStripMenuItem("Salvar");
            textBox = new TextBox();

            newMenuItem.Click += (sender, e) => { textBox.Clear(); };
            openMenuItem.Click += (sender, e) => { OpenFile(); };
            saveMenuItem.Click += (sender, e) => { SaveFile(); };

            fileMenu.DropDownItems.Add(newMenuItem);
            fileMenu.DropDownItems.Add(openMenuItem);
            fileMenu.DropDownItems.Add(saveMenuItem);
            menuStrip.Items.Add(fileMenu);

            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;

            Controls.Add(textBox);
            Controls.Add(menuStrip);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void SaveFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }
            }
        }
    }
}