using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class IdealReflector
    {
        public Bitmap IdealReflectorProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            int maxRed = 0, maxGreen = 0, maxBlue = 0;

            Bitmap resultImage = new Bitmap(sourceImage);
            int totalPixels = sourceImage.Width * sourceImage.Height;
            int pixelsProcessed = 0;
            int updateInterval = totalPixels / 10;


            for (int y = 0; y < resultImage.Height; y++)
            {
                for (int x = 0; x < resultImage.Width; x++)
                {
                    Color pixelColor = resultImage.GetPixel(x, y);

                    maxRed = Math.Max(maxRed, pixelColor.R);
                    maxGreen = Math.Max(maxGreen, pixelColor.G);
                    maxBlue = Math.Max(maxBlue, pixelColor.B);

                    int correctedRed = Clamp(((pixelColor.R * 255) / maxRed), 0, 255);
                    int correctedGreen = Clamp(((pixelColor.G * 255) / maxGreen), 0, 255);
                    int correctedBlue = Clamp(((pixelColor.B * 255) / maxBlue), 0, 255);

                    resultImage.SetPixel(x, y, Color.FromArgb(correctedRed, correctedGreen, correctedBlue));
                    ++pixelsProcessed;
                    if (pixelsProcessed % updateInterval == 0)
                    {
                        int progressPercentage = pixelsProcessed * 100 / totalPixels;
                        worker.ReportProgress(progressPercentage);
                    }
                }
            }
            worker.ReportProgress(100);
            return resultImage;
        }
        private static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
    }
}
