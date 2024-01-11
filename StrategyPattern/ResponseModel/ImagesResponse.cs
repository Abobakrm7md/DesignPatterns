using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ResponseModel
{
        public class ImagesResponse
        {
            public SearchImagesparameters searchParameters { get; set; }
            public Image[] images { get; set; }
        }

        public class SearchImagesparameters
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

        public class Image
        {
            public string title { get; set; }
            public string imageUrl { get; set; }
            public int imageWidth { get; set; }
            public int imageHeight { get; set; }
            public string thumbnailUrl { get; set; }
            public int thumbnailWidth { get; set; }
            public int thumbnailHeight { get; set; }
            public string source { get; set; }
            public string domain { get; set; }
            public string link { get; set; }
            public string googleUrl { get; set; }
            public int position { get; set; }
        }
}
