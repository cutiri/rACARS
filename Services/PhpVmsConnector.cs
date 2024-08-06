using rACARS.Model.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rACARS.Services
{
    class PhpVmsConnector
    {
        private HttpClient http = new HttpClient();
        public bool Connect()
        {
            return true;
        }

        public bool TestConnection()
        {
            return true;
        }

        public async Task<HttpResponseMessage> PhpVmsRequest(string url, HttpMethod method, string jsonContent)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = method;
            httpRequestMessage.RequestUri = new Uri(url);
            httpRequestMessage.Headers.Add("X-API-Key", ConfigModel.PhpVmsApiKey);
            //http.Timeout = TimeSpan.FromSeconds(1);

            if (method == HttpMethod.Post)
            {
                //Dictionary<string, string> values = new Dictionary<string, string>();
                HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                //HttpContent httpContent = new StringContent()
                httpRequestMessage.Content = httpContent;
            }
            return await http.SendAsync(httpRequestMessage);
        }

        public async Task<Object> Test()
        {
            return Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 9999999999; i++)
                {
                    int y = i;
                }
            });
        }
    }
}
