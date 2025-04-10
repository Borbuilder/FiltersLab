using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    internal class Roatate : Filters
    {
        private int x0, y0; // Центр поворота
        private float angle; // Угол поворота в радианах

        public Roatate(float angle, Image image)
        {
            this.x0 = image.Width / 2;
            this.y0 = image.Height / 2;
            this.angle = angle * (float)Math.PI / 180; // Преобразуем угол из градусов в радианы
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            // Применяем формулы поворота
            int x = (int)((k - x0) * Math.Cos(angle) - (l - y0) * Math.Sin(angle) + x0);
            int y = (int)((k - x0) * Math.Sin(angle) + (l - y0) * Math.Cos(angle) + y0);

            if (x >= sourceImage.Width || x < 0 || y >= sourceImage.Height || y < 0)
            {
                return Color.Black;
            }

            return sourceImage.GetPixel(x, y);
        }
    }

}
