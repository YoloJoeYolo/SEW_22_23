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
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Enabled = false;
            this.btnLoadFiles.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(150, 40);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // btnSelectOutputPath
            // 
            this.btnSelectOutputPath.Location = new System.Drawing.Point(168, 12);
            this.btnSelectOutputPath.Name = "btnSelectOutputPath";
            this.btnSelectOutputPath.Size = new System.Drawing.Size(150, 40);
            this.btnSelectOutputPath.TabIndex = 1;
            this.btnSelectOutputPath.Text = "Select output path";
            this.btnSelectOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectOutputPath.Click += new System.EventHandler(this.btnSelectOutputPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(324, 12);
            this.tbOutputPath.Multiline = true;
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.PlaceholderText = "Shows output path";
            this.tbOutputPath.ReadOnly = true;
            this.tbOutputPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbOutputPath.Size = new System.Drawing.Size(464, 40);
            this.tbOutputPath.TabIndex = 4;
            this.tbOutputPath.TabStop = false;
            this.tbOutputPath.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Shows information";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(300, 380);
            this.textBox1.TabIndex = 5;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbOutputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectOutputPath);
            this.Controls.Add(this.btnLoadFiles);
            this.Name = "Form1";
            this.Text = "frequency analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoadFiles;
        private Button btnSelectOutputPath;
        private Label label2;
        private TextBox tbOutputPath;
        private TextBox textBox1;
    }
}