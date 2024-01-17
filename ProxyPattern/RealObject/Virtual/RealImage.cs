using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.RealObject.Virtual
{
    public class RealImage
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
