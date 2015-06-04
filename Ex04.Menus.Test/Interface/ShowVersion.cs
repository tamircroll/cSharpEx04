using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Interface
{
    public class ShowVersion : IMenuItem
    {
        private const string k_Title = "Show Version";

        public string Title
        {
            get { return k_Title; }
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("{0}{1}{1}Version: 15.2.4.0", Title, Environment.NewLine);
            Console.ReadLine();
        }
    }
}
