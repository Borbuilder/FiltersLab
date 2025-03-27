using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class Waves: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int newX = (int)(x + 20 * Math.Sin(2 * Math.PI * x / 30));
            int newY = y;

            Color pixelColor=sourceImage.GetPixel(x, y);
            if ((newX >= 0 && newX <= sourceImage.Width) && (newY >= 0 && newY <= sourceImage.Height))
            {
                pixelColor = sourceImage.GetPixel(newX, newY);
            }
            return pixelColor;
        }
        
    }
}
