using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.SubSystemInterface
{
    public interface IBackground
    {
        void ChangeColor();
        void Write(IColor color);
    }
}
