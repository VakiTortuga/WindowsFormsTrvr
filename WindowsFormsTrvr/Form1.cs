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
        double[] array; // массив выборки
        double[] intervals; // кол-во элементов в интервале гистограммы
        int N = 0, K = 0, M = 0; // кол-во элементов выборки, интервалов гистограммы, интервалов аппроксимации

        double min, max, difference; // параметры для построения гистограммы,
        bool isGistogramm = false; // чать характеристик считается не по выборке, а по гистограмме, нужен флаг ее наличия
        Microsoft.Office.Interop.Excel.Application _ex = new Microsoft.Office.Interop.Excel.Application();

        // Путь к файлу (измените на свой)
        string filePath = "C:\\Users\\user\\source\\repos\\WindowsFormsTrvr\\WindowsFormsTrvr\\report.txt";

        public Form1()
        {
            InitializeComponent();
        }

        // Очистка  всех полей информации при создании новой выборки
        private void Clear_All_Info()
        {
            info.Text = "---";
            info_gist.Text = "---";
            
            chiVal1.Text = "---";
            chiVal2.Text = "---";
            KV1.Text = "---";
            KV2.Text = "---";
            KV3.Text = "---";
            KV4.Text = "---";
            K1.Text = "---";
            K2.Text = "---";
            K3.Text = "---";
            K4.Text = "---";


            rec.Text = "---";
            label9.Text = "---";
            label10.Text = "---";
            label11.Text = "---";
            label12.Text = "---";
            label14.Text = "---";
            label15.Text = "---";

            LK1.Text = "---";
            RK1.Text = "---";
            S1.Text = "---";
            C1.Text = "---";
            LK2.Text = "---";
            RK2.Text = "---";
            S2.Text = "---";
            C2.Text = "---";
            LK3.Text = "---";
            RK3.Text = "---";
            S3.Text = "---";
            C3.Text = "---";
            LK4.Text = "---";
            RK4.Text = "---";
            S4.Text = "---";
            C4.Text = "---";
            LK5.Text = "---";
            RK5.Text = "---";
            S5.Text = "---";
            C5.Text = "---";
            LK6.Text = "---";
            RK6.Text = "---";
            S6.Text = "---";
            C6.Text = "---";
            LK7.Text = "---";
            RK7.Text = "---";
            S7.Text = "---";
            C7.Text = "---";
            LK8.Text = "---";
            RK8.Text = "---";
            S8.Text = "---";
            C8.Text = "---";
        }

        // создание выборки
        private void Button1_Click(object sender, EventArgs e)
        {
            N = int.Parse(textBox1.Text);

            // проверка объема распределения
            if (N <= 0)
            {
                MessageBox.Show("Введите корректный объем выборки!");
                return;
            }

            // проверка вида распределения
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите тип распределения!");
                return;
            }

            // очистка от информации прошлой выборки
            Clear_All_Info();
            chart1.Series[0].Points.Clear();
            isGistogramm = false;

            // создание переменных
            Random r = new Random();
            array = new double[N];

            // рекомендуемое количество интервалов гистограммы
            rec.Text = Math.Floor(1 + Math.Log((double)N, 2f)).ToString();

            // равномерное распределение
            if (checkedListBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.NextDouble();
                }

                info.Text = $"Равномерное распределение на (0; 1).\n";
            }

            // нормальное распределение + доверительные интервалы характеристик
            if (checkedListBox1.SelectedIndex == 1)
            {
                double alpha15 = 0.15;
                double alpha05 = 0.05;

                // Получаем параметры распределения из TextBox
                double mu_setted = double.Parse(textBox4.Text);                  // Мат. ожидание
                double sigma_setted = Math.Abs(double.Parse(textBox5.Text));    // Среднеквадратичное отклонение
                double dispersia_setted = Math.Pow(sigma_setted, 2);           // Дисперсия

                double srednee = 0, kvadr_otklon = 0, dispersia = 0; // выборочное среднее, квадратное отклонение, выборочная дисперсия

                double margine; // эпсилон для доверительного интервала
                double left_krit, right_krit; // границы доверительного интервала

                info.Text = $"Нормальное распределение: мат.ожидание {mu_setted}, среднеквадратичное отклонение {sigma_setted}.\n";

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
                    srednee += array[i]; // сумма всех элементов выборки
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
                C1.Text = (left_krit <= mu_setted && mu_setted <= right_krit) ? "Да" : "Нет";

                // 0.05, матожидание, известная дисперсия
                margine = _ex.WorksheetFunction.Norm_S_Inv(1 - alpha05 / 2) * sigma_setted / Math.Sqrt(N);
                left_krit = srednee -  margine;
                right_krit = srednee + margine;
                LK2.Text = left_krit.ToString("F4");
                RK2.Text = right_krit.ToString("F4");
                S2.Text = mu_setted.ToString("F4");
                C2.Text = (left_krit <= mu_setted && mu_setted <= right_krit) ? "Да" : "Нет";

                // 0.15, матожидание, неизвестная дисперсия
                margine = _ex.WorksheetFunction.T_Inv_2T(alpha15, N - 1) * Math.Sqrt(dispersia / (double)N);
                left_krit = srednee - margine;
                right_krit = srednee + margine;
                LK3.Text = left_krit.ToString("F4");
                RK3.Text = right_krit.ToString("F4");
                S3.Text = mu_setted.ToString("F4");
                C3.Text = (left_krit <= mu_setted && mu_setted <= right_krit) ? "Да" : "Нет";

                // 0.05, матожидание, неизвестная дисперсия
                margine = _ex.WorksheetFunction.T_Inv_2T(alpha05, N - 1) * Math.Sqrt(dispersia / (double)N);
                left_krit = srednee - margine;
                right_krit = srednee + margine;
                LK4.Text = left_krit.ToString("F4");
                RK4.Text = right_krit.ToString("F4");
                S4.Text = mu_setted.ToString("F4");
                C4.Text = (left_krit <= mu_setted && mu_setted <= right_krit) ? "Да" : "Нет";

                // 0.15, дисперсия, известное мат ожидание
                right_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(1 - alpha15 / 2, N);
                left_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(alpha15 / 2, N);
                LK5.Text = left_krit.ToString("F4");
                RK5.Text = right_krit.ToString("F4");
                S5.Text = dispersia_setted.ToString("F4");
                C5.Text = (left_krit <= dispersia_setted && dispersia_setted <= right_krit) ? "Да" : "Нет";

                // 0.05, дисперсия, известное мат ожидание
                right_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(1 - alpha05 / 2, N);
                left_krit = kvadr_otklon / _ex.WorksheetFunction.ChiInv(alpha05 / 2, N);
                LK6.Text = left_krit.ToString("F4");
                RK6.Text = right_krit.ToString("F4");
                S6.Text = dispersia_setted.ToString("F4");
                C6.Text = (left_krit <= dispersia_setted && dispersia_setted <= right_krit) ? "Да" : "Нет";

                // 0.15, дисперсия, неизвестное мат ожидание
                right_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(1 - alpha15 / 2, N - 1);
                left_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(alpha15 / 2, N - 1);
                LK7.Text = left_krit.ToString("F4");
                RK7.Text = right_krit.ToString("F4");
                S7.Text = dispersia_setted.ToString("F4");
                C7.Text = (left_krit <= dispersia_setted && dispersia_setted <= right_krit) ? "Да" : "Нет";

                // 0.05, дисперсия, неизвестное мат ожидание
                right_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(1 - alpha05 / 2, N - 1);
                left_krit = (N - 1) * dispersia / _ex.WorksheetFunction.ChiInv(alpha05 / 2, N - 1);
                LK8.Text = left_krit.ToString("F4");
                RK8.Text = right_krit.ToString("F4");
                S8.Text = dispersia_setted.ToString("F4");
                C8.Text = (left_krit <= dispersia_setted && dispersia_setted <= right_krit) ? "Да" : "Нет";

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
                            writer.Write("  ");
                        }
                    }

                    writer.WriteLine("\n=== КОНЕЦ ОТЧЁТА ===");
                }
            }

            // заданное распределение (0.5х) + хи квадрат (неправильное, для анализа точности ступенчатой аппроксимации)
            if (checkedListBox1.SelectedIndex == 2)
            {
                M = int.Parse(textBox2.Text); // кол-во интервалов

                // проверка кол-ва интервалов
                if (M <= 0)
                {
                    MessageBox.Show("Введите корректное количество интервалов апроксимации!");
                    return;
                }

                info.Text = $"Распределение f(x) = 0.5x (0; 2). Кол-во интервалов аппроксимации {M}\n";

                double[] borders_array = new double[M]; // правые границы интервалов аппроксимации
                double[] freq_array = new double[M]; // наблюдаемые частоты (количество попаданий в интервалы аппроксимации)

                // 1. Расчёт границ интервалов (равновероятных)
                double theor_prob = 1.0 / M; // теоретическая вероятность для каждого интервала
                double pos_x = theor_prob; // начальный квантиль функции распределения

                for (int i = 0; i < M; i++)
                {
                    borders_array[i] = 2 * Math.Sqrt(pos_x); // получение правой границы интервала аппроксимации 
                    pos_x += theor_prob; // получение следующего квантиля
                    freq_array[i] = 0; // зануление массива наблюдаемых частот (для последующей работы)
                }

                // 2. Генерация выборки и подсчёт частот
                for (int i = 0; i < N; i++)
                {
                    int interval = r.Next(0, M); // случайный интервал
                    double local_left = (interval > 0) ? borders_array[interval - 1] : 0;
                    double local_right = borders_array[interval];

                    double c = r.NextDouble() * (local_right - local_left) + local_left;
                    array[i] = c; // получение элемента
                    freq_array[interval]++; // подсчет частот
                }

                // 3. Расчёт χ²-статистики (неправильная, для анализа точности ступенчатой аппроксимации)
                double kriteri_pirsona = 0, krit_value_pirsona, alpha05 = 0.05, alpha01 = 0.01;
                double expected_freq = N * theor_prob; // теоретическая частота для каждого интервала

                for (int i = 0; i < M; i++)
                {
                    kriteri_pirsona += Math.Pow(freq_array[i] - expected_freq, 2) / expected_freq;
                }

                chiVal1.Text = kriteri_pirsona.ToString("F4"); // вывод с 4 знаками после запятой

                krit_value_pirsona = _ex.WorksheetFunction.ChiInv(alpha05, M - 1);
                KV1.Text = krit_value_pirsona.ToString("F4");
                if (kriteri_pirsona <= krit_value_pirsona) K1.Text = "Да";
                else K1.Text = "Нет";

                krit_value_pirsona = _ex.WorksheetFunction.ChiInv(alpha01, M - 1);
                KV2.Text = krit_value_pirsona.ToString("F4");
                if (kriteri_pirsona <= krit_value_pirsona) K2.Text = "Да";
                else K2.Text = "Нет";
            }

        }

        // создание гистограммы
        private void Button2_Click(object sender, EventArgs e)
        {
            K = int.Parse(textBox3.Text);
            if (K <= 0)
            {
                MessageBox.Show("Введите корректное количество интервалов гистограммы!");
                return;
            }

            info_gist.Text = $"Кол-во интервалов гистограммы: {K}";

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
                right = (isLastInterval ? max : right + difference);
            }

            // Хи квадрат, если отображается 0,5х (корректная, для анализа точности аппроксимации функции 0,5х)
            if (checkedListBox1.SelectedIndex == 2)
            {
                double kriteri_pirsona = 0, krit_value_pirsona, alpha05 = 0.05, alpha01 = 0.01;


                for (int i = 0; i < K; i++)
                {
                    kriteri_pirsona += Math.Pow(intervals[i] - expected_freq[i], 2) / expected_freq[i];
                }

                chiVal2.Text = kriteri_pirsona.ToString("F4");

                krit_value_pirsona = _ex.WorksheetFunction.ChiInv(alpha05, K - 1);
                KV3.Text = krit_value_pirsona.ToString("F4");
                if (kriteri_pirsona <= krit_value_pirsona) K3.Text = "Да";
                else K3.Text = "Нет";

                krit_value_pirsona = _ex.WorksheetFunction.ChiInv(alpha01, K - 1);
                KV4.Text = krit_value_pirsona.ToString("F4");
                if (kriteri_pirsona <= krit_value_pirsona) K4.Text = "Да";
                else K4.Text = "Нет";
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

        // удобство интерфейса
        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != checkedListBox1.SelectedIndex)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                else
                {
                    checkedListBox1.SetItemChecked(i, true);
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
    }
}
