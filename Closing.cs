using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    internal class Closing
    {
        private int[,] structuralElement;

        public Closing(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
        }

        public Bitmap ClosingProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            // Сначала применяем дилатацию
            Dilation dilation = new Dilation(structuralElement);
            Bitmap dilatedImage = dilation.DilationProcessImage(sourceImage, worker);

            if (dilatedImage == null || worker.CancellationPending)
            {
                return null;
            }

            // Затем применяем эрозию к результату дилатации
            Erosion erosion = new Erosion(structuralElement);
            Bitmap closedImage = erosion.ErosionProcessImage(dilatedImage, worker);

            // Освобождаем ресурсы
            dilatedImage.Dispose();

            return closedImage;
        }
    }
}
