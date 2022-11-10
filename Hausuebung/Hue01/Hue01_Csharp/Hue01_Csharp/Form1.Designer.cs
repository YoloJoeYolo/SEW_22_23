namespace Hue01_Csharp
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
            this.lb_Port = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.btReadData = new System.Windows.Forms.Button();
            this.lbCurrentTemperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtbAverageTemperature = new System.Windows.Forms.Label();
            this.tbAverageTemperature = new System.Windows.Forms.TextBox();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.tbCurrentTemperature = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Port.Location = new System.Drawing.Point(12, 14);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(41, 21);
            this.lb_Port.TabIndex = 0;
            this.lb_Port.Text = "Port:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPort.Location = new System.Drawing.Point(12, 15);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(41, 21);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "Port:";
            // 
            // btReadData
            // 
            this.btReadData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReadData.Location = new System.Drawing.Point(206, 12);
            this.btReadData.Name = "btReadData";
            this.btReadData.Size = new System.Drawing.Size(105, 29);
            this.btReadData.TabIndex = 2;
            this.btReadData.Text = "Daten lesen";
            this.btReadData.UseVisualStyleBackColor = true;
            this.btReadData.Click += new System.EventHandler(this.btReadData_Click);
            // 
            // lbCurrentTemperature
            // 
            this.lbCurrentTemperature.AutoSize = true;
            this.lbCurrentTemperature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCurrentTemperature.Location = new System.Drawing.Point(12, 69);
            this.lbCurrentTemperature.Name = "lbCurrentTemperature";
            this.lbCurrentTemperature.Size = new System.Drawing.Size(152, 21);
            this.lbCurrentTemperature.TabIndex = 3;
            this.lbCurrentTemperature.Text = "Aktuelle Temperatur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "______________________________________________________________________\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtbAverageTemperature
            // 
            this.lbtbAverageTemperature.AutoSize = true;
            this.lbtbAverageTemperature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtbAverageTemperature.Location = new System.Drawing.Point(6, 104);
            this.lbtbAverageTemperature.Name = "lbtbAverageTemperature";
            this.lbtbAverageTemperature.Size = new System.Drawing.Size(158, 21);
            this.lbtbAverageTemperature.TabIndex = 5;
            this.lbtbAverageTemperature.Text = "Ø Temperatur (5min):";
            // 
            // tbAverageTemperature
            // 
            this.tbAverageTemperature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAverageTemperature.Location = new System.Drawing.Point(170, 101);
            this.tbAverageTemperature.Name = "tbAverageTemperature";
            this.tbAverageTemperature.ReadOnly = true;
            this.tbAverageTemperature.Size = new System.Drawing.Size(141, 29);
            this.tbAverageTemperature.TabIndex = 7;
            this.tbAverageTemperature.TabStop = false;
            // 
            // nud_port
            // 
            this.nud_port.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_port.Location = new System.Drawing.Point(59, 13);
            this.nud_port.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(141, 29);
            this.nud_port.TabIndex = 8;
            // 
            // tbCurrentTemperature
            // 
            this.tbCurrentTemperature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCurrentTemperature.Location = new System.Drawing.Point(170, 66);
            this.tbCurrentTemperature.Name = "tbCurrentTemperature";
            this.tbCurrentTemperature.ReadOnly = true;
            this.tbCurrentTemperature.Size = new System.Drawing.Size(141, 29);
            this.tbCurrentTemperature.TabIndex = 6;
            this.tbCurrentTemperature.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(322, 139);
            this.Controls.Add(this.nud_port);
            this.Controls.Add(this.tbAverageTemperature);
            this.Controls.Add(this.tbCurrentTemperature);
            this.Controls.Add(this.lbtbAverageTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCurrentTemperature);
            this.Controls.Add(this.btReadData);
            this.Controls.Add(this.lbPort);
            this.Name = "Form1";
            this.Text = "Temperaturlogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Port;
        private TextBox textBox1;
        private Label lbPort;
        private Button btReadData;
        private Label lbCurrentTemperature;
        private Label label1;
        private Label lbtbAverageTemperature;
        private TextBox tbAverageTemperature;
        private NumericUpDown nud_port;
        private TextBox tbCurrentTemperature;
    }
}