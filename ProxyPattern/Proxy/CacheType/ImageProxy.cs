using ProxyPattern.CommonInterface.CacheType;
using ProxyPattern.RealObject.CacheType;

namespace ProxyPattern.Proxy.CacheType
{

    public class ImageProxy : IImage
    {
        private string _fileName;
        private RealImage _realImage = null;
        private static Dictionary<string, RealImage> _realImageCach = new Dictionary<string, RealImage>();

        public ImageProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                if (_realImageCach.ContainsKey(_fileName))
                {
                    _realImage = _realImageCach[_fileName];
                }
                else
                {
                    _realImage = new RealImage(_fileName);
                    _realImageCach.Add(_fileName, _realImage);
                }
            }
            _realImage.Display();
        }
    }
}
