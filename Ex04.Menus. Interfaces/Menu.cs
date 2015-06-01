using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Menu : IMenuItem
    {
        private string m_Title;
        private List<IMenuItem> m_Options = new List<IMenuItem>();
        protected string m_PrevItem;

        public Menu(string i_Title) : this(i_Title, null)
        {
        }

        public Menu(string i_Title, params IMenuItem[] i_Items)
        {
            m_Title = i_Title;
            m_PrevItem = "Back";

            if (i_Items != null)
            {
                AddItems(i_Items);
            }
        }

        public string Title
        {
            get { return m_Title; }
        }

        public void Action()
        {
            int choiseInt;
            string choiceStr, msg = "Please choose the wanted action index and press Enter:";
            bool isValidInput;

            while (true)
            {
                printView(msg);
                choiceStr = Console.ReadLine();
                isValidInput = int.TryParse(choiceStr, out choiseInt);
                if (isValidInput)
                {
                    if (choiseInt < 0 || choiseInt > m_Options.Count)
                    {
                        msg = "The chosen index is not in range. Please enter index again:";
                    }
                    else
                    {
                        if (choiseInt == 0)
                        {
                            break;
                        }

                        choiseInt--;
                        m_Options[choiseInt].Action();
                        msg = "Please choose the wanted action index and press Enter:";
                    }
                }
                else
                {
                    msg = "The input is not a number. Please enter index again:";
                }
            }
        }

        public void AddItems(params IMenuItem[] i_Items)
        {
            foreach (IMenuItem item in i_Items)
            {
                m_Options.Add(item);
            }
        }

        private void printView(string i_Msg)
        {
            int index = 1;
            StringBuilder toPrint = new StringBuilder();

            Console.Clear();
            toPrint.Append(string.Format("{0}{1}{1}", Title, Environment.NewLine));
            toPrint.Append(string.Format("{0}. {1}{2}", 0, m_PrevItem, Environment.NewLine));
            foreach (IMenuItem item in m_Options)
            {
                toPrint.Append(string.Format("{0}. {1}{2}", index, item.Title, Environment.NewLine));
                index++;
            }

            if(i_Msg != null)
            {
                toPrint.Append(string.Format("{0}{1}", i_Msg, Environment.NewLine));
            }

            Console.WriteLine(toPrint);
        }
    }
}
