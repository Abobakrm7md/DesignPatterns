using AdapterPattern.Adaptee;
using AdapterPattern.AdapterInterface;
using Newtonsoft.Json;

namespace AdapterPattern.Adapters
{
    public class AdapterObject : ITarget
    {
        private readonly AdapteeCode adaptee;

        public AdapterObject(AdapteeCode adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Request(int id)
        {
            string json = JsonConvert.SerializeObject(id);
            adaptee.SpeceficRequest(json);
        }
    }
}
