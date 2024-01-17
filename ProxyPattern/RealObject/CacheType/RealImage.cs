using ProxyPattern.CommonInterface.CacheType;

namespace ProxyPattern.RealObject.CacheType
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImage();
        }

        public void Display()
        {
            Console.WriteLine($"Display Image :{_fileName}");
        }
        public void LoadImage()
        {
            Console.WriteLine($"Load Image {_fileName}");
        }
    }
}
