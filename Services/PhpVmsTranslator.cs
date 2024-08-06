using rACARS.Model.Configs;
using rACARS.Model.PhpVmsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace rACARS.Services
{
    class PhpVmsTranslator
    {
        private PhpVmsConnector connector;
        private JavaScriptSerializer _Serializer = new JavaScriptSerializer();
        private User user;
        public PhpVmsTranslator()
        {
            connector = new PhpVmsConnector();
        }

        public async Task<User> Connect()
        {
            return await GetUser();
        }

        public async Task<List<Bid>> GetBids(User user)
        {
            var response = await connector.PhpVmsRequest(ConfigModel.Url + "/api/user/bids", HttpMethod.Get, "");

            string responseText = await response.Content.ReadAsStringAsync();
            string aux = System.Text.RegularExpressions.Regex.Unescape(responseText);
            DataContainer<List<Bid>> serializedResult = _Serializer.Deserialize<DataContainer<List<Bid>>>(responseText);
            return serializedResult.data;
        }

        public async Task<User> GetUser()
        {
            var response = await connector.PhpVmsRequest(ConfigModel.Url + "/api/user", HttpMethod.Get, "");

            string responseText = await response.Content.ReadAsStringAsync();
            string aux = System.Text.RegularExpressions.Regex.Unescape(responseText);
            DataContainer<User> serializedResult = _Serializer.Deserialize<DataContainer<User>>(responseText);
            return serializedResult.data;
        }
         
    }
}
