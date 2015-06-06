namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        protected const string k_PrevItem = "Exit";

        public MainMenu(params IMenuItem[] i_Items) : base("Main Menu", i_Items)
        {
        }

        public MainMenu() : this(null)
        {
        }

        public override string GoBackStr
        {
            get { return k_PrevItem; }
        }
    }
}