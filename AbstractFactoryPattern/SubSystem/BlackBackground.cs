using AbstractFactoryPattern.SubSystemInterface;

namespace AbstractFactoryPattern.SubSystem
{
    public class BlackBackground : IBackground
    {
        public void ChangeColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Write(IColor color)
        {
            Console.WriteLine(color.WriteText());
        }
    }
}
