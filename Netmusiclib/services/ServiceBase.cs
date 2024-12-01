using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using Netmusiclib;
namespace Netmusiclib.services
{
    public class ServiceBase
    {
        internal string jsonpath = Path.Combine(Directory.GetCurrentDirectory(), "Api.json");

        internal string path1 = AppDomain.CurrentDomain.BaseDirectory;

        internal string path2= Directory.GetCurrentDirectory();

        internal string asym = Assembly.GetExecutingAssembly().Location;
        internal Stream stream { get; set; }

        public ServiceBase() { 
        
            this.stream = File.OpenRead(jsonpath);
        }
        internal API? GetApi()
        {
            try
            {
                API? apidict = JsonSerializer.Deserialize<API>(stream);
                return apidict;
            }
            catch (Exception ex) {
                return null;
            }
            
        }
       
    }
}
