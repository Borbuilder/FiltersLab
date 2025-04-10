using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class Opening
    {
        private int[,] structuralElement;

        public Opening(int[,] structuralElement)
        {
            this.structuralElement = structuralElement;
        }

        public Bitmap OpeningProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            // Сначала применяем эрозию
            Erosion erosion = new Erosion(structuralElement);
            Bitmap erodedImage = erosion.ErosionProcessImage(sourceImage, worker);

            if (erodedImage == null || worker.CancellationPending)
            {
                return null;
            }

            // Затем применяем дилатацию к результату эрозии
            Dilation dilation = new Dilation(structuralElement);
            Bitmap openedImage = dilation.DilationProcessImage(erodedImage, worker);

            // Освобождаем ресурсы
            erodedImage.Dispose();

            return openedImage;
        }
    }
}
