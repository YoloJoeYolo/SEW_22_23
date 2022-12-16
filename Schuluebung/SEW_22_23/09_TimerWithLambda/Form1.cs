namespace _09_TimerWithLambda
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            // events als Lambda Expressions
            this.btn_start.Click += (sender, e) => this.timer.Start();
            this.btn_Stop.Click += (sender, e) => this.timer.Stop();
            this.timer.Tick += (sender, e) => this.txt_counter.Text = this.counter++.ToString();
        }
    }
}