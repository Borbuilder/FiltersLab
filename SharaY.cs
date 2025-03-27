using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class SharaY: MatrixFilter
    {
        public SharaY()
        {
            kernel = new float[,] {

                {3.0f, 10.0f, 3.0f},
                {0.0f, 0.0f, 0.0f},
                {-3.0f, -10.0f, -3.0f}
            };
        }
    }
}
