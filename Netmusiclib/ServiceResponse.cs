using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netmusiclib
{
    public class ServiceResponse<T>
    {
        public ServiceResponse() { }
        public T? Value { get; set; }= default(T?);

        public string Reason { get; set; } = string.Empty;

        public bool Status { get; set; }=false;


    }
}
