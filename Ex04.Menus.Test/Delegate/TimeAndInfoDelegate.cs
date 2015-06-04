using Ex04.Menus.Delegates;
using Ex04.Menus.Test.Delegate;

namespace Ex04.Menus.Test
{
   public class TimeAndInfoDelegate
    {
       public void run()
       {
           ShowDateAndTime showTimeAndDate = new ShowDateAndTime();
           ShowVersionAndCountWords showVersionAndCountWords = new ShowVersionAndCountWords();
           Menu TimeAndDateMenu = new Menu("Show Date/Time");
           Menu showInfo = new Menu("Info");
           MenuItem showTime = new MenuItem("Show Time", showTimeAndDate.showTime);
           MenuItem showDate = new MenuItem("Show Date", showTimeAndDate.showDate);
           MenuItem showVersion = new MenuItem("Show Version", showVersionAndCountWords.ShowVersion);
           MenuItem countWords = new MenuItem("Count Words", showVersionAndCountWords.CountWords);
           MenuItem showTimeAndDateMenuItem = new MenuItem(TimeAndDateMenu.Title, TimeAndDateMenu.Action);
           MenuItem showInfoMenuItem = new MenuItem(showInfo.Title, showInfo.Action);
           MainMenu mainMenu = new MainMenu(showTimeAndDateMenuItem, showInfoMenuItem);
           
           TimeAndDateMenu.AddItems(showTime);
           TimeAndDateMenu.AddItems(showDate);
           showInfo.AddItems(showVersion);
           showInfo.AddItems(countWords);
           mainMenu.Action();

       }
    }
}
