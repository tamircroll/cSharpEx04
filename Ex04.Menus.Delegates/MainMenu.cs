namespace Ex04.Menus.Delegates
{
    public class MainMenu : Menu
    {
        protected const string k_PrevItem = "Exit";

        public MainMenu(params MenuItem[] i_Items) : base("Main Menu", i_Items)
        {
            m_PrevItem = "Exit";
        }

        public MainMenu() : this(null)
        {
        }
    }
}
