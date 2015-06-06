using Ex04.Menus.Delegates;
using Ex04.Menus.Test.Delegate;

namespace Ex04.Menus.Test
{
   public class DelegateTest
    {
       public void run()
       {
           ShowDateAndTime showTimeAndDate = new ShowDateAndTime();
           ShowInfo showInfo = new ShowInfo();
           Menu timeAndDateMenu = new Menu("Show Date/Time");
           Menu showInfoMenu = new Menu("Info");
           MenuItem showTime = new MenuItem("Show Time", showTimeAndDate.ShowTime_ItemChosen);
           MenuItem showDate = new MenuItem("Show Date", showTimeAndDate.ShowDate_ItemChosen);
           MenuItem showVersion = new MenuItem("Show Version", showInfo.ShowVersion_ItemChosen);
           MenuItem countWords = new MenuItem("Count Words", showInfo.CountWords_ItemChosen);
           MenuItem showTimeAndDateMenuItem = new MenuItem(timeAndDateMenu.Title, timeAndDateMenu.Show);
           MenuItem showInfoMenuItem = new MenuItem(showInfoMenu.Title, showInfoMenu.Show);
           MainMenu mainMenu = new MainMenu(showTimeAndDateMenuItem, showInfoMenuItem);
           
           timeAndDateMenu.AddItems(showTime);
           timeAndDateMenu.AddItems(showDate);
           showInfoMenu.AddItems(showVersion);
           showInfoMenu.AddItems(countWords);
           mainMenu.Show();
       }
    }
}
