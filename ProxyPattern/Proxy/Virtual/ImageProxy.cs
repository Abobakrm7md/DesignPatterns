using ProxyPattern.CommonInterface.CacheType;
using ProxyPattern.RealObject.CacheType;

namespace ProxyPattern.Proxy.Virtual
{

    public class ImageProxy : IImage
    {
        private string _fileName;
        private RealImage _realImage = null;

        public ImageProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }
}
