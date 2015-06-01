﻿using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runProgram();
        }

        private static void runProgram()
        {
            Menu a = new Menu("Menu A");
            Menu b = new Menu("Menu B", a);
            Menu c = new Menu("Menu B", a, b);
            MainMenu mainMenu = new MainMenu(a, b, c);
            mainMenu.Action();
        }
    }
}