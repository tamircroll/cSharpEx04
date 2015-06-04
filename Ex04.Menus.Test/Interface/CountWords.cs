using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.Interface
{
    public class CountWords : IMenuItem
    {
        private const string k_Title = "Count Words";

        public string Title
        {
            get { return k_Title; }
        }

        public void Show()
        {
            string msg = "Please enter a sentence";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0}{1}{1}{2}:", Title, Environment.NewLine, msg);
                string sentence = Console.ReadLine();
                if (!string.IsNullOrEmpty(sentence))
                {
                    string[] splited = sentence.Split(' ');
                    Console.WriteLine("The number of words in the sentence is: {0}", splited.Length);
                    Console.ReadLine();
                    break;
                }

                msg = "The string cannot be empty. please try again";
            }
        }
    }
}
