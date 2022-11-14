using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Diagnostics.Metrics;

namespace Hue01_Csharp
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private List<Measurment> measurments = new List<Measurment>();
        private String serverIdentifier = "-temperature measurement system werner-";
        private IPEndPoint receiveAdr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btReadData_Click(object sender, EventArgs e)
        {
            receiveAdr = new IPEndPoint(IPAddress.Any, int.Parse(this.nud_port.Value.ToString()));
            udpClient = new UdpClient(receiveAdr);
            this.ReceiveAsync();
            this.btReadData.Enabled = false;
        }

        private async void ReceiveAsync()   // async bedeutet, dass die Methode im Hintergrund ausgeführt wird
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                string value = Encoding.UTF8.GetString(result.Buffer);
                if (value.Contains(serverIdentifier))
                {
                    value = value.Substring(value.IndexOf(serverIdentifier) + serverIdentifier.Length, value.IndexOf("###") - value.IndexOf(serverIdentifier) - serverIdentifier.Length);
                    this.tbCurrentTemperature.Text = value;
                    measurments.Add(new Measurment(DateTime.Now, double.Parse(value.Replace(".", ","))));
                    double averageMeasurment = 0;

                    List<Measurment> newMeasurments = new List<Measurment>();
                    measurments.ForEach(measurment =>
                    {
                        if (measurment.Time.CompareTo(DateTime.Now.Subtract(new TimeSpan(0, 5, 0))) > 0)
                        {
                            newMeasurments.Add(measurment);
                            averageMeasurment += measurment.Value;
                        }
                    });
                    measurments = newMeasurments;

                    averageMeasurment = averageMeasurment/measurments.Count;
                    this.tbAverageTemperature.Text = averageMeasurment.ToString("0.00");
                }
            }
        }
    }
}