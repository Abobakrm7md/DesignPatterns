using AbstractFactoryPattern.SubSystemInterface;

namespace AbstractFactoryPattern.SubSystem
{
    public class WhiteBackground : IBackground
    {
        public void ChangeColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }

        public void Write(IColor color)
        {
            Console.WriteLine(color.WriteText());
        }
    }
}
