using System;
namespace File_manager
{
    //создание класса для 
    public class Pixel
    {
        //задаем дефолтные цвета для консоли
        public const ConsoleColor DAFAULT_FOREGROUND_COLOR = ConsoleColor.Gray;
        public const ConsoleColor DAFAULT_BACKGROUND_COLOR = ConsoleColor.Black;
        
        //задаем поля - цвета консоли
        
        public char Char { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; } 
        
        //создание экземпляр класса  
        public Pixel(char ch, ConsoleColor foreground, ConsoleColor background)
        {
            Char = ch;
            ForegroundColor = foreground;
            BackgroundColor = background;
        }

        public void Paint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            SetColor(ForegroundColor, BackgroundColor);
            Console.Write(Char);
        }


        public void SetColor(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
        }

        public Pixel Clone()
        {
            return new Pixel(Char, ForegroundColor, BackgroundColor);
        }
    }
}