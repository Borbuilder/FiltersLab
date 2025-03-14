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
        Bitmap image;

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleWithFilter(Filters filter)
        {
            if (image == null)
            {
                MessageBox.Show("Изображение не загружено.");
                return;
            }

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(filter);
            }
            else
            {
                MessageBox.Show("Обработка уже выполняется.");
            }
        }

        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Filters filter = (Filters)e.Argument;
                Bitmap newImage = filter.processImage(image, backgroundWorker1);
                e.Result = newImage; 
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
    }
}
