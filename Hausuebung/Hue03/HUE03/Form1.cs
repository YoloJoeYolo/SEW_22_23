namespace HUE03
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in dialog.FileNames)
                {
                    MessageBox.Show("You selected: " + file);
                }
            }
        }

        private void btnSelectOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = "C:\\";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.tbOutputPath.Text = dialog.SelectedPath;
                this.btnLoadFiles.Enabled = true;
            }
            else
            {
                this.tbOutputPath.Text = "Could not load any folder! Try again...";
            }
        }
    }
}