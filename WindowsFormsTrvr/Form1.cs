using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrvr
{
    public partial class Form1: Form
    {
        double[] array;
        double[] intervals;
        int N, K, M;

        double min, max, difference;

        public Form1()
        {
            InitializeComponent();
        }

        // создание выборки
        private void button1_Click(object sender, EventArgs e)
        {
            N = int.Parse(textBox1.Text);
            array = new double[N];
            Random r = new Random();

            if (checkedListBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.NextDouble();
                }
            }

            if (checkedListBox1.SelectedIndex == 1)
            {
                // Получаем параметры распределения из TextBox
                double mu = double.Parse(textBox4.Text);          // Мат. ожидание
                double sigma = double.Parse(textBox5.Text);       // Среднеквадратичное отклонение (вводится напрямую)
                double srednee = 0; // выборочное среднее
                double z_krit_85 = 1.44f; // квантиль при альфа = 0,925 (гамма = 0,85)
                double z_krit_95 = 1.96f; // квантиль при альфа = 0,975 (гамма = 0,95)
                double left_krit_85, right_krit_85; // границы доверительного интервала
                double left_krit_95, right_krit_95;


                for (int i = 0; i < array.Length; i++)
                {
                    // Генерация нормального распределения через ЦПТ
                    double sum = 0;
                    for (int j = 0; j < 40; j++)
                    {
                        sum += r.NextDouble();
                    }

                    // Масштабирование
                    array[i] = mu + sigma * (sum - 20) / Math.Sqrt(40 / 12.0);
                    srednee += array[i];
                }
                srednee /= N; // выборочное среднее

                left_krit_85 = srednee - z_krit_85 * sigma / Math.Sqrt(5);
                right_krit_85 = srednee + z_krit_85 * sigma / Math.Sqrt(N);
                left_krit_95 = srednee - z_krit_95 * sigma / Math.Sqrt(N);
                right_krit_95 = srednee + z_krit_95 * sigma / Math.Sqrt(N);
            }

            if (checkedListBox1.SelectedIndex == 2)
            {
                M = int.Parse(textBox2.Text); // кол-во интервалов
                double[] bord_array = new double[M]; // правые границы интервалов
                double[] freq_array = new double[M]; // наблюдаемые частоты (количество попаданий)

                // 1. Расчёт границ интервалов (равновероятных)
                double theor_prob = 1.0 / M; // теоретическая вероятность для каждого интервала
                double pos_x = theor_prob;

                for (int i = 0; i < M; i++)
                {
                    bord_array[i] = 2 * Math.Sqrt(pos_x);
                    pos_x += theor_prob;
                    freq_array[i] = 0;
                }

                // 2. Генерация выборки и подсчёт частот
                for (int i = 0; i < N; i++)
                {
                    int interval = r.Next(0, M); // случайный интервал
                    double local_left = (interval > 0) ? bord_array[interval - 1] : 0;
                    double local_right = bord_array[interval];

                    double c = r.NextDouble() * (local_right - local_left) + local_left;
                    array[i] = c;
                    freq_array[interval]++;
                }

                // 3. Расчёт χ²-статистики
                double kriteri_pirsona = 0;
                double expected_freq = N * theor_prob; // теоретическая частота для каждого интервала

                for (int i = 0; i < M; i++)
                {
                    kriteri_pirsona += Math.Pow(freq_array[i] - expected_freq, 2) / expected_freq;
                }

                label17.Text = kriteri_pirsona.ToString("F4"); // вывод с 4 знаками после запятой
            }


            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите тип распределения!");
            }

        }

        // создание гистограммы
        private void button2_Click(object sender, EventArgs e)
        {
            K = int.Parse(textBox3.Text);
            intervals = new double[K];
            double[] expected_freq = new double[K];

            // Находим min и max
            min = array.Min();
            max = array.Max();

            difference = (max - min) / K;
            double left = min;
            double right = min + difference;

            chart1.Series[0].Points.Clear();

            // Заполняем интервалы
            for (int i = 0; i < K; i++)
            {
                // Для последнего интервала включаем правую границу
                bool isLastInterval = (i == K - 1);
                int count = array.Count(x => x >= left && (isLastInterval ? x <= right : x < right));
                intervals[i] = count;

                expected_freq[i] = 0.25f * N * (Math.Pow(right, 2) - Math.Pow(left, 2));

                // Для гистограммы
                chart1.Series[0].Points.AddXY(left, (double)count / N / difference);

                left = right;
                right += difference;
            }

            if (checkedListBox1.SelectedIndex == 2)
            {
                double kriteri_pirsona = 0;
                int degrees_of_freedom = K - 1;  // Степени свободы

                for (int i = 0; i < K; i++)
                {
                    kriteri_pirsona += Math.Pow(intervals[i] - expected_freq[i], 2) / expected_freq[i];
                }

                label19.Text = kriteri_pirsona.ToString("F4");
                // Дополнительно можно вывести p-value или критическое значение
            }
        }

        // расчет характеристик
        private void button3_Click(object sender, EventArgs e)
        {
            double srednee = 0, dispersia = 0, moda, mediana, mediana_arr;

            for (int i = 0; i < N; i++)
            {
                srednee += array[i];
            }
            srednee *= (1 / (double)N);
            label9.Text = srednee.ToString();

            for (int i = 0; i < N; i++)
            {
                dispersia += Math.Pow((array[i] - srednee),2);
            }
            dispersia *= (1 / (double)(N - 1));
            label10.Text = dispersia.ToString();

            int i_moda = 0; // индекс интервала с модой
            for (int i = 0; i < K; i++)
            {
                if (intervals[i] > intervals[i_moda]) i_moda = i;
            }
            moda = min + i_moda * difference + (difference / 2);
            label11.Text = moda.ToString();

            i_moda = 0; // крамер
            for (int i = 1; i < K; i++)
            {
                if (intervals[i] > intervals[i_moda])
                    i_moda = i;
            }

            double h = difference;
            double f0 = (i_moda > 0) ? intervals[i_moda - 1] : 0;
            double f1 = intervals[i_moda];
            double f2 = (i_moda < K - 1) ? intervals[i_moda + 1] : 0;

            double delta1 = f1 - f0;
            double delta2 = f1 - f2;

            moda = min + (i_moda + delta1 / (delta1 + delta2)) * h;
            label14.Text = moda.ToString();

            // Расчет медианы
            Array.Sort(array);
            mediana_arr = (N % 2 == 1) ? array[N / 2] : (array[N / 2 - 1] + array[N / 2]) / 2;
            label15.Text = mediana_arr.ToString();

            // Расчет медианы по интервальному ряду
            int totalCount = N;
            int medianPosition = totalCount / 2;
            int accumulatedFreq = 0;
            int prevAccumulated = 0;
            int medianIntervalIndex = 0;

            // Находим медианный интервал
            for (int i = 0; i < K; i++)
            {
                accumulatedFreq += (int)intervals[i];
                if (accumulatedFreq >= medianPosition)
                {
                    medianIntervalIndex = i;
                    break;
                }
                prevAccumulated = accumulatedFreq;
            }

            // Вычисляем медиану по формуле
            double L = min + medianIntervalIndex * difference;
            double S_prev = prevAccumulated;
            double f_m = intervals[medianIntervalIndex];

            mediana = L + h * ((totalCount / 2.0 - S_prev) / f_m);
            label12.Text = mediana.ToString();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != checkedListBox1.SelectedIndex)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }

            if (checkedListBox1.SelectedIndex == 2)
            {
                label3.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                label3.Enabled = false;
            }

            if (checkedListBox1.SelectedIndex == 1)
            {
                label20.Enabled = true;
                label21.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
            else
            {
                label20.Enabled = false;
                label21.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
