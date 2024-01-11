using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ResponseModel
{
        public class PlacesObject : IResponse
        {
            public Searchparameters searchParameters { get; set; }
            public Place[] places { get; set; }
        }

        public class Searchparameters
        {
            public string q { get; set; }
            public string gl { get; set; }
            public string hl { get; set; }
            public int num { get; set; }
            public bool autocorrect { get; set; }
            public int page { get; set; }
            public string type { get; set; }
            public string engine { get; set; }
        }

        public class Place
        {
            public int position { get; set; }
            public string title { get; set; }
            public string address { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public float rating { get; set; }
            public int ratingCount { get; set; }
            public string category { get; set; }
            public string phoneNumber { get; set; }
            public string website { get; set; }
            public string cid { get; set; }
        }
}
