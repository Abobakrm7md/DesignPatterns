using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
    //This is the class that has the interface the client can't use directly.
    public class AdapteeCode
    {
        public void SpeceficRequest(string obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
