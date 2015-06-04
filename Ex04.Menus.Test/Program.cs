using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            new TimeAndInfoIterface().run();
            new TimeAndInfoDelegate().run();
        }
    }
}