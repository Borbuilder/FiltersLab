using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    internal class Stretching: Filters
    {
        public int Ymax;
        public int Ymin;
        public Stretching(int Ymax_, int Ymin_)
        {
            this.Ymax = Ymax_;
            this.Ymin = Ymin_;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
       
            Color sourceColor = sourceImage.GetPixel(x, y);
            int R = Clamp((int)((sourceColor.R - Ymin) * (255.0 / (Ymax - Ymin))), 0, 255);
            int G = Clamp((int)((sourceColor.G - Ymin) * (255.0 / (Ymax - Ymin))), 0, 255);
            int B = Clamp((int)((sourceColor.B - Ymin) * (255.0 / (Ymax - Ymin))), 0, 255);

            return Color.FromArgb(R, G, B);
        }
    }
}
