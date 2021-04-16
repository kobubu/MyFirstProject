using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{
    //создаем структуру, определяющую размер треугольника
    public struct Size
    {
        //создаем целочисленное свойство - ширина
        public int Width { get; set; }

        //создаем целочисленное свойство - высота
        public int Height { get; set; }
        
        //создаем 

        public Size(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        //создаем конструктор 

        public Size(Size size) : this(size.Width, size.Height) { }

        
        //создаем функцию перераспределения базового класса?
        
/* public override bool Equals(object obj)
{
    if (obj == null || GetType() != obj.GetType())
    {
        return false;
    }

    if (Width == ((Size)obj).Width && Height == ((Size)obj).Height)
        return true;
    else
        return false;
        */
}

}

 