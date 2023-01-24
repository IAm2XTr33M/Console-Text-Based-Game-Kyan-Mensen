using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalConsoleGame
{
    class LineWriter
    {
        public int writeSpeed;

        //Construct with speed
        public LineWriter(int s)
        {
            this.writeSpeed = s;
        }

        //Write letter for letter
        public void write(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(100-writeSpeed);
                Console.Write(text.Substring(i, 1));
            }
        }

        //Write letter for letter in color
        public void writeColor(string text , ConsoleColor color)
        {
            ConsoleColor fgColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(100 - writeSpeed);
                Console.Write(text.Substring(i, 1));
            }

            Console.ForegroundColor = fgColor;
        }
        //Write letter for letter in color
        public void writeColorLine(string text, ConsoleColor color)
        {
            writeColor(text,color);
            Console.WriteLine();
        }

        //Write letter for letter in inverted current colors
        public void writeInverted(string text)
        {
            ConsoleColor bgColor = Console.BackgroundColor;
            ConsoleColor fgColor = Console.ForegroundColor;

            Console.BackgroundColor = fgColor;
            Console.ForegroundColor = bgColor;

            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(100 - writeSpeed);
                Console.Write(text.Substring(i, 1));
            }

            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = fgColor;
        }

        //Write letter for letter in inverted current colors and finish line
        public void writeInvertedLine(string text)
        {
            writeInverted(text);
            Console.WriteLine();
        }

        //Write letter for letter in inverted color
        public void writeColorInverted(string text, ConsoleColor color)
        {
            ConsoleColor bgColor = Console.BackgroundColor;
            ConsoleColor fgColor= Console.ForegroundColor;

            Console.BackgroundColor = color;
            Console.ForegroundColor = bgColor;

            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(100 - writeSpeed);
                Console.Write(text.Substring(i, 1));
            }

            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = fgColor;
        }

        //Write letter for letter in inverted color and finish line
        public void writeColorInvertedLine(string text, ConsoleColor color)
        {
            writeColorInverted(text,color);
            Console.WriteLine("");
        }

        //Write letter for letter and put the cursor back
        public void writeRemove(string text, int waitBeforeRemove)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(100 - writeSpeed);
                Console.Write(text.Substring(i, 1));
            }
            Thread.Sleep(waitBeforeRemove);
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(125 - writeSpeed);
                Console.Write("\b");
            }
        }

        //Write letter for letter and finish the line
        public void writeLine(string text)
        {
            write(text);
            Console.WriteLine();
        }

        //Write letter for letter , remove and finishs the line
        public void writeRemoveLine(string text, int waitBeforeRemove)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(100 - writeSpeed);
                Console.Write(text.Substring(i, 1));
            }
            Thread.Sleep(waitBeforeRemove);
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(125 - writeSpeed);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        //Change ammount from letters to space
        public void remove(int removeAmmount)
        {
            for (int i = 0; i < removeAmmount; i++)
            {
                Thread.Sleep(125 - writeSpeed);
                Console.Write("\b");
            }
            for (int i = 0; i < removeAmmount; i++)
            {
                Thread.Sleep(100 - writeSpeed);
                Console.Write(" ");
            }
        }
    }
}
