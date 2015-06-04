using System;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Interface
{
    public class ShowDate : IMenuItem
    {
        private const string k_Title = "Show Date";

        public string Title {
            get { return k_Title; }
        }

        public void Show()
        {
            StringBuilder outPut = new StringBuilder();

            Console.Clear();
            DateTime time = DateTime.Now;
            string format = "dd.MM.yyyy";
            outPut.AppendFormat("The date is: {0}", time.ToString(format));
            Console.WriteLine(outPut);
            Console.ReadLine();
        }
    }
}
