using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class GrayWorld
    {
        public Bitmap GrayWorldProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            // Переменные, которые будут использоваться для хранения суммарных значений
            int totalPixels = sourceImage.Width * sourceImage.Height;
            int totalRed = 0, totalGreen = 0, totalBlue = 0;

            // Вычисление суммы значений RGB
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color pixelColor = sourceImage.GetPixel(x, y);
                    totalRed += pixelColor.R;
                    totalGreen += pixelColor.G;
                    totalBlue += pixelColor.B;
                }
            }
            // Вычисление средних значений красного, зеленого и синего цветов
            double avgR = totalRed / (double)totalPixels;
            double avgG = totalGreen / (double)totalPixels;
            double avgB = totalBlue / (double)totalPixels;

            // Вычисление среднего значения для всех каналов
            double avg = (avgR + avgG + avgB) / 3.0;

            // Создание нового изображения с примененной коррекцией
            Bitmap correctedImage = new Bitmap(sourceImage);

            int ttlPixels = sourceImage.Width * sourceImage.Height;
            int pixelsProcessed = 0;
            int updateInterval = ttlPixels / 10;

            // Применение коррекции к каждому пикселю изображения
            for (int y = 0; y < correctedImage.Height; y++)
            {
                for (int x = 0; x < correctedImage.Width; x++)
                {
                    Color pixelColor = correctedImage.GetPixel(x, y);

                    // Коррекция каждого канала по формуле + ограничение
                    int correctedRed = Clamp((int)((pixelColor.R * avg) / avgR), 0, 255);
                    int correctedGreen = Clamp((int)((pixelColor.G * avg) / avgG), 0, 255);
                    int correctedBlue = Clamp((int)((pixelColor.B * avg) / avgB), 0, 255);

                    correctedImage.SetPixel(x, y, Color.FromArgb(correctedRed, correctedGreen, correctedBlue));

                    ++pixelsProcessed;
                    if (pixelsProcessed % updateInterval == 0)
                    {
                        int progressPercentage = pixelsProcessed * 100 / ttlPixels;
                        worker.ReportProgress(progressPercentage);
                    }
                }
            }

            worker.ReportProgress(100);
            return correctedImage;
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
