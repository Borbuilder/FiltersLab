using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FiltersLab
{
    internal class MinimumDistance: Filters
    { 
       List<Color> Colors = new List<Color>();
       
            Color red = Color.FromArgb(255, 0, 0);
            Color green = Color.FromArgb(0, 255, 0);
            Color blue = Color.FromArgb(0, 0, 255);
            Color grey = Color.FromArgb(0, 0, 0);
            Color yellow = Color.FromArgb(255,255,0);
            Color black = Color.FromArgb(255, 255, 255);
        public MinimumDistance()
        {

            Colors.Add(yellow);
            Colors.Add(red);
            Colors.Add(green);
            Colors.Add(blue);
            Colors.Add(grey);
            Colors.Add(black);

        }

    
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color pixelColor = sourceImage.GetPixel(x, y);

            double distance = 10000.0f;
            int ColorID = -1;

            for (int i = 0; i < Colors.LongCount(); i++)
            {
                double curDist = Math.Sqrt(
                        Math.Pow(pixelColor.R - Colors[i].R, 2) +
                        Math.Pow(pixelColor.G - Colors[i].G, 2) +
                        Math.Pow(pixelColor.B - Colors[i].B, 2)
                    );

                if (distance > curDist)
                {
                    distance = curDist;
                    ColorID = i;
                }
            }

            return Colors[ColorID];
        }
    }
}
