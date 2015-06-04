using System;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Interface
{
    public class ShowTime : IMenuItem
    {
        private const string k_Title = "Show Time";

        public string Title
        {
            get { return k_Title; }
        }

        public void Show()
        {
            StringBuilder outPut = new StringBuilder();

            Console.Clear();
            outPut.AppendFormat("{0}{1}{1}", Title, Environment.NewLine);
            DateTime time = DateTime.Now;
            string format = "HH:mm:ss";
            outPut.AppendFormat("The time is: {0}", time.ToString(format));
            Console.WriteLine(outPut);
            Console.ReadLine();
        }
    }
}
