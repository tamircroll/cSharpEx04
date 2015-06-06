using Ex04.Menus.Interfaces;
using Ex04.Menus.Test.Interface;

namespace Ex04.Menus.Test
{
    public class IterfaceTest
    {
        public void run()
        {
            ShowTime showTime = new ShowTime();
            ShowDate showDate = new ShowDate();
            ShowVersion showVersion = new ShowVersion();
            CountWords countWords = new CountWords();
            Menu showTimeAndDateMenu = new Menu("Show Time/Date", showTime, showDate);
            Menu info = new Menu("Info", showVersion, countWords);
            MainMenu mainMenu = new MainMenu(showTimeAndDateMenu, info);
            
            mainMenu.Show();
        }
    }
}
