using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment2
{
    public class Rectangle
    {
        private int width;
        private int length;

        public Rectangle()
        {
            this.width = 1;
            this.length = 1;
        }
        public Rectangle(int width, int height)
        {
            this.width = width>0?width:1;
            this.length = height>0?height:1;
        }
        // Getter and Setter
        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }

        public int getPerimeter()
        {
            var perimeter = 2 * (Width + Length);
            return perimeter;
        }
        public int getArea()
        {
            var area = Width * Length;
            return area;
        }
    }

}
