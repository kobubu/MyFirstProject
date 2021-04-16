using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{

    // создаем класс линия
    public class Line
    {

        //добавляем свойства - координата по оси x
        public int X { get; set; }
        //добавляем свойства - координата по оси Y
        public int Y { get; set; }
        //добавляем свойство - длина
        public int Length { get; set; }
        //добавляем свойство - толщина линии
        public int Thickness { get; set; }

        //добавляем свойство - направляение 
        public Direction Direction { get; set; }

        //добавляем свойство - тип линии устанавливаем 

        public LineType LineType { get; set; } = LineType.Single;

        //добавляем свойство - цвет консоли 
        public ConsoleColor ForegroundColor { get; set; }

        //добавляем свойство - фон консоли
        public ConsoleColor BackgroundColor { get; set; }

        
        //создаем поле класса;
        private char _char = '\0';

        // создаем метод для прорисовки линии  - 
        public Char Char
        {
            get
            {
                if (_char == '\0')
                {
                    switch (LineType)
                    {
                        //если тип линии одинарный горизонт, то линия выглядит вот так "-"
                        case LineType.Single:
                            if (Direction == Direction.Horizontal)
                                return '─';
                            else //если тип линии одинарный вертик, то линия выглядит вот так "|"
                                return '│';
                        case LineType.Double:
                            //прорисовываем равно для горизонтальной линии  
                            if (Direction == Direction.Horizontal)
                                return '═';
                            else //
                                return '║';
                        default: //дефолтное значение 
                            return '\0';
                    }
                }
                else
                    return _char;
            }
            set => _char = value;
        }

        private char _firstChar = '\0';
        public Char FirstChar
        {
            get
            {
                if (_firstChar == '\0')
                {
                    return Char;
                }
                else
                    return _firstChar;
            }
            set => _firstChar = value;
        }

        private char _lastChar = '\0';
        public Char LastChar
        {
            get
            {
                if (_lastChar == '\0')
                {
                    return Char;
                }
                else
                    return _lastChar;
            }
            set => _lastChar = value;
        }


        /* public Theme Theme => Theme.GetInstance();

         public Line(int x, int y, int length, int thickness, Direction direction, LineType lineType = LineType.None)
         {
             X = x;
             Y = y;
             Length = length;
             Thickness = thickness;
             Direction = direction;
             LineType = lineType;
             ForegroundColor = Theme.FilePanelForegroundColor;
             BackgroundColor = Theme.FilePanelBackgroundColor;
         }

         public void Draw(Buffer buffer)
         {
             Draw(buffer, 0, 0);
         }

         public void Draw(Buffer buffer, int targetX, int targetY)
         {
             int x = targetX + X;
             int y = targetY + Y;
             for (int j = 0; j < Thickness; j++)
             {
                 Pixel[,] bufferArray = buffer.GetBuffer();

                 for (int i = 0; i < Length; i++)
                 {
                     if (Direction == Direction.Horizontal)
                     {
                         bufferArray[x + i, y + j].BackgroundColor = BackgroundColor;
                         if (Char != '\0')
                         {
                             if (i == 0)
                                 bufferArray[x + i, y + j].Char = FirstChar;
                             else if (i == Length - 1)
                                 bufferArray[x + i, y + j].Char = LastChar;
                             else
                                 bufferArray[x + i, y + j].Char = Char;
                         }
                     }
                     else if (Direction == Direction.Vertical)
                     {
                         bufferArray[x + j, y + i].BackgroundColor = BackgroundColor;
                         if (Char != '\0')
                         {
                             if (i == 0)
                                 bufferArray[x + j, y + i].Char = FirstChar;
                             else if (i == Length - 1)
                                 bufferArray[x + j, y + i].Char = LastChar;
                             else
                                 bufferArray[x + j, y + i].Char = Char;
                         }
                     }

                 }
             }
         }
         */
    }
}
