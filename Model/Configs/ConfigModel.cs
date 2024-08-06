using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rACARS.Model.Configs
{
    class ConfigModel
    {
        private static string _tempApiKey = "7cc873a5fc19f4276831";
        private static string _baseUrl = "http://localhost/phpvms";
        public static string PhpVmsApiKey { get { return _tempApiKey; } set { _tempApiKey = value; } }
        public static string Url { get { return _baseUrl; } set { _baseUrl = value; } }
    }
}
