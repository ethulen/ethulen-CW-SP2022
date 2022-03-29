using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrIsRectangle
{
    public class Rectangle
    {
        public virtual int height { get; set; }
        public virtual int width { get; set; }

        public int calculateArea()
        {
            return height * width;
        }

        public void DoubleEachSide()
        {
            width *= 2;
            height *= 2;
        }
    }

    public class Square : Rectangle
    {

    }

    public class SquareSquare : Rectangle
    {
        public override int height { get { return base.height; } set { base.height = value; base.width = value; } }
        public override int width { get { return base.width; } set { base.height = value; base.width = value; } }
    }
}
