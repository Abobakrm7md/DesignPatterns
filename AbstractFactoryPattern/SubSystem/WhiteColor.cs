using AbstractFactoryPattern.SubSystemInterface;

namespace AbstractFactoryPattern.SubSystem
{
    public class WhiteColor : IColor
    {
        public void ChangeColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string WriteText()
        {
            return "White Text White Background Concretes Classes";
        }
    }
}
