using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class SharpnessUpFilter: MatrixFilter
    {
        public SharpnessUpFilter()
        {
            kernel = new float[,] {

                { 0.0f, -1.0f, 0.0f},
                { -1.0f, 5.0f, -1.0f},
                { 0.0f, -1.0f, 0.0f}
        };
    }
    }
}
