using AbstractFactoryPattern.FactoryInterface;
using AbstractFactoryPattern.SubSystem;
using AbstractFactoryPattern.SubSystemInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    public class AbstractFactory2 : IFactory
    {
        public IBackground CreateBackground()
        {
           return new WhiteBackground();
        }

        public IColor CreateColor()
        {
            return new BlackColor();
        }
    }
}
