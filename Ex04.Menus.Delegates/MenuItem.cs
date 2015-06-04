namespace Ex04.Menus.Delegates
{
    public delegate void MenuChoiseInvoker();

    public class MenuItem
    {
        private string m_Title;
        private event MenuChoiseInvoker m_MenuChoiseInvoker;  //TODO: Check if name is by the coading standards

        public MenuItem(string i_Title, MenuChoiseInvoker i_MenuChoiseInvoker)
        {
            m_Title = i_Title;
            m_MenuChoiseInvoker += i_MenuChoiseInvoker;
        }

        public string Title
        {
            get { return m_Title; }
        }

        public void InvokeChoise()
        {
            m_MenuChoiseInvoker.Invoke();
        }
    }
}