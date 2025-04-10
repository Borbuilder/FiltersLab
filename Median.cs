using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class Median : MatrixFilter
    {
        public Median() // сглаживание или уменьшение шума
        {
            // Ядро медианного фильтра (пример)
            kernel = new float[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            // списки для предназначенные для хранения значений R G B
            List<int> R = new List<int>();
            List<int> G = new List<int>();
            List<int> B = new List<int>();
            // происходит обход окрестности текущего пикселя,
            // и значения R, G и B компонент
            // каждого соседнего пикселя добавляются в соответствующие списки.

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);

                    Color sourceColor = sourceImage.GetPixel(idX, idY);

                    R.Add(sourceColor.R);
                    G.Add(sourceColor.G);
                    B.Add(sourceColor.B);
                }
            }

            R.Sort();
            G.Sort();
            B.Sort();

            int medianR = R[R.Count / 2];
            int medianG = G[G.Count / 2];
            int medianB = B[B.Count / 2];

            return Color.FromArgb(medianR, medianG, medianB);
        }
    }
}
