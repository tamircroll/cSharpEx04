using System;

namespace Ex04.Menus.Test.Delegate
{
    public class ShowInfo
    {
        private const string k_ShowVersionTitle = "Show version";
        private const string k_CountWordsTitle = "Count Words";

        public void ShowVersion_ItemChosen()
        {
            Console.Clear();
            Console.WriteLine("{0}{1}{1}Version: 15.2.4.0", k_ShowVersionTitle, Environment.NewLine);
            Console.ReadLine();
        }

        public void CountWords_ItemChosen()
        {
            string msg = "Please enter a sentence";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0}{1}{1}{2}:", k_CountWordsTitle, Environment.NewLine, msg);
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
