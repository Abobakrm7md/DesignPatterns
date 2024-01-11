using Newtonsoft.Json;
using RestSharp;
using StrategyPattern.ResponseModel;
using StrategyPattern.StrategyInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategiesAlgorithmes
{
    public class SearchImagesAlgorithm : ISearchStrategy
    {
        public T BuildSearchResult<T>(string query) where T : class
        {
            string url = "https://google.serper.dev/images";
            string key = "91d904e4ae5d762c7abbe5ebac6c03258cb0260c";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("X-API-KEY", key);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{""q"":""Itworx education""}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            var response = client.Execute(request);
            var places = JsonConvert.DeserializeObject<T>(response.Content);
            return places;
        }
    }
}
