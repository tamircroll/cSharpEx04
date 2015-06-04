using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
   public class TimeAndInfoDelegate
    {
       public void run()
       {
           Menu showTimeAndDate = new Menu("Show Date/Time");
           Menu showInfo = new Menu("Info");
           MenuItem showTimeAndDateMenuItem = new MenuItem(showTimeAndDate.Title, showTimeAndDate.Action);
           MenuItem showInfoMenuItem = new MenuItem(showInfo.Title, showInfo.Action);


           MainMenu mainMenu = new MainMenu(showTimeAndDateMenuItem, showInfoMenuItem);

           mainMenu.Action();

       }
    }
}
