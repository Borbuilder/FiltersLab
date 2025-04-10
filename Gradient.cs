using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    internal class Gradient
    {
        private int[,] structuralElement;

        public Gradient(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
        }

        public Bitmap GradientProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            // 1. Применяем дилатацию
            Dilation dilation = new Dilation(structuralElement);
            Bitmap dilatedImage = dilation.DilationProcessImage(sourceImage, worker);

            if (dilatedImage == null || worker.CancellationPending)
                return null;

            // 2. Применяем эрозию
            Erosion erosion = new Erosion(structuralElement);
            Bitmap erodedImage = erosion.ErosionProcessImage(sourceImage, worker);

            if (erodedImage == null || worker.CancellationPending)
            {
                dilatedImage.Dispose();
                return null;
            }

            // 3. Вычисляем разницу между дилатацией и эрозией
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color dilatedPixel = dilatedImage.GetPixel(x, y);
                    Color erodedPixel = erodedImage.GetPixel(x, y);

                    // Разница по каждому каналу (R, G, B)
                    int diffR = Math.Max(0, dilatedPixel.R - erodedPixel.R);
                    int diffG = Math.Max(0, dilatedPixel.G - erodedPixel.G);
                    int diffB = Math.Max(0, dilatedPixel.B - erodedPixel.B);

                    resultImage.SetPixel(x, y, Color.FromArgb(diffR, diffG, diffB));
                }
            }

            // Освобождаем ресурсы
            dilatedImage.Dispose();
            erodedImage.Dispose();

            worker.ReportProgress(100);
            return resultImage;
        }
    }
}
