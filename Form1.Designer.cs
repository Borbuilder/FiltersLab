namespace FiltersLab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеПоГауссуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделениеГраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОсиXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОсиYЩарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.волныToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem,
            this.матМорфологияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // увеличениеЯркостиToolStripMenuItem
            // 
            this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
            this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.увеличениеЯркостиToolStripMenuItem.Text = "Увеличение яркости";
            this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.размытиеПоГауссуToolStripMenuItem,
            this.фильтрСобеляXToolStripMenuItem,
            this.фильтрСобеляYToolStripMenuItem,
            this.увеличениеРезкостиToolStripMenuItem,
            this.motionBlToolStripMenuItem,
            this.выделениеГраницToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // размытиеПоГауссуToolStripMenuItem
            // 
            this.размытиеПоГауссуToolStripMenuItem.Name = "размытиеПоГауссуToolStripMenuItem";
            this.размытиеПоГауссуToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.размытиеПоГауссуToolStripMenuItem.Text = "Размытие по Гауссу";
            this.размытиеПоГауссуToolStripMenuItem.Click += new System.EventHandler(this.размытиеПоГауссуToolStripMenuItem_Click);
            // 
            // фильтрСобеляXToolStripMenuItem
            // 
            this.фильтрСобеляXToolStripMenuItem.Name = "фильтрСобеляXToolStripMenuItem";
            this.фильтрСобеляXToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.фильтрСобеляXToolStripMenuItem.Text = "Фильтр Собеля(X)";
            this.фильтрСобеляXToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляXToolStripMenuItem_Click);
            // 
            // фильтрСобеляYToolStripMenuItem
            // 
            this.фильтрСобеляYToolStripMenuItem.Name = "фильтрСобеляYToolStripMenuItem";
            this.фильтрСобеляYToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.фильтрСобеляYToolStripMenuItem.Text = "Фильтр  Собеля(Y)";
            this.фильтрСобеляYToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляYToolStripMenuItem_Click);
            // 
            // увеличениеРезкостиToolStripMenuItem
            // 
            this.увеличениеРезкостиToolStripMenuItem.Name = "увеличениеРезкостиToolStripMenuItem";
            this.увеличениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.увеличениеРезкостиToolStripMenuItem.Text = "Увеличение резкости";
            this.увеличениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеРезкостиToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.волныToolStripMenuItem.Text = "Волны";
            this.волныToolStripMenuItem.Click += new System.EventHandler(this.волныToolStripMenuItem_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(687, 22);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(724, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(765, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "-->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.эффектСтеклаToolStripMenuItem.Text = "Эффект Стекла";
            this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
            // 
            // motionBlToolStripMenuItem
            // 
            this.motionBlToolStripMenuItem.Name = "motionBlToolStripMenuItem";
            this.motionBlToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.motionBlToolStripMenuItem.Text = "MotionBlur";
            this.motionBlToolStripMenuItem.Click += new System.EventHandler(this.motionBlToolStripMenuItem_Click);
            // 
            // выделениеГраницToolStripMenuItem
            // 
            this.выделениеГраницToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поОсиXToolStripMenuItem,
            this.поОсиYЩарраToolStripMenuItem});
            this.выделениеГраницToolStripMenuItem.Name = "выделениеГраницToolStripMenuItem";
            this.выделениеГраницToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.выделениеГраницToolStripMenuItem.Text = "Выделение границ";
            // 
            // поОсиXToolStripMenuItem
            // 
            this.поОсиXToolStripMenuItem.Name = "поОсиXToolStripMenuItem";
            this.поОсиXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поОсиXToolStripMenuItem.Text = "По оси X (Щарра)";
            this.поОсиXToolStripMenuItem.Click += new System.EventHandler(this.поОсиXToolStripMenuItem_Click);
            // 
            // поОсиYЩарраToolStripMenuItem
            // 
            this.поОсиYЩарраToolStripMenuItem.Name = "поОсиYЩарраToolStripMenuItem";
            this.поОсиYЩарраToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поОсиYЩарраToolStripMenuItem.Text = "По оси Y (Щарра)";
            this.поОсиYЩарраToolStripMenuItem.Click += new System.EventHandler(this.поОсиYЩарраToolStripMenuItem_Click);
            // 
            // матМорфологияToolStripMenuItem
            // 
            this.матМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem});
            this.матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            this.матМорфологияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.матМорфологияToolStripMenuItem.Text = "Мат. морфология";
            this.матМорфологияToolStripMenuItem.Click += new System.EventHandler(this.матМорфологияToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеПоГауссуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеРезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделениеГраницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОсиXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОсиYЩарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
    }
}

