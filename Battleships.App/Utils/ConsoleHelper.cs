﻿using System;

namespace Battleships.App.Utils
{
    public static class ConsoleHelper
    {
        public static void WriteInfo(string content)
        {
            //clear info rows
            Console.SetCursorPosition(0,14);
            Console.Write("".PadRight(Console.WindowWidth, ' '));
            Console.SetCursorPosition(0,15);
            Console.Write("".PadRight(Console.WindowWidth, ' '));
            
            //write new info to console
            Console.SetCursorPosition(0,14);
            Console.WriteLine($"[INFO]: {content}");
            Console.Write("Your shot: ");
        }

        public static void WriteChar(char character, int col, int row)
        {
            Console.SetCursorPosition(col * 4 + 4, row + 2);
            Console.Write(character);
        }
        
        public static void ShowWelcomeScreen()
        {
            Console.WriteLine("Welcome to the game of battleships!");
            Console.WriteLine(); //break line
            Console.WriteLine("INSTRUCTIONS \n" +
                              "Your goal is to destroy the enemy ships in as little shots as possible. \n" +
                              "After every shot you will get feedback and the coordinates will change into O if you missed \n" +
                              "or X if you hit a ship \n" +
                              "To make a shot you need to enter proper coordinates starting with column. For example: \"A5\" \n" +
                              "Good luck!");
            Console.WriteLine(); //break line
            Console.Write("To start a game press any button:");
        }

        public static void ShowYouWinScreen()
        {
            Console.Clear();
            Console.SetCursorPosition(0,0);
            Console.WriteLine("Congratulations you won!");
            Console.Write("To play another game press ENTER to leave press any other button: ");
        }
        
        public static void DrawBoard()
        {
            Console.Clear();
            Console.SetCursorPosition(0,0);
            Console.WriteLine("    A   B   C   D   E   F   G   H   I   J");
            Console.WriteLine("   ---------------------------------------");
            Console.WriteLine("0 |                                       |");
            Console.WriteLine("1 |                                       |");
            Console.WriteLine("2 |                                       |");
            Console.WriteLine("3 |                                       |");
            Console.WriteLine("4 |                                       |");
            Console.WriteLine("5 |                                       |");
            Console.WriteLine("6 |                                       |");
            Console.WriteLine("7 |                                       |");
            Console.WriteLine("8 |                                       |");
            Console.WriteLine("9 |                                       |");
            Console.WriteLine("   ---------------------------------------");
        }
    }
}