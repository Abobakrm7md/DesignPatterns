using AdapterPattern.Adaptee;
using AdapterPattern.AdapterInterface;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapters
{
    //Uses multiple inheritance to adapt one interface to another.
    public class AdapterClass : AdapteeCode, ITarget
    {
        public void Request(int id)
        {
            string json = JsonConvert.SerializeObject(id);
            SpeceficRequest(json);
        }
    }
}
