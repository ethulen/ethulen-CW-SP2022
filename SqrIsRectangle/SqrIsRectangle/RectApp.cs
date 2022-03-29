using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrIsRectangle
{
    public class RectApp
    {
        public void doubleSides(List<Rectangle>rectangles)
        {
            foreach(Rectangle r in rectangles)
            {
                r.DoubleEachSide();
                Console.WriteLine("Rectangle: {0} x {1}", r.width, r.height);
            }
        }
    }
}
