using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    internal class Transfer : Filters
    {
        

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = x + 50;
            int newY = y ;

            //int newX = Clamp(x + 50, 0, sourceImage.Width - 1);
            //int newY = Clamp(y + 10, 0, sourceImage.Height - 1);

            if (newX >= sourceImage.Width || newX < 0 || newY >= sourceImage.Height || newY < 0)
            {
                return Color.Black;
            }
            return sourceImage.GetPixel(newX, newY);

             
        }
    }
}
