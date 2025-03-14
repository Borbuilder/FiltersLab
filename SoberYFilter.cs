using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class SobelYFilter : MatrixFilter
    {
        public SobelYFilter()
        {
            kernel = new float[,] {

                {-1.0f, -2.0f, 1.0f},
                {0.0f, 0.0f, 0.0f},
                {1.0f, 2.0f, 1.0f}
            };
        }
    }
}
