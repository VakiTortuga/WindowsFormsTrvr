using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsTrvr
{
    public partial class Form1: Form
    {
        double[] array;
        double[] intervals;
        int N, K, M;

        double min, max, difference;
        bool isGistogramm = false;

        public Form1()
        {
            InitializeComponent();
        }

        // создание выборки
        private void Button1_Click(object sender, EventArgs e)
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

            // нормальное распределение
            if (checkedListBox1.SelectedIndex == 1)
            {
                Microsoft.Office.Interop.Excel.Application _ex = new Microsoft.Office.Interop.Excel.Application();

                // Получаем параметры распределения из TextBox
                double alpha15 = 0.15;
                double alpha05 = 0.05;

                double mu_setted = double.Parse(textBox4.Text);          // Мат. ожидание
                double sigma_setted = double.Parse(textBox5.Text);       // Среднеквадратичное отклонение
                double srednee = 0, kvadr_otklon = 0, dispersia = 0; // выборочное среднее

                double margine; // эпсилон для доверительного интервала
                double left_krit, right_krit; // границы доверительного интервала


                for (int i = 0; i < array.Length; i++)
                {
                    // Генерация нормального распределения через ЦПТ
                    double sum = 0;
                    for (int j = 0; j < 40; j++)
                    {
                        sum += r.NextDouble();
                    }

                    // Масштабирование
                    array[i] = mu_setted + sigma_setted * (sum - 20) / Math.Sqrt(40 / 12.0);
                    srednee += array[i];
                }
                srednee /= N; // выборочное среднее

                for (int i = 0; i < array.Length; i++)
                {
                    kvadr_otklon += Math.Pow(array[i] - srednee, 2);
                }
                dispersia = kvadr_otklon / ((double)N - 1);

                // 0.15, матожидание, известная дисперсия
                margine = _ex.WorksheetFunction.Norm_S_Inv(1 - alpha15 / 2) * sigma_setted / Math.Sqrt(N);
                left_krit = srednee - margine;
                right_krit = srednee + margine;
                LK1.Text = left_krit.ToString("F4");
                RK1.Text = right_krit.ToString("F4");
                S1.Text = mu_setted.ToString("F4");

                // 0.05, матожидание, известная дисперсия
                margine = _ex.WorksheetFunction.Norm_S_Inv(1 - alpha05 / 2) * sigma_setted / Math.Sqrt(N);
                left_krit = srednee -  margine;
                right_krit = srednee + margine;
                LK2.Text = left_krit.ToString("F4");
                RK2.Text = right_krit.ToString("F4");
                S2.Text = mu_setted.ToString("F4");

                // 0.15, матожидание, неизвестная дисперсия
                margine = _ex.WorksheetFunction.T_Inv(1 - alpha15 / 2, N - 1) * Math.Sqrt(dispersia / (double)N);
                left_krit = srednee - margine;
                right_krit = srednee + margine;
                LK3.Text = left_krit.ToString("F4");
                RK3.Text = right_krit.ToString("F4");
                S3.Text = mu_setted.ToString("F4");

                // 0.05, матожидание, неизвестная дисперсия
                margine = _ex.WorksheetFunction.T_Inv(1 - alpha05 / 2, N - 1) * Math.Sqrt(dispersia / (double)N);
                left_krit = srednee - margine;
                right_krit = srednee + margine;
                LK4.Text = left_krit.ToString("F4");
                RK4.Text = right_krit.ToString("F4");
                S4.Text = mu_setted.ToString("F4");

                // 0.85, дисперсия, известное мат ожидание
                right_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(1 - alpha15 / 2, N);
                left_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(alpha15 / 2, N);
                LK5.Text = left_krit.ToString("F4");
                RK5.Text = right_krit.ToString("F4");
                S5.Text = Math.Pow(sigma_setted, 2).ToString("F4");

                // 0.95, дисперсия, известное мат ожидание
                right_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(1 - alpha05 / 2, N);
                left_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(alpha05 / 2, N);
                LK6.Text = left_krit.ToString("F4");
                RK6.Text = right_krit.ToString("F4");
                S6.Text = Math.Pow(sigma_setted, 2).ToString("F4");

                // 0.85, дисперсия, неизвестное мат ожидание
                right_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(1 - alpha15 / 2, N - 1);
                left_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(alpha15 / 2, N - 1);
                LK7.Text = left_krit.ToString("F4");
                RK7.Text = right_krit.ToString("F4");
                S7.Text = Math.Pow(sigma_setted, 2).ToString("F4");

                // 0.95, дисперсия, неизвестное мат ожидание
                right_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(1 - alpha05 / 2, N - 1);
                left_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(alpha05 / 2, N - 1);
                LK8.Text = left_krit.ToString("F4");
                RK8.Text = right_krit.ToString("F4");
                S8.Text = Math.Pow(sigma_setted, 2).ToString("F4");

                // Путь к файлу (измените на свой)
                string filePath = "C:\\Users\\user\\source\\repos\\WindowsFormsTrvr\\WindowsFormsTrvr\\report.txt";

                // Запись в файл
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Заголовок
                    writer.WriteLine("=== АНАЛИЗ ВЫБОРКИ ===");
                    writer.WriteLine($"Дата создания: {DateTime.Now}\n");

                    Array.Sort(array);

                    // Основные статистики
                    writer.WriteLine($"Размер выборки: {array.Length} элементов");
                    writer.WriteLine($"Среднее значение: {srednee:F4}");
                    writer.WriteLine($"Исправленная дисперсия: {dispersia:F4}");
                    writer.WriteLine($"Стандартное отклонение: {Math.Sqrt(dispersia):F4}");
                    writer.WriteLine($"Минимум: {array.Min():F4}");
                    writer.WriteLine($"Максимум: {array.Max():F4}\n");

                    int elementsToShow = array.Length;
                    int elementsPerLine = 10;
                    writer.WriteLine($"Элементы выборки:");

                    for (int i = 0; i < elementsToShow; i++)
                    {
                        // Форматирование элемента
                        writer.Write($"{array[i],6:F4}");

                        // Переход на новую строку после каждого 10-го элемента
                        if ((i + 1) % elementsPerLine == 0 || i == array.Length - 1)
                        {
                            writer.WriteLine();
                        }
                        else
                        {
                            // Три пробела между элементами
                            writer.Write("  ");
                        }
                    }

                    writer.WriteLine("\n=== КОНЕЦ ОТЧЁТА ===");
                }
            }

            if (checkedListBox1.SelectedIndex == 2)
            {
                M = int.Parse(textBox2.Text); // кол-во интервалов
                double[] borders_array = new double[M]; // правые границы интервалов
                double[] freq_array = new double[M]; // наблюдаемые частоты (количество попаданий)

                // 1. Расчёт границ интервалов (равновероятных)
                double theor_prob = 1.0 / M; // теоретическая вероятность для каждого интервала
                double pos_x = theor_prob;

                for (int i = 0; i < M; i++)
                {
                    borders_array[i] = 2 * Math.Sqrt(pos_x);
                    pos_x += theor_prob;
                    freq_array[i] = 0;
                }

                // 2. Генерация выборки и подсчёт частот
                for (int i = 0; i < N; i++)
                {
                    int interval = r.Next(0, M); // случайный интервал
                    double local_left = (interval > 0) ? borders_array[interval - 1] : 0;
                    double local_right = borders_array[interval];

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
            else
            {
                isGistogramm = false;
            }

        }

        // создание гистограммы
        private void Button2_Click(object sender, EventArgs e)
        {
            K = int.Parse(textBox3.Text);
            intervals = new double[K];
            double[] expected_freq = new double[K];
            isGistogramm = true;


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
        private void Button3_Click(object sender, EventArgs e)
        {
            double srednee = 0, dispersia = 0, moda, mediana, mediana_arr;

            for (int i = 0; i < N; i++)
            {
                srednee += array[i];
            }
            srednee *= (1 / (double)N);
            label9.Text = srednee.ToString("F4");

            for (int i = 0; i < N; i++)
            {
                dispersia += Math.Pow((array[i] - srednee),2);
            }
            dispersia *= (1 / (double)(N - 1));
            label10.Text = dispersia.ToString("F4");
            int i_moda = 0; // индекс интервала с модой

            // Расчет медианы по выборке
            Array.Sort(array);
            mediana_arr = (N % 2 == 1) ? array[N / 2] : (array[N / 2 - 1] + array[N / 2]) / 2;
            label12.Text = mediana_arr.ToString("F4");

            if (isGistogramm == true)
            {
                for (int i = 0; i < K; i++)
                {
                    if (intervals[i] > intervals[i_moda]) i_moda = i;
                }
                moda = min + i_moda * difference + (difference / 2);
                label11.Text = moda.ToString("F4");

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
                label14.Text = moda.ToString("F4");

                

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
                label15.Text = mediana.ToString("F4");
            }






        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Label28_Click(object sender, EventArgs e)
        {

        }


        private void Interval_85_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
