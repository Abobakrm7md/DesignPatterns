using AbstractFactoryPattern.SubSystemInterface;

namespace AbstractFactoryPattern.SubSystem
{
    public class BlackColor : IColor
    {
        public void ChangeColor()
        {
            Console.ForegroundColor = ConsoleColor.Black; 
        }

        public string WriteText()
        {
            return "Black Text White BackGroung Concretes Classes";
        }
    }
}
