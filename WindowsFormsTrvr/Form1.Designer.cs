namespace WindowsFormsTrvr
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.interval_85 = new System.Windows.Forms.Label();
            this.LK1 = new System.Windows.Forms.Label();
            this.S1 = new System.Windows.Forms.Label();
            this.LK2 = new System.Windows.Forms.Label();
            this.S2 = new System.Windows.Forms.Label();
            this.RK2 = new System.Windows.Forms.Label();
            this.RK1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.LK3 = new System.Windows.Forms.Label();
            this.S3 = new System.Windows.Forms.Label();
            this.LK4 = new System.Windows.Forms.Label();
            this.S4 = new System.Windows.Forms.Label();
            this.RK4 = new System.Windows.Forms.Label();
            this.RK3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.LK5 = new System.Windows.Forms.Label();
            this.S5 = new System.Windows.Forms.Label();
            this.LK6 = new System.Windows.Forms.Label();
            this.S6 = new System.Windows.Forms.Label();
            this.RK6 = new System.Windows.Forms.Label();
            this.RK5 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.LK7 = new System.Windows.Forms.Label();
            this.S7 = new System.Windows.Forms.Label();
            this.LK8 = new System.Windows.Forms.Label();
            this.S8 = new System.Windows.Forms.Label();
            this.RK8 = new System.Windows.Forms.Label();
            this.RK7 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 10);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(669, 479);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Объем выборки N";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид распределения";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во интервалов\r\nаппроксимации M";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество столбцов графа";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(816, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1127, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(854, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Равномерное",
            "Нормальное",
            "f(x) = 0.5x (0,2)"});
            this.checkedListBox1.Location = new System.Drawing.Point(816, 38);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(100, 49);
            this.checkedListBox1.TabIndex = 8;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(530, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Создать выборку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(984, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "Создать граф";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Среднее";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дисперсия";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Мода\r\n1) простая\r\n2) метод Крамера";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1043, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 39);
            this.label8.TabIndex = 14;
            this.label8.Text = "Медиана\r\n1) по выборке\r\n2) по интервальному ряду\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(767, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(767, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(975, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1184, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "---";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(831, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(396, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(694, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Статистические хар-ки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(975, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "---";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1184, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "---";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 495);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(267, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Критерий Пирсона по интервалам аппроксимации:";
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(334, 495);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "---";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 517);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(256, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Критерий Пирсона по интервалам гистограммы:";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(334, 517);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "---";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(960, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Мат. ожидание";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(960, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 26);
            this.label21.TabIndex = 28;
            this.label21.Text = "Среднеквадратическое\r\nотклонение";
            this.label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1127, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1127, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 30;
            // 
            // interval_85
            // 
            this.interval_85.AutoSize = true;
            this.interval_85.Location = new System.Drawing.Point(694, 323);
            this.interval_85.Name = "interval_85";
            this.interval_85.Size = new System.Drawing.Size(28, 26);
            this.interval_85.TabIndex = 31;
            this.interval_85.Text = "0.85\r\n0.95";
            this.interval_85.Click += new System.EventHandler(this.Interval_85_Click);
            // 
            // LK1
            // 
            this.LK1.AutoSize = true;
            this.LK1.Location = new System.Drawing.Point(764, 317);
            this.LK1.Name = "LK1";
            this.LK1.Size = new System.Drawing.Size(16, 13);
            this.LK1.TabIndex = 31;
            this.LK1.Text = "---";
            // 
            // S1
            // 
            this.S1.AutoSize = true;
            this.S1.Location = new System.Drawing.Point(836, 317);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(16, 13);
            this.S1.TabIndex = 31;
            this.S1.Text = "---";
            this.S1.Click += new System.EventHandler(this.Label24_Click);
            // 
            // LK2
            // 
            this.LK2.AutoSize = true;
            this.LK2.Location = new System.Drawing.Point(764, 336);
            this.LK2.Name = "LK2";
            this.LK2.Size = new System.Drawing.Size(16, 13);
            this.LK2.TabIndex = 31;
            this.LK2.Text = "---";
            // 
            // S2
            // 
            this.S2.AutoSize = true;
            this.S2.Location = new System.Drawing.Point(836, 336);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(16, 13);
            this.S2.TabIndex = 31;
            this.S2.Text = "---";
            // 
            // RK2
            // 
            this.RK2.AutoSize = true;
            this.RK2.Location = new System.Drawing.Point(910, 336);
            this.RK2.Name = "RK2";
            this.RK2.Size = new System.Drawing.Size(16, 13);
            this.RK2.TabIndex = 31;
            this.RK2.Text = "---";
            this.RK2.Click += new System.EventHandler(this.Label28_Click);
            // 
            // RK1
            // 
            this.RK1.AutoSize = true;
            this.RK1.Location = new System.Drawing.Point(910, 317);
            this.RK1.Name = "RK1";
            this.RK1.Size = new System.Drawing.Size(16, 13);
            this.RK1.TabIndex = 31;
            this.RK1.Text = "---";
            this.RK1.Click += new System.EventHandler(this.Label28_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(694, 301);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(359, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "Доверительные интервалы для мат ожидания, известная дисперсия";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(694, 360);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(371, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Доверительные интервалы для мат ожидания, неизвестная дисперсия";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(694, 387);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 26);
            this.label24.TabIndex = 31;
            this.label24.Text = "0.85\r\n0.95";
            this.label24.Click += new System.EventHandler(this.Interval_85_Click);
            // 
            // LK3
            // 
            this.LK3.AutoSize = true;
            this.LK3.Location = new System.Drawing.Point(764, 381);
            this.LK3.Name = "LK3";
            this.LK3.Size = new System.Drawing.Size(16, 13);
            this.LK3.TabIndex = 31;
            this.LK3.Text = "---";
            // 
            // S3
            // 
            this.S3.AutoSize = true;
            this.S3.Location = new System.Drawing.Point(836, 381);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(16, 13);
            this.S3.TabIndex = 31;
            this.S3.Text = "---";
            this.S3.Click += new System.EventHandler(this.Label24_Click);
            // 
            // LK4
            // 
            this.LK4.AutoSize = true;
            this.LK4.Location = new System.Drawing.Point(764, 400);
            this.LK4.Name = "LK4";
            this.LK4.Size = new System.Drawing.Size(16, 13);
            this.LK4.TabIndex = 31;
            this.LK4.Text = "---";
            // 
            // S4
            // 
            this.S4.AutoSize = true;
            this.S4.Location = new System.Drawing.Point(836, 400);
            this.S4.Name = "S4";
            this.S4.Size = new System.Drawing.Size(16, 13);
            this.S4.TabIndex = 31;
            this.S4.Text = "---";
            // 
            // RK4
            // 
            this.RK4.AutoSize = true;
            this.RK4.Location = new System.Drawing.Point(910, 400);
            this.RK4.Name = "RK4";
            this.RK4.Size = new System.Drawing.Size(16, 13);
            this.RK4.TabIndex = 31;
            this.RK4.Text = "---";
            this.RK4.Click += new System.EventHandler(this.Label28_Click);
            // 
            // RK3
            // 
            this.RK3.AutoSize = true;
            this.RK3.Location = new System.Drawing.Point(910, 381);
            this.RK3.Name = "RK3";
            this.RK3.Size = new System.Drawing.Size(16, 13);
            this.RK3.TabIndex = 31;
            this.RK3.Text = "---";
            this.RK3.Click += new System.EventHandler(this.Label28_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(694, 447);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 26);
            this.label25.TabIndex = 31;
            this.label25.Text = "0.85\r\n0.95";
            this.label25.Click += new System.EventHandler(this.Interval_85_Click);
            // 
            // LK5
            // 
            this.LK5.AutoSize = true;
            this.LK5.Location = new System.Drawing.Point(764, 441);
            this.LK5.Name = "LK5";
            this.LK5.Size = new System.Drawing.Size(16, 13);
            this.LK5.TabIndex = 31;
            this.LK5.Text = "---";
            // 
            // S5
            // 
            this.S5.AutoSize = true;
            this.S5.Location = new System.Drawing.Point(836, 441);
            this.S5.Name = "S5";
            this.S5.Size = new System.Drawing.Size(16, 13);
            this.S5.TabIndex = 31;
            this.S5.Text = "---";
            this.S5.Click += new System.EventHandler(this.Label24_Click);
            // 
            // LK6
            // 
            this.LK6.AutoSize = true;
            this.LK6.Location = new System.Drawing.Point(764, 460);
            this.LK6.Name = "LK6";
            this.LK6.Size = new System.Drawing.Size(16, 13);
            this.LK6.TabIndex = 31;
            this.LK6.Text = "---";
            // 
            // S6
            // 
            this.S6.AutoSize = true;
            this.S6.Location = new System.Drawing.Point(836, 460);
            this.S6.Name = "S6";
            this.S6.Size = new System.Drawing.Size(16, 13);
            this.S6.TabIndex = 31;
            this.S6.Text = "---";
            // 
            // RK6
            // 
            this.RK6.AutoSize = true;
            this.RK6.Location = new System.Drawing.Point(910, 460);
            this.RK6.Name = "RK6";
            this.RK6.Size = new System.Drawing.Size(16, 13);
            this.RK6.TabIndex = 31;
            this.RK6.Text = "---";
            this.RK6.Click += new System.EventHandler(this.Label28_Click);
            // 
            // RK5
            // 
            this.RK5.AutoSize = true;
            this.RK5.Location = new System.Drawing.Point(910, 441);
            this.RK5.Name = "RK5";
            this.RK5.Size = new System.Drawing.Size(16, 13);
            this.RK5.TabIndex = 31;
            this.RK5.Text = "---";
            this.RK5.Click += new System.EventHandler(this.Label28_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(694, 420);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(359, 13);
            this.label32.TabIndex = 32;
            this.label32.Text = "Доверительные интервалы для дисперсии, известное мат ожидание";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(694, 513);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(28, 26);
            this.label33.TabIndex = 31;
            this.label33.Text = "0.85\r\n0.95";
            this.label33.Click += new System.EventHandler(this.Interval_85_Click);
            // 
            // LK7
            // 
            this.LK7.AutoSize = true;
            this.LK7.Location = new System.Drawing.Point(764, 507);
            this.LK7.Name = "LK7";
            this.LK7.Size = new System.Drawing.Size(16, 13);
            this.LK7.TabIndex = 31;
            this.LK7.Text = "---";
            // 
            // S7
            // 
            this.S7.AutoSize = true;
            this.S7.Location = new System.Drawing.Point(836, 507);
            this.S7.Name = "S7";
            this.S7.Size = new System.Drawing.Size(16, 13);
            this.S7.TabIndex = 31;
            this.S7.Text = "---";
            this.S7.Click += new System.EventHandler(this.Label24_Click);
            // 
            // LK8
            // 
            this.LK8.AutoSize = true;
            this.LK8.Location = new System.Drawing.Point(764, 526);
            this.LK8.Name = "LK8";
            this.LK8.Size = new System.Drawing.Size(16, 13);
            this.LK8.TabIndex = 31;
            this.LK8.Text = "---";
            // 
            // S8
            // 
            this.S8.AutoSize = true;
            this.S8.Location = new System.Drawing.Point(836, 526);
            this.S8.Name = "S8";
            this.S8.Size = new System.Drawing.Size(16, 13);
            this.S8.TabIndex = 31;
            this.S8.Text = "---";
            // 
            // RK8
            // 
            this.RK8.AutoSize = true;
            this.RK8.Location = new System.Drawing.Point(910, 526);
            this.RK8.Name = "RK8";
            this.RK8.Size = new System.Drawing.Size(16, 13);
            this.RK8.TabIndex = 31;
            this.RK8.Text = "---";
            this.RK8.Click += new System.EventHandler(this.Label28_Click);
            // 
            // RK7
            // 
            this.RK7.AutoSize = true;
            this.RK7.Location = new System.Drawing.Point(910, 507);
            this.RK7.Name = "RK7";
            this.RK7.Size = new System.Drawing.Size(16, 13);
            this.RK7.TabIndex = 31;
            this.RK7.Text = "---";
            this.RK7.Click += new System.EventHandler(this.Label28_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(694, 485);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(371, 13);
            this.label40.TabIndex = 32;
            this.label40.Text = "Доверительные интервалы для дисперсии, неизвестное мат ожидание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 702);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.RK7);
            this.Controls.Add(this.RK5);
            this.Controls.Add(this.RK3);
            this.Controls.Add(this.RK1);
            this.Controls.Add(this.RK8);
            this.Controls.Add(this.RK6);
            this.Controls.Add(this.RK4);
            this.Controls.Add(this.RK2);
            this.Controls.Add(this.S8);
            this.Controls.Add(this.S6);
            this.Controls.Add(this.S4);
            this.Controls.Add(this.LK8);
            this.Controls.Add(this.LK6);
            this.Controls.Add(this.S7);
            this.Controls.Add(this.LK4);
            this.Controls.Add(this.S5);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.LK7);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.LK5);
            this.Controls.Add(this.LK2);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.LK3);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.LK1);
            this.Controls.Add(this.interval_85);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label interval_85;
        private System.Windows.Forms.Label LK1;
        private System.Windows.Forms.Label S1;
        private System.Windows.Forms.Label LK2;
        private System.Windows.Forms.Label S2;
        private System.Windows.Forms.Label RK2;
        private System.Windows.Forms.Label RK1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label LK3;
        private System.Windows.Forms.Label S3;
        private System.Windows.Forms.Label LK4;
        private System.Windows.Forms.Label S4;
        private System.Windows.Forms.Label RK4;
        private System.Windows.Forms.Label RK3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label LK5;
        private System.Windows.Forms.Label S5;
        private System.Windows.Forms.Label LK6;
        private System.Windows.Forms.Label S6;
        private System.Windows.Forms.Label RK6;
        private System.Windows.Forms.Label RK5;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label LK7;
        private System.Windows.Forms.Label S7;
        private System.Windows.Forms.Label LK8;
        private System.Windows.Forms.Label S8;
        private System.Windows.Forms.Label RK8;
        private System.Windows.Forms.Label RK7;
        private System.Windows.Forms.Label label40;
    }
}

