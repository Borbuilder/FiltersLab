using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
        public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            

            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

                int totalPixels = sourceImage.Width * sourceImage.Height;
                int pixelsProcessed = 0;
                int updateInterval = totalPixels / 10;

                for (int i = 0; i < sourceImage.Width; ++i)
                {
                    for (int j = 0; j < sourceImage.Height; ++j)
                    {
                        if (worker.CancellationPending)
                        {
                            return null; 
                        }
                        resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));

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

        public int Clamp(int value, int min, int max) 
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
    }
}
