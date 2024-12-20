using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ht
{
    internal class Web_site
    {
        private string name = "Noname";
        private string url = "No url";
        private string description = "None";
        private string ipAddress = "No ip adress";


        public Web_site(string name, string url, string description, string ipAddress)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ipAddress = ipAddress;
        }

        public void SetName(string name) => this.name = name;
        public void SetUrl(string url) => this.url = url;
        public void SetDescription(string description) => this.description = description;
        public void SetIpAddress(string ipAddress) => this.ipAddress = ipAddress;

        public string GetName() => name;
        public string GetUrl() => url;
        public string GetDescription() => description;
        public string GetIpAddress() => ipAddress;

        public void print()
        {
            Console.WriteLine($"Web site name :: {name}");
            Console.WriteLine($"Web site url :: {url}");
            Console.WriteLine($"Web site description :: {description}");
            Console.WriteLine($"Web site ip address :: {ipAddress}");
        }
    }
}
