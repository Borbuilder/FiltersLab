using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersLab
{
    public partial class Form1: Form
    {
        bool filtersFlag = false;
        bool dilFlag = false;
        bool erFlag = false;
        Bitmap image;
        private Stack<Bitmap> returnBack = new Stack<Bitmap>();
        private Stack<Bitmap> returnForward = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        int[,] structuralElement = new int[,]
            {
                { 0, 1, 0 },
                { 1, 1, 1 },
                { 0, 1, 0 }
            };

        private void HandleWithFilter(Filters filter)
        {
            filtersFlag = true;
            dilFlag = false;
            erFlag = false;

            if (image == null)
            {
                MessageBox.Show("Изображение не загружено.");
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                SaveCondition();
                backgroundWorker1.RunWorkerAsync(filter);
            }
            else
            {
                MessageBox.Show("Обработка уже выполняется.");
            }
        }

        private void HandleWithDilation(Dilation filter)
        {
            filtersFlag = false;
            dilFlag = true;
            erFlag = false;

            if (image == null)
            {
                MessageBox.Show("Изображение не загружено.");
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                SaveCondition();
                backgroundWorker1.RunWorkerAsync(filter);
            }
            else
            {
                MessageBox.Show("Обработка уже выполняется.");
            }
        }

        private void HandleWithErosion(Erosion filter)
        {
            filtersFlag = false;
            dilFlag = false;
            erFlag = true;

            if (image == null)
            {
                MessageBox.Show("Изображение не загружено.");
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                SaveCondition();
                backgroundWorker1.RunWorkerAsync(filter);
            }
            else
            {
                MessageBox.Show("Обработка уже выполняется.");
            }
        }

        private void SaveCondition()
        {
            if (image != null)
            {
                returnBack.Push(new Bitmap(image));
                if(returnForward.Count != 0)
                {
                    returnForward.Clear();
                }
                
            }
        }

        
        //Управление backgroundWorker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (filtersFlag)
                {
                    Filters filter = (Filters)e.Argument;
                    Bitmap newImage = filter.processImage(image, backgroundWorker1);
                    e.Result = newImage;
                }
                else if (dilFlag) { 
                    Dilation filter = (Dilation)e.Argument;
                    Bitmap newImage = filter.DilationProcessImage(image, backgroundWorker1);
                    e.Result = newImage;
                }
                else if (erFlag)
                {
                    Erosion filter = (Erosion)e.Argument;
                    Bitmap newImage = filter.ErosionProcessImage(image, backgroundWorker1);
                    e.Result = newImage;
                }

            }
            catch (Exception ex)
            {
                e.Result = ex; 
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker1.CancellationPending)
            {
                progressBar1.Value = e.ProgressPercentage;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Ошибка в BackgroundWorker: " + e.Error.Message);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Обработка отменена.");
            }
            else if (e.Result is Exception ex)
            {
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
            else if (e.Result is Bitmap resultImage)
            {
                pictureBox1.Image = resultImage;
                image = resultImage;
                pictureBox1.Refresh();
                
            }
            progressBar1.Value = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            progressBar1.Value = 0;
        }


        //События фильтров
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(ofd.FileName);
                }
                
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new InvertFilter());   
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new BlurFilter());
        }

        private void размытиеПоГауссуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new GaussianFilter());
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new GrayScaleFilter());
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new SepiaFilter());
        }

        private void увеличениеЯркостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new BrightnessUpFilter());
        }

        private void фильтрСобеляXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new SobelXFilter());
        }

        private void фильтрСобеляYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new SobelYFilter());
        }

        private void увеличениеРезкостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new SharpnessUpFilter());
        }



        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image!=null) {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
                saveFileDialog1.Title = "Сохранить изображение";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
                {
                    using (System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                    {
                        // Сохраняем изображение из pictureBox1
                        System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;

                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                format = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case 2:
                                format = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case 3:
                                format = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            case 4:
                                format = System.Drawing.Imaging.ImageFormat.Png;
                                break;
                        }

                        pictureBox1.Image.Save(fs, format);
                    }

                    //MessageBox.Show("Изображение успешно сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Изображение не загружено.");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //returnBack
        private void button2_Click(object sender, EventArgs e)
        {
            if (returnBack.Count > 0)
            {
                returnForward.Push(new Bitmap(pictureBox1.Image));
                image = returnBack.Pop();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }
        //returnForward
        private void button3_Click(object sender, EventArgs e)
        {
            if (returnForward.Count > 0)
            {
                returnBack.Push(new Bitmap(pictureBox1.Image));
                image = returnForward.Pop();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void волныToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HandleWithFilter(new Waves());
        }

        private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new GlassFilter());
        }

        private void motionBlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new MotionBlur());
        }

        private void поОсиXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new SharaX());
        }

        private void поОсиYЩарраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithFilter(new SharaY());
        }

        private void матМорфологияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithDilation(new Dilation(structuralElement));
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleWithErosion(new Erosion(structuralElement));
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
