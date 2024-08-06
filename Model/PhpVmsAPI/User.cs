using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rACARS.Model.PhpVmsAPI
{
    public class User
    {
        public string id { get; set; }
        public string name { get; set; }

        public void DoSomething()
        {
            name = name.ToLower();
        }
    }
}
