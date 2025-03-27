using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersLab
{
    class MotionBlur : MatrixFilter
    {
        public MotionBlur(){
            int size = 6;
            kernel = new float[size, size];
            for (int i = 0; i < size; ++i)
            {
                kernel[i, i] = 1.0f / size;
            }
        }
    }
}
