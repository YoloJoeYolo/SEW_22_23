namespace HUE03
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
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.btnSelectOutputPath = new System.Windows.Forms.Button();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.tbInformation = new System.Windows.Forms.TextBox();
            this.nudParallelAnalyses = new System.Windows.Forms.NumericUpDown();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lbProgressBar = new System.Windows.Forms.Label();
            this.lbNummberOfThreads = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudParallelAnalyses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Enabled = false;
            this.btnLoadFiles.Location = new System.Drawing.Point(14, 16);
            this.btnLoadFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(171, 53);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // btnSelectOutputPath
            // 
            this.btnSelectOutputPath.Location = new System.Drawing.Point(336, 16);
            this.btnSelectOutputPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectOutputPath.Name = "btnSelectOutputPath";
            this.btnSelectOutputPath.Size = new System.Drawing.Size(171, 53);
            this.btnSelectOutputPath.TabIndex = 1;
            this.btnSelectOutputPath.Text = "Select output path";
            this.btnSelectOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputPath.Click += new System.EventHandler(this.btnSelectOutputPath_Click);
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputPath.Location = new System.Drawing.Point(514, 16);
            this.tbOutputPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOutputPath.Multiline = true;
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.PlaceholderText = "Shows output path";
            this.tbOutputPath.ReadOnly = true;
            this.tbOutputPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbOutputPath.Size = new System.Drawing.Size(386, 52);
            this.tbOutputPath.TabIndex = 4;
            this.tbOutputPath.TabStop = false;
            this.tbOutputPath.WordWrap = false;
            // 
            // tbInformation
            // 
            this.tbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInformation.Location = new System.Drawing.Point(14, 141);
            this.tbInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInformation.Multiline = true;
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.PlaceholderText = "Shows information";
            this.tbInformation.ReadOnly = true;
            this.tbInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInformation.Size = new System.Drawing.Size(884, 446);
            this.tbInformation.TabIndex = 5;
            this.tbInformation.TabStop = false;
            this.tbInformation.WordWrap = false;
            // 
            // nudParallelAnalyses
            // 
            this.nudParallelAnalyses.Location = new System.Drawing.Point(193, 42);
            this.nudParallelAnalyses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudParallelAnalyses.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudParallelAnalyses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParallelAnalyses.Name = "nudParallelAnalyses";
            this.nudParallelAnalyses.Size = new System.Drawing.Size(137, 27);
            this.nudParallelAnalyses.TabIndex = 6;
            this.nudParallelAnalyses.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.ForeColor = System.Drawing.Color.Lime;
            this.pb.Location = new System.Drawing.Point(14, 105);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(886, 29);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.TabIndex = 7;
            // 
            // lbProgressBar
            // 
            this.lbProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.lbProgressBar.Location = new System.Drawing.Point(14, 73);
            this.lbProgressBar.Name = "lbProgressBar";
            this.lbProgressBar.Size = new System.Drawing.Size(886, 29);
            this.lbProgressBar.TabIndex = 8;
            this.lbProgressBar.Text = "No files have been selected yet";
            this.lbProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNummberOfThreads
            // 
            this.lbNummberOfThreads.AutoSize = true;
            this.lbNummberOfThreads.Location = new System.Drawing.Point(193, 19);
            this.lbNummberOfThreads.Name = "lbNummberOfThreads";
            this.lbNummberOfThreads.Size = new System.Drawing.Size(116, 20);
            this.lbNummberOfThreads.TabIndex = 9;
            this.lbNummberOfThreads.Text = "Parallel analyses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lbNummberOfThreads);
            this.Controls.Add(this.lbProgressBar);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.nudParallelAnalyses);
            this.Controls.Add(this.tbInformation);
            this.Controls.Add(this.tbOutputPath);
            this.Controls.Add(this.btnSelectOutputPath);
            this.Controls.Add(this.btnLoadFiles);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "frequency analysis";
            ((System.ComponentModel.ISupportInitialize)(this.nudParallelAnalyses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoadFiles;
        private Button btnSelectOutputPath;
        private TextBox tbOutputPath;
        private TextBox tbInformation;
        private NumericUpDown nudParallelAnalyses;
        private ProgressBar pb;
        private Label lbProgressBar;
        private Label lbNummberOfThreads;
    }
}