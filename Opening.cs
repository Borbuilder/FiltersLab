//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FiltersLab
//{
//    class Opening
//    {
//        private Erosion erosionFilter;
//        private Dilation dilationFilter;

//        private int[,] structuralElement;

//        public Opening(int[,] structuralElement)
//        {
//            erosionFilter = new Erosion(structuralElement);
//            dilationFilter = new Dilation(structuralElement);
//            this.structuralElement = structuralElement;
//        }

//        public Bitmap OpeningProcessImage(Bitmap sourceImage, BackgroundWorker worker)
//        {
//            // Применение сначала сужения (эрозии)
//            int W = sourceImage.Width;
//            int H = sourceImage.Height;
//            Bitmap resultImage = new Bitmap(W, H);

//            int totalPixels = sourceImage.Width * sourceImage.Height;
//            int pixelsProcessed = 0;
//            int updateInterval = totalPixels / 10;

//            int MW = structuralElement.GetLength(0);
//            int MH = structuralElement.GetLength(1);

//            for (int y = MH / 2; y < H - MH / 2; y++)
//            {
//                for (int x = MW / 2; x < W - MW / 2; x++)
//                {
//                    if (worker.CancellationPending)
//                    {
//                        return null;
//                    }

//                    int minR = 255;
//                    int minG = 255;
//                    int minB = 255;

//                    for (int j = -MH / 2; j <= MH / 2; j++)
//                    {
//                        for (int i = -MW / 2; i <= MW / 2; i++)
//                        {
//                            int currentX = x + i;
//                            int currentY = y + j;

//                            Color pixelColor = sourceImage.GetPixel(currentX, currentY);

//                            int redValue = pixelColor.R;
//                            int greenValue = pixelColor.G;
//                            int blueValue = pixelColor.B;

//                            if ((structuralElement[i + MW / 2, j + MH / 2] == 1))
//                            {
//                                if (redValue < minR)
//                                    minR = redValue;

//                                if (greenValue < minG)
//                                    minG = greenValue;

//                                if (blueValue < minB)
//                                    minB = blueValue;
//                            }
//                        }
//                    }

//                    ++pixelsProcessed;
//                    if (pixelsProcessed % updateInterval == 0)
//                    {
//                        int progressPercentage = pixelsProcessed * 50 / totalPixels;
//                        worker.ReportProgress(progressPercentage);
//                    }

//                    resultImage.SetPixel(x, y, Color.FromArgb(255, minR, minG, minB));
//                }
//            }

//            worker.ReportProgress(100);
//            //Bitmap resultAfterErosion = erosionFilter.ErosionProcessImage(sourceImage);

//            // Затем расширение

//            //Bitmap resultAfterOpening = dilationFilter.ProcessImage(resultAfterErosion);

//            return resultAfterOpening;
//        }
//    }
//}

