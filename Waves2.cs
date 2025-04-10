﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class Waves2 : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            int newX = k;
            int newY = Clamp(l + (int)(20 * Math.Sin(Math.PI * k /30)), 0, sourceImage.Height - 1);

            Color pixelColor = sourceImage.GetPixel(k, l);
            if ((newX >= 0 && newX <= sourceImage.Width) && (newY >= 0 && newY <= sourceImage.Height))
            {
                pixelColor = sourceImage.GetPixel(newX, newY);
            }
            return pixelColor;
        }

    }
}
