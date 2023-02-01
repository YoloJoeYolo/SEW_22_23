using System.Diagnostics.Metrics;
using System.Reflection;
using System.Windows.Forms;

namespace HUE03
{
    public partial class Form1 : Form
    {

        int numberOfCurrentTasks = 0;
        int numberOfFiles = 0;
        int numberOfAnalyzedFiles = 0;

        List<string> queue = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select files to analyze";
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in dialog.FileNames)
                {
                    this.numberOfFiles++;
                    if (this.numberOfCurrentTasks < this.nudParallelAnalyses.Value)
                    {
                        Interlocked.Increment(ref this.numberOfCurrentTasks);
                        Task.Run(() => AnalyzeFile(file));
                    }
                    else
                        this.queue.Add(file);
                }
                UpdateProgressBar();
            }
        }

        public void AnalyzeFile(string file)
        {
            if (File.Exists(file))
            {
                string filename = Path.GetFileName(file);
                string[] lines = File.ReadAllLines(file);

                Dictionary<char, int> frequency = FrequencyAnalysis(lines, filename);

                File.WriteAllText(this.tbOutputPath.Text + filename, "frequency analysis for the file '" + filename + "'\n\n");
                foreach (KeyValuePair<char, int> character in frequency)
                {
                    File.AppendAllText(this.tbOutputPath.Text + filename, character.Key + ": " + character.Value + "\n");
                }
                

                this.numberOfAnalyzedFiles++;
                UpdateProgressBar();
                Interlocked.Decrement(ref this.numberOfCurrentTasks);

                if (this.queue.Count > 0 && this.numberOfCurrentTasks < this.nudParallelAnalyses.Value)
                {
                    Interlocked.Increment(ref this.numberOfCurrentTasks);
                    string temp = this.queue.ElementAt(0); 
                    this.queue.Remove(temp);
                    Task.Run(() => AnalyzeFile(temp));
                }
            }
            else
            {
                this.numberOfFiles--;
                UpdateProgressBar();
                WriteInformation(String.Format("[ERROR] File with the path '{0}' could not be found!", file));
            }
        }

        public Dictionary<char, int> FrequencyAnalysis(string[] lines, string filename)
        {
            WriteInformation(String.Format("[INFO] The frequency analysis for the file '{0}' got startet.", filename));

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            for(int i = 0; i < lines.Length - 1; i++)
            {
                foreach(char character in lines[i])
                {
                    if (frequency.ContainsKey(character))
                        frequency[character]++;
                    else
                        frequency[character] = 1;
                }
            }
            WriteInformation(String.Format("[INFO] The frequency analysis for the file '{0}' is finished.", filename));
            return frequency;
        }

        private void btnSelectOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select a folder to save the results";
            dialog.UseDescriptionForTitle = true;
            dialog.InitialDirectory = "C:\\";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.tbOutputPath.Text = dialog.SelectedPath + "\\";
                this.btnLoadFiles.Enabled = true;
            }
            else
            {
                this.btnLoadFiles.Enabled = false;
                this.tbOutputPath.Text = "Could not load any folder! Try again...";
            }
        }

        private void WriteInformation(string message)
        {
            var threadParameters = new System.Threading.ThreadStart(delegate { WriteInformationThreadSave(message + Environment.NewLine);}) ;
            var thread = new System.Threading.Thread(threadParameters);
            thread.Start();
        }

        private void WriteInformationThreadSave(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteInformationThreadSave), new object[] { message });
            }
            else
            {
                this.tbInformation.Text = message + this.tbInformation.Text;
            }
        }

        private void UpdateProgressBar()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateProgressBar));
            }
            else
            {
                this.lbProgressBar.Text = this.numberOfAnalyzedFiles + " / " + this.numberOfFiles + " Files got analyzed";
                this.pb.Value = int.Parse(Math.Round((double)this.numberOfAnalyzedFiles / this.numberOfFiles * 100).ToString());
            }
        }
    }
}