namespace Sclad
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.саправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conductorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отработанноеВремяВодителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пробегАвтобусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путивыеЛистыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шаблонДоговораНаПоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.саправочникиToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.ВыходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // саправочникиToolStripMenuItem
            // 
            this.саправочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busesToolStripMenuItem,
            this.conductorsToolStripMenuItem,
            this.routesToolStripMenuItem,
            this.отработанноеВремяВодителейToolStripMenuItem,
            this.пробегАвтобусовToolStripMenuItem,
            this.путивыеЛистыToolStripMenuItem1});
            this.саправочникиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("саправочникиToolStripMenuItem.Image")));
            this.саправочникиToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.саправочникиToolStripMenuItem.Name = "саправочникиToolStripMenuItem";
            this.саправочникиToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.саправочникиToolStripMenuItem.Text = "Список";
            this.саправочникиToolStripMenuItem.Click += new System.EventHandler(this.саправочникиToolStripMenuItem_Click);
            // 
            // busesToolStripMenuItem
            // 
            this.busesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.busesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.busesToolStripMenuItem.Name = "busesToolStripMenuItem";
            this.busesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.busesToolStripMenuItem.Text = "Склад";
            this.busesToolStripMenuItem.Click += new System.EventHandler(this.busesToolStripMenuItem_Click);
            // 
            // conductorsToolStripMenuItem
            // 
            this.conductorsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conductorsToolStripMenuItem.Name = "conductorsToolStripMenuItem";
            this.conductorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.conductorsToolStripMenuItem.Text = "Производители";
            this.conductorsToolStripMenuItem.Click += new System.EventHandler(this.conductorsToolStripMenuItem_Click);
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.routesToolStripMenuItem.Text = "Поставщики";
            this.routesToolStripMenuItem.Click += new System.EventHandler(this.routesToolStripMenuItem_Click);
            // 
            // отработанноеВремяВодителейToolStripMenuItem
            // 
            this.отработанноеВремяВодителейToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.отработанноеВремяВодителейToolStripMenuItem.Name = "отработанноеВремяВодителейToolStripMenuItem";
            this.отработанноеВремяВодителейToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отработанноеВремяВодителейToolStripMenuItem.Text = "Отделы";
            this.отработанноеВремяВодителейToolStripMenuItem.Click += new System.EventHandler(this.отработанноеВремяВодителейToolStripMenuItem_Click);
            // 
            // пробегАвтобусовToolStripMenuItem
            // 
            this.пробегАвтобусовToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.пробегАвтобусовToolStripMenuItem.Name = "пробегАвтобусовToolStripMenuItem";
            this.пробегАвтобусовToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.пробегАвтобусовToolStripMenuItem.Text = "Рота";
            this.пробегАвтобусовToolStripMenuItem.Click += new System.EventHandler(this.пробегАвтобусовToolStripMenuItem_Click);
            // 
            // путивыеЛистыToolStripMenuItem1
            // 
            this.путивыеЛистыToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.путивыеЛистыToolStripMenuItem1.Name = "путивыеЛистыToolStripMenuItem1";
            this.путивыеЛистыToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.путивыеЛистыToolStripMenuItem1.Text = "Договоры";
            this.путивыеЛистыToolStripMenuItem1.Click += new System.EventHandler(this.путивыеЛистыToolStripMenuItem1_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складToolStripMenuItem,
            this.шаблонДоговораНаПоставкуToolStripMenuItem});
            this.документыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("документыToolStripMenuItem.Image")));
            this.документыToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(125, 28);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("складToolStripMenuItem.Image")));
            this.складToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.складToolStripMenuItem.Text = "Склад";
            this.складToolStripMenuItem.Click += new System.EventHandler(this.путивыеЛистыToolStripMenuItem_Click);
            // 
            // шаблонДоговораНаПоставкуToolStripMenuItem
            // 
            this.шаблонДоговораНаПоставкуToolStripMenuItem.Name = "шаблонДоговораНаПоставкуToolStripMenuItem";
            this.шаблонДоговораНаПоставкуToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.шаблонДоговораНаПоставкуToolStripMenuItem.Text = "Шаблон договора на поставку";
            this.шаблонДоговораНаПоставкуToolStripMenuItem.Click += new System.EventHandler(this.шаблонДоговораНаПоставкуToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складТоваровToolStripMenuItem});
            this.отчетыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отчетыToolStripMenuItem.Image")));
            this.отчетыToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // складТоваровToolStripMenuItem
            // 
            this.складТоваровToolStripMenuItem.Name = "складТоваровToolStripMenuItem";
            this.складТоваровToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.складТоваровToolStripMenuItem.Text = "Склад ";
            this.складТоваровToolStripMenuItem.Click += new System.EventHandler(this.реестрПутёвокВодителейToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограмеToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.оПрограмеToolStripMenuItem.Text = "О програме";
            this.оПрограмеToolStripMenuItem.Click += new System.EventHandler(this.оПрограмеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(278, 26);
            this.справкаToolStripMenuItem1.Text = "Руководство пользователя";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // ВыходToolStripMenuItem
            // 
            this.ВыходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ВыходToolStripMenuItem.Image")));
            this.ВыходToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ВыходToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem";
            this.ВыходToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.ВыходToolStripMenuItem.Text = "Выход";
            this.ВыходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 489);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Склад";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem саправочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conductorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отработанноеВремяВодителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пробегАвтобусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путивыеЛистыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВыходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шаблонДоговораНаПоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
    }
}

