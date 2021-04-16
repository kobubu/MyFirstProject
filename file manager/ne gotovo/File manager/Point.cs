using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{

    //создаем структуру - точка координаты начала прямоугольника для координаты для начала прямоугольника
    public struct Point
    {
        //задаем свойства структуры - координаты x и y
        public int X { get; set; }
        public int Y { get; set; }

        //создаем конструктор с координатами
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}