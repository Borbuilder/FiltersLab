using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class BrightnessUpFilter: Filters
    {
        int add = 40;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            return Color.FromArgb(
                Clamp(sourceColor.R + add, 0, 255),
                Clamp(sourceColor.G + add, 0, 255),
                Clamp(sourceColor.B + add, 0, 255)
                );
        }
    }
}
