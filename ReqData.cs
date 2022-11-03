using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIreq
{
    class ReqData
    {
        private String apiKey = "9749f1751c31747548c80994825b65f0";

        private String version = "2.5";

        private String callType = "onecall";

        private String latPos = "43.11";
        private String lonPos = "12.39";

        public async Task<String> getWeatherData()
        {
            HttpClient client = new HttpClient();
            String responseString = "";
            try
            {
                responseString = await client.GetStringAsync(
                    $"https://api.openweathermap.org/data/{version}/{callType}?lat={latPos}&lon={lonPos}&exclude=minutely,alerts&appid={apiKey}"
                );
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return responseString;
        }
    }
}
