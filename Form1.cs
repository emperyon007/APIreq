using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace APIreq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void reqButton_Click(object sender, EventArgs e)
        {
            var request = new ReqData();
            String output = await request.getWeatherData();
            FormatData parsed = JsonConvert.DeserializeObject<FormatData>(output);
            string json = JsonConvert.SerializeObject(parsed, Formatting.Indented);
            Console.WriteLine(parsed.Current.Weather);

            //outputTextbox.Text = Helper.ConvertUnixTimeStamp(parsed.Current.Dt).Value.ToString("MM/dd/yyyy hh:mm tt z");
            //outputTextbox.Text = parsed.Current.CurrentWeather.Description;
        }

        private async void exportButton_Click(object sender, EventArgs e)
        {
            /*
            if(outputTextbox.Text != "")
            {
                await File.WriteAllTextAsync("WriteText.txt", outputTextbox.Text);
                MessageBox.Show("Data exported successfully");
            }
            else
            {
                MessageBox.Show("Data output empty");
            }
            */
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //outputTextbox.Text = "";    
        }
    }
}
