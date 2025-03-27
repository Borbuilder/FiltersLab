using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FiltersLab
{
    class GlassFilter: Filters
    {
        Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            
            int newX = (int)(x + (rand.NextDouble() - 0.5) * 10);
            int newY = (int)(y + (rand.NextDouble() - 0.5) * 10);

            Color pixelColor = sourceImage.GetPixel(x, y);
            if ((newX >= 0 && newX < sourceImage.Width) && (newY >= 0 && newY < sourceImage.Height))
            {
                pixelColor = sourceImage.GetPixel(newX, newY);
            }
            return pixelColor;
        }
    }
}
