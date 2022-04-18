
namespace ProjectMVP.View
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.groupBoxTableDelete = new System.Windows.Forms.GroupBox();
            this.buttonTableDelete = new System.Windows.Forms.Button();
            this.groupBoxTableFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.checkBoxUnpaid = new System.Windows.Forms.CheckBox();
            this.textBoxFindByName = new System.Windows.Forms.TextBox();
            this.buttonFindByName = new System.Windows.Forms.Button();
            this.dateTimePickerFindByDate = new System.Windows.Forms.DateTimePicker();
            this.buttonTableUpdateAll = new System.Windows.Forms.Button();
            this.groupBoxTableAdd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTableCount = new System.Windows.Forms.TextBox();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.buttonTableAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageIncome = new System.Windows.Forms.TabPage();
            this.groupBoxStatisticsIncome = new System.Windows.Forms.GroupBox();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickerStatisticIncomeEndPeriod = new System.Windows.Forms.DateTimePicker();
            this.buttonStatisticIncome = new System.Windows.Forms.Button();
            this.dateTimePickerStatisticIncomeStartPeriod = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUpdateCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.groupBoxTableDelete.SuspendLayout();
            this.groupBoxTableFilter.SuspendLayout();
            this.groupBoxTableAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.tabPageIncome.SuspendLayout();
            this.groupBoxStatisticsIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            this.groupBoxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTable);
            this.tabControl.Controls.Add(this.tabPageIncome);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(608, 594);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            // 
            // tabPageTable
            // 
            this.tabPageTable.BackColor = System.Drawing.Color.White;
            this.tabPageTable.Controls.Add(this.groupBoxUpdate);
            this.tabPageTable.Controls.Add(this.groupBoxTableDelete);
            this.tabPageTable.Controls.Add(this.groupBoxTableFilter);
            this.tabPageTable.Controls.Add(this.groupBoxTableAdd);
            this.tabPageTable.Controls.Add(this.dataGridViewTable);
            this.tabPageTable.Controls.Add(this.menuStrip);
            this.tabPageTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(600, 568);
            this.tabPageTable.TabIndex = 1;
            this.tabPageTable.Text = "Таблица";
            // 
            // groupBoxTableDelete
            // 
            this.groupBoxTableDelete.Controls.Add(this.buttonTableDelete);
            this.groupBoxTableDelete.Location = new System.Drawing.Point(241, 447);
            this.groupBoxTableDelete.Name = "groupBoxTableDelete";
            this.groupBoxTableDelete.Size = new System.Drawing.Size(356, 52);
            this.groupBoxTableDelete.TabIndex = 13;
            this.groupBoxTableDelete.TabStop = false;
            this.groupBoxTableDelete.Text = "Удаление";
            // 
            // buttonTableDelete
            // 
            this.buttonTableDelete.BackColor = System.Drawing.Color.White;
            this.buttonTableDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonTableDelete.Location = new System.Drawing.Point(75, 19);
            this.buttonTableDelete.Name = "buttonTableDelete";
            this.buttonTableDelete.Size = new System.Drawing.Size(200, 23);
            this.buttonTableDelete.TabIndex = 0;
            this.buttonTableDelete.Text = "Удалить";
            this.buttonTableDelete.UseVisualStyleBackColor = false;
            this.buttonTableDelete.Click += new System.EventHandler(this.buttonTableDelete_Click);
            // 
            // groupBoxTableFilter
            // 
            this.groupBoxTableFilter.Controls.Add(this.checkBoxName);
            this.groupBoxTableFilter.Controls.Add(this.checkBoxData);
            this.groupBoxTableFilter.Controls.Add(this.checkBoxUnpaid);
            this.groupBoxTableFilter.Controls.Add(this.textBoxFindByName);
            this.groupBoxTableFilter.Controls.Add(this.buttonFindByName);
            this.groupBoxTableFilter.Controls.Add(this.dateTimePickerFindByDate);
            this.groupBoxTableFilter.Controls.Add(this.buttonTableUpdateAll);
            this.groupBoxTableFilter.Location = new System.Drawing.Point(241, 330);
            this.groupBoxTableFilter.Name = "groupBoxTableFilter";
            this.groupBoxTableFilter.Size = new System.Drawing.Size(356, 118);
            this.groupBoxTableFilter.TabIndex = 6;
            this.groupBoxTableFilter.TabStop = false;
            this.groupBoxTableFilter.Text = "Фильтр";
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(6, 89);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(76, 17);
            this.checkBoxName.TabIndex = 18;
            this.checkBoxName.Text = "Название";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(6, 54);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(52, 17);
            this.checkBoxData.TabIndex = 17;
            this.checkBoxData.Text = "Дата";
            this.checkBoxData.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnpaid
            // 
            this.checkBoxUnpaid.AutoSize = true;
            this.checkBoxUnpaid.Location = new System.Drawing.Point(6, 21);
            this.checkBoxUnpaid.Name = "checkBoxUnpaid";
            this.checkBoxUnpaid.Size = new System.Drawing.Size(101, 17);
            this.checkBoxUnpaid.TabIndex = 16;
            this.checkBoxUnpaid.Text = "Неоплаченные";
            this.checkBoxUnpaid.UseVisualStyleBackColor = true;
            // 
            // textBoxFindByName
            // 
            this.textBoxFindByName.Location = new System.Drawing.Point(102, 87);
            this.textBoxFindByName.Name = "textBoxFindByName";
            this.textBoxFindByName.Size = new System.Drawing.Size(149, 20);
            this.textBoxFindByName.TabIndex = 13;
            // 
            // buttonFindByName
            // 
            this.buttonFindByName.BackColor = System.Drawing.Color.White;
            this.buttonFindByName.ForeColor = System.Drawing.Color.Black;
            this.buttonFindByName.Location = new System.Drawing.Point(260, 73);
            this.buttonFindByName.Name = "buttonFindByName";
            this.buttonFindByName.Size = new System.Drawing.Size(90, 38);
            this.buttonFindByName.TabIndex = 15;
            this.buttonFindByName.Text = "Поиск";
            this.buttonFindByName.UseVisualStyleBackColor = false;
            this.buttonFindByName.Click += new System.EventHandler(this.buttonFindByFilter_Click_1);
            // 
            // dateTimePickerFindByDate
            // 
            this.dateTimePickerFindByDate.Location = new System.Drawing.Point(102, 52);
            this.dateTimePickerFindByDate.Name = "dateTimePickerFindByDate";
            this.dateTimePickerFindByDate.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerFindByDate.TabIndex = 13;
            // 
            // buttonTableUpdateAll
            // 
            this.buttonTableUpdateAll.BackColor = System.Drawing.Color.White;
            this.buttonTableUpdateAll.ForeColor = System.Drawing.Color.Black;
            this.buttonTableUpdateAll.Location = new System.Drawing.Point(260, 16);
            this.buttonTableUpdateAll.Name = "buttonTableUpdateAll";
            this.buttonTableUpdateAll.Size = new System.Drawing.Size(90, 37);
            this.buttonTableUpdateAll.TabIndex = 0;
            this.buttonTableUpdateAll.Text = " Очистить";
            this.buttonTableUpdateAll.UseVisualStyleBackColor = false;
            this.buttonTableUpdateAll.Click += new System.EventHandler(this.buttonTableUpdateAll_Click);
            // 
            // groupBoxTableAdd
            // 
            this.groupBoxTableAdd.BackColor = System.Drawing.Color.White;
            this.groupBoxTableAdd.Controls.Add(this.label2);
            this.groupBoxTableAdd.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxTableAdd.Controls.Add(this.label7);
            this.groupBoxTableAdd.Controls.Add(this.label8);
            this.groupBoxTableAdd.Controls.Add(this.textBoxTableCount);
            this.groupBoxTableAdd.Controls.Add(this.textBoxTableName);
            this.groupBoxTableAdd.Controls.Add(this.buttonTableAdd);
            this.groupBoxTableAdd.Controls.Add(this.label10);
            this.groupBoxTableAdd.Controls.Add(this.dateTimePickerStart);
            this.groupBoxTableAdd.Location = new System.Drawing.Point(3, 330);
            this.groupBoxTableAdd.Name = "groupBoxTableAdd";
            this.groupBoxTableAdd.Size = new System.Drawing.Size(232, 169);
            this.groupBoxTableAdd.TabIndex = 5;
            this.groupBoxTableAdd.TabStop = false;
            this.groupBoxTableAdd.Text = "Добавление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Конец";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(72, 117);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerEnd.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Название";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Кол - во";
            // 
            // textBoxTableCount
            // 
            this.textBoxTableCount.Location = new System.Drawing.Point(72, 52);
            this.textBoxTableCount.Name = "textBoxTableCount";
            this.textBoxTableCount.Size = new System.Drawing.Size(149, 20);
            this.textBoxTableCount.TabIndex = 6;
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(72, 19);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(149, 20);
            this.textBoxTableName.TabIndex = 5;
            // 
            // buttonTableAdd
            // 
            this.buttonTableAdd.BackColor = System.Drawing.Color.White;
            this.buttonTableAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTableAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonTableAdd.Location = new System.Drawing.Point(72, 140);
            this.buttonTableAdd.Name = "buttonTableAdd";
            this.buttonTableAdd.Size = new System.Drawing.Size(149, 23);
            this.buttonTableAdd.TabIndex = 4;
            this.buttonTableAdd.Text = "Добавить";
            this.buttonTableAdd.UseVisualStyleBackColor = false;
            this.buttonTableAdd.Click += new System.EventHandler(this.buttonTableAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Начало";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(72, 87);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerStart.TabIndex = 2;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTable.Location = new System.Drawing.Point(3, 27);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(594, 297);
            this.dataGridViewTable.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(594, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьСкладToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.создатьToolStripMenuItem.Text = "Создать склад";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьСкладToolStripMenuItem
            // 
            this.сохранитьСкладToolStripMenuItem.Name = "сохранитьСкладToolStripMenuItem";
            this.сохранитьСкладToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сохранитьСкладToolStripMenuItem.Text = "Сохранить склад";
            this.сохранитьСкладToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСкладToolStripMenuItem_Click);
            // 
            // tabPageIncome
            // 
            this.tabPageIncome.Controls.Add(this.groupBoxStatisticsIncome);
            this.tabPageIncome.Location = new System.Drawing.Point(4, 22);
            this.tabPageIncome.Name = "tabPageIncome";
            this.tabPageIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncome.Size = new System.Drawing.Size(600, 505);
            this.tabPageIncome.TabIndex = 0;
            this.tabPageIncome.Text = "Доходы";
            // 
            // groupBoxStatisticsIncome
            // 
            this.groupBoxStatisticsIncome.Controls.Add(this.chartIncome);
            this.groupBoxStatisticsIncome.Controls.Add(this.dateTimePickerStatisticIncomeEndPeriod);
            this.groupBoxStatisticsIncome.Controls.Add(this.buttonStatisticIncome);
            this.groupBoxStatisticsIncome.Controls.Add(this.dateTimePickerStatisticIncomeStartPeriod);
            this.groupBoxStatisticsIncome.Controls.Add(this.label12);
            this.groupBoxStatisticsIncome.Controls.Add(this.label14);
            this.groupBoxStatisticsIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStatisticsIncome.Location = new System.Drawing.Point(3, 3);
            this.groupBoxStatisticsIncome.Name = "groupBoxStatisticsIncome";
            this.groupBoxStatisticsIncome.Size = new System.Drawing.Size(594, 499);
            this.groupBoxStatisticsIncome.TabIndex = 1;
            this.groupBoxStatisticsIncome.TabStop = false;
            this.groupBoxStatisticsIncome.Text = "Доходы";
            // 
            // chartIncome
            // 
            this.chartIncome.BackColor = System.Drawing.SystemColors.Control;
            this.chartIncome.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea1);
            this.chartIncome.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartIncome.Legends.Add(legend1);
            this.chartIncome.Location = new System.Drawing.Point(3, 125);
            this.chartIncome.Name = "chartIncome";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartIncome.Series.Add(series1);
            this.chartIncome.Size = new System.Drawing.Size(588, 371);
            this.chartIncome.TabIndex = 19;
            this.chartIncome.Text = "Граффик";
            // 
            // dateTimePickerStatisticIncomeEndPeriod
            // 
            this.dateTimePickerStatisticIncomeEndPeriod.Location = new System.Drawing.Point(477, 14);
            this.dateTimePickerStatisticIncomeEndPeriod.Name = "dateTimePickerStatisticIncomeEndPeriod";
            this.dateTimePickerStatisticIncomeEndPeriod.Size = new System.Drawing.Size(222, 20);
            this.dateTimePickerStatisticIncomeEndPeriod.TabIndex = 17;
            // 
            // buttonStatisticIncome
            // 
            this.buttonStatisticIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatisticIncome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonStatisticIncome.Location = new System.Drawing.Point(242, 56);
            this.buttonStatisticIncome.Name = "buttonStatisticIncome";
            this.buttonStatisticIncome.Size = new System.Drawing.Size(144, 23);
            this.buttonStatisticIncome.TabIndex = 12;
            this.buttonStatisticIncome.Text = "Добавить";
            this.buttonStatisticIncome.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStatisticIncomeStartPeriod
            // 
            this.dateTimePickerStatisticIncomeStartPeriod.Location = new System.Drawing.Point(123, 14);
            this.dateTimePickerStatisticIncomeStartPeriod.Name = "dateTimePickerStatisticIncomeStartPeriod";
            this.dateTimePickerStatisticIncomeStartPeriod.Size = new System.Drawing.Size(222, 20);
            this.dateTimePickerStatisticIncomeStartPeriod.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Location = new System.Drawing.Point(17, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Начало интервала";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label14.Location = new System.Drawing.Point(377, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Конец интервала";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.buttonUpdate);
            this.groupBoxUpdate.Controls.Add(this.label4);
            this.groupBoxUpdate.Controls.Add(this.label3);
            this.groupBoxUpdate.Controls.Add(this.dateTimePickerUpdate);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateCount);
            this.groupBoxUpdate.Controls.Add(this.label1);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateName);
            this.groupBoxUpdate.Location = new System.Drawing.Point(3, 499);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(594, 66);
            this.groupBoxUpdate.TabIndex = 14;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Обновление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название";
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(6, 40);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(149, 20);
            this.textBoxUpdateName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(211, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Кол - во";
            // 
            // textBoxUpdateCount
            // 
            this.textBoxUpdateCount.Location = new System.Drawing.Point(169, 40);
            this.textBoxUpdateCount.Name = "textBoxUpdateCount";
            this.textBoxUpdateCount.Size = new System.Drawing.Size(149, 20);
            this.textBoxUpdateCount.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(382, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Конец";
            // 
            // dateTimePickerUpdate
            // 
            this.dateTimePickerUpdate.Location = new System.Drawing.Point(334, 40);
            this.dateTimePickerUpdate.Name = "dateTimePickerUpdate";
            this.dateTimePickerUpdate.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerUpdate.TabIndex = 13;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(498, 19);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(90, 41);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 594);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            this.tabPageTable.PerformLayout();
            this.groupBoxTableDelete.ResumeLayout(false);
            this.groupBoxTableFilter.ResumeLayout(false);
            this.groupBoxTableFilter.PerformLayout();
            this.groupBoxTableAdd.ResumeLayout(false);
            this.groupBoxTableAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPageIncome.ResumeLayout(false);
            this.groupBoxStatisticsIncome.ResumeLayout(false);
            this.groupBoxStatisticsIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageIncome;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.GroupBox groupBoxTableFilter;
        private System.Windows.Forms.Button buttonTableUpdateAll;
        private System.Windows.Forms.GroupBox groupBoxTableAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTableCount;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.Button buttonTableAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.GroupBox groupBoxTableDelete;
        private System.Windows.Forms.Button buttonTableDelete;
        private System.Windows.Forms.GroupBox groupBoxStatisticsIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private System.Windows.Forms.DateTimePicker dateTimePickerStatisticIncomeEndPeriod;
        private System.Windows.Forms.Button buttonStatisticIncome;
        private System.Windows.Forms.DateTimePicker dateTimePickerStatisticIncomeStartPeriod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBoxFindByName;
        private System.Windows.Forms.Button buttonFindByName;
        private System.Windows.Forms.DateTimePicker dateTimePickerFindByDate;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСкладToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxUnpaid;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdate;
        private System.Windows.Forms.TextBox textBoxUpdateCount;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

