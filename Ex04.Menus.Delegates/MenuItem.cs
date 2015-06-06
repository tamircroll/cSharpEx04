namespace Ex04.Menus.Delegates
{
    public delegate void MenuChoiseInvoker();

    public class MenuItem
    {
        private string m_Title;

        private event MenuChoiseInvoker ItemChosen;

        public MenuItem(string i_Title, MenuChoiseInvoker i_ItemChosen)
        {
            m_Title = i_Title;
            ItemChosen += i_ItemChosen;
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public void OnItnemChosen()
        {
            ItemChosen.Invoke();
        }
    }
}