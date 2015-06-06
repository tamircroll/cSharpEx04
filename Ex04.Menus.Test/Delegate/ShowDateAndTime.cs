using System;
using System.Text;

namespace Ex04.Menus.Test.Delegate
{
    public class ShowDateAndTime
    {
        private const string k_ShowTimeTitle = "Show Time";
        private const string k_ShowDateTitle = "Show Date";

        public void ShowTime_ItemChosen()
        {
            StringBuilder outPut = new StringBuilder();

            Console.Clear();
            outPut.AppendFormat("{0}{1}{1}", k_ShowTimeTitle, Environment.NewLine);
            DateTime time = DateTime.Now;
            string format = "HH:mm:ss";
            outPut.AppendFormat("The time is: {0}", time.ToString(format));
            Console.WriteLine(outPut);
            Console.ReadLine();
        }

        public void ShowDate_ItemChosen()
        {
            StringBuilder outPut = new StringBuilder();

            Console.Clear();
            outPut.AppendFormat("{0}{1}{1}", k_ShowDateTitle, Environment.NewLine);
            DateTime time = DateTime.Now;
            string format = "dd.MM.yyyy";
            outPut.AppendFormat("The date is: {0}", time.ToString(format));
            Console.WriteLine(outPut);
            Console.ReadLine();
        }
    }
}
