using Fatloss.Second_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fatloss
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        //Переменные для отслеживания закрытия вкладки
        bool trackerExit = true;

        private void Report_Load(object sender, EventArgs e)
        {
            buttonWeight_Click(sender, e);
            buttonWeek_Click(sender, e);
        }
        #region Переходы по разделам: Главная, Еда, Настройки

        //Переход в раздел Главная
        private void toolStripMenu_Click(object sender, EventArgs e)
        {
            trackerExit = false;
            this.Close();
            Form openForm = Application.OpenForms[0];
            openForm.Show();
        }
        //Переход в раздел Еда
        private void toolStripFood_Click(object sender, EventArgs e)
        {
            trackerExit = false;
            Food food = new Food();
            food.Owner = this;
            this.Hide();
            food.ShowDialog();
        }
        //Переход в раздел Настройки
        private void toolStripSettings_Click(object sender, EventArgs e)
        {
            trackerExit = false;
            Settings settings = new Settings();
            settings.Owner = this;
            this.Hide();
            settings.ShowDialog();
        }
        #endregion
        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trackerExit == true)
            {
                Application.Exit();
            }
            /*
            //КОД С БАГОМ
            //Метод закрытия формы при нажатии красной кнопки Выход
            //Внимание данный код выполняется 2 раза, так что сохранение файлов лучше здесь не делать
            if (trackerExit == true)
            {
                counterRepeat++;
                if (counterRepeat == 1)
                {
                    DialogResult result = MessageBox.Show("Вы точно хотите закрыть приложение?", "Уведомление",
                    MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Report report = new Report();
                        report.Owner = this;
                        report.ShowDialog();
                    }
                }
            }
            */
        }
        #region Сортировка по категориям: Вес, Калории.
        //Клик на кнопку Вес
        private void buttonWeight_Click(object sender, EventArgs e)
        {
            buttonWeight.BackColor = Color.Silver;
            buttonKcal.BackColor = Color.Gainsboro;

            if (buttonDay.BackColor == Color.Silver) buttonDay_Click(sender, e);
            if (buttonWeek.BackColor == Color.Silver) buttonWeek_Click(sender, e);
            if (buttonMonth.BackColor == Color.Silver) buttonMonth_Click(sender, e);
            if (buttonYear.BackColor == Color.Silver) buttonYear_Click(sender, e);
            if (buttonAllTime.BackColor == Color.Silver) buttonAllTime_Click(sender, e);
        }
        //Клик на кнопку Калории
        private void buttonKcal_Click(object sender, EventArgs e)
        {
            buttonWeight.BackColor = Color.Gainsboro;
            buttonKcal.BackColor = Color.Silver;

            if (buttonDay.BackColor == Color.Silver) buttonDay_Click(sender, e);
            if (buttonWeek.BackColor == Color.Silver) buttonWeek_Click(sender, e);
            if (buttonMonth.BackColor == Color.Silver) buttonMonth_Click(sender, e);
            if (buttonYear.BackColor == Color.Silver) buttonYear_Click(sender, e);
            if (buttonAllTime.BackColor == Color.Silver) buttonAllTime_Click(sender, e);
        }
        #endregion
        //Нажатие на категорию Приём пищи
        private void buttonMeal_Click(object sender, EventArgs e)
        {

            ReportMeal reportMeal = new ReportMeal();
            reportMeal.Owner = this;
            reportMeal.ShowDialog();
        }

        #region Сортировка по дням: День, Неделя, Месяц, Год, Всё время.
        //Клик на кнопку День
        private void buttonDay_Click(object sender, EventArgs e)
        {
            buttonDay.BackColor = Color.Silver;
            buttonWeek.BackColor = Color.Gainsboro;
            buttonMonth.BackColor = Color.Gainsboro;
            buttonYear.BackColor = Color.Gainsboro;
            buttonAllTime.BackColor = Color.Gainsboro;
            chart.Series[0].Points.Clear();

            if (buttonWeight.BackColor == Color.Silver)
            {
                for (int i = 0; i < Data.weightData.Count; i++)
                {
                    if ($"{Data.weightData[i].WeighingDate:d}" == $"{DateTime.Today:d}")
                    {
                        chart.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:t}", Data.weightData[i].Weighing);
                    }
                }
            }
            else if (buttonKcal.BackColor == Color.Silver)
            {
                for (int i = 0; i < Data.mealData.Count; i++)
                {
                    if ($"{Data.mealData[i].MealDate:d}" == $"{DateTime.Today:d}")
                    {
                        chart.Series[0].Points.AddXY($"{Data.mealData[i].MealDate:t}", Data.mealData[i].TotalCaloriesPerMeal);
                    }
                }
            }
        }
        //Клик на кнопку Неделя
        private void buttonWeek_Click(object sender, EventArgs e)
        {
            buttonDay.BackColor = Color.Gainsboro;
            buttonWeek.BackColor = Color.Silver;
            buttonMonth.BackColor = Color.Gainsboro;
            buttonYear.BackColor = Color.Gainsboro;
            buttonAllTime.BackColor = Color.Gainsboro;
            chart.Series[0].Points.Clear();

            if (buttonWeight.BackColor == Color.Silver)
            {
                DateTime mondayCounter = DateTime.Now;
                while (mondayCounter.DayOfWeek.ToString() != "Monday")
                {
                    mondayCounter = mondayCounter.AddDays(-1);
                }
                for (DateTime dateTimeCounter = mondayCounter; $"{dateTimeCounter:d}" != $"{mondayCounter.AddDays(7):d}"; dateTimeCounter = dateTimeCounter.AddDays(1))
                {
                    for (int i = 0; i < Data.weightData.Count; i++)
                    {
                        if ($"{Data.weightData[i].WeighingDate:d}" == $"{dateTimeCounter:d}")
                        {
                            chart.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:dddd}", Data.weightData[i].Weighing);
                            break;
                        }

                        if (i == Data.weightData.Count - 1)
                        {
                            chart.Series[0].Points.AddXY($"{dateTimeCounter:dddd}", 0);
                            chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                        }
                    }
                }
            }
            else if (buttonKcal.BackColor == Color.Silver)
            {
                DateTime mondayCounter = DateTime.Now;
                while (mondayCounter.DayOfWeek.ToString() != "Monday")
                {
                    mondayCounter = mondayCounter.AddDays(-1);
                }
                for (DateTime dateTimeCounter = mondayCounter; $"{dateTimeCounter:d}" != $"{mondayCounter.AddDays(7):d}"; dateTimeCounter = dateTimeCounter.AddDays(1))
                {
                    for (int i = 0; i < Data.mealData.Count; i++)
                    {
                        if ($"{Data.mealData[i].MealDate:d}" == $"{dateTimeCounter:d}")
                        {
                            double totalCalories = Data.mealData[i].TotalCaloriesPerMeal;
                            for (int k = i + 1; k < Data.mealData.Count; k++)
                            {
                                if ($"{Data.mealData[i].MealDate:d}" == $"{Data.mealData[k].MealDate:d}")
                                {
                                    totalCalories += Data.mealData[k].TotalCaloriesPerMeal;
                                }
                            }
                            chart.Series[0].Points.AddXY($"{Data.mealData[i].MealDate:dddd}", totalCalories);
                            break;
                        }

                        if (i == Data.mealData.Count - 1)
                        {
                            chart.Series[0].Points.AddXY($"{dateTimeCounter:dddd}", 0);
                            chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                        }
                    }
                }
            }
        }
        //Клик на кнопку Месяц
        private void buttonMonth_Click(object sender, EventArgs e)
        {
            buttonDay.BackColor = Color.Gainsboro;
            buttonWeek.BackColor = Color.Gainsboro;
            buttonMonth.BackColor = Color.Silver;
            buttonYear.BackColor = Color.Gainsboro;
            buttonAllTime.BackColor = Color.Gainsboro;
            chart.Series[0].Points.Clear();

            if (buttonWeight.BackColor == Color.Silver)
            {
                DateTime firstDayCounter = DateTime.Now;
                while (firstDayCounter.Day.ToString() != "1")
                {
                    firstDayCounter = firstDayCounter.AddDays(-1);
                }
                int counter = 0;
                for (DateTime dateTimeCounter = firstDayCounter; $"{dateTimeCounter:d}" != $"{firstDayCounter.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)):d}"; dateTimeCounter = dateTimeCounter.AddDays(1))
                {
                    for (int i = 0; i < Data.weightData.Count; i++)
                    {
                        if ($"{Data.weightData[i].WeighingDate:d}" == $"{dateTimeCounter:d}")
                        {
                            counter++;
                            if (counter == 3)
                            {
                                counter = 0;
                                chart.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:M}", Data.weightData[i].Weighing);
                                break;
                            }
                        }
                        if (i == Data.weightData.Count - 1)
                        {
                            chart.Series[0].Points.AddXY($"{dateTimeCounter:M}", 0);
                            chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                        }
                    }
                }
            }
            else if (buttonKcal.BackColor == Color.Silver)
            {
                DateTime firstDayCounter = DateTime.Now;
                while (firstDayCounter.Day.ToString() != "1")
                {
                    firstDayCounter = firstDayCounter.AddDays(-1);
                }
                int counter = 0;
                for (DateTime dateTimeCounter = firstDayCounter; $"{dateTimeCounter:d}" != $"{firstDayCounter.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)):d}"; dateTimeCounter = dateTimeCounter.AddDays(1))
                {
                    for (int i = 0; i < Data.mealData.Count; i++)
                    {
                        if ($"{Data.mealData[i].MealDate:d}" == $"{dateTimeCounter:d}")
                        {
                            counter++;
                            double totalCalories = Data.mealData[i].TotalCaloriesPerMeal;
                            for (int k = i + 1; k < Data.mealData.Count; k++)
                            {
                                if ($"{Data.mealData[i].MealDate:d}" == $"{Data.mealData[k].MealDate:d}")
                                {
                                    totalCalories += Data.mealData[k].TotalCaloriesPerMeal;
                                }
                            }
                            if (counter == 3)
                            {
                                counter = 0;
                                chart.Series[0].Points.AddXY($"{Data.mealData[i].MealDate:m}", totalCalories);
                                break;
                            }
                        }
                        if (i == Data.mealData.Count - 1)
                        {
                            chart.Series[0].Points.AddXY($"{dateTimeCounter:m}", 0);
                            chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                        }
                    }
                }
            }
        }
        //Клик на кнопку Год
        private void buttonYear_Click(object sender, EventArgs e)
        {
            buttonDay.BackColor = Color.Gainsboro;
            buttonWeek.BackColor = Color.Gainsboro;
            buttonMonth.BackColor = Color.Gainsboro;
            buttonYear.BackColor = Color.Silver;
            buttonAllTime.BackColor = Color.Gainsboro;
            chart.Series[0].Points.Clear();

            if (buttonWeight.BackColor == Color.Silver)
            {
                DateTime firstDayCounter = DateTime.Now;
                while (firstDayCounter.DayOfYear.ToString() != "1")
                {
                    firstDayCounter = firstDayCounter.AddDays(-1);
                }
                for (DateTime dateTimeCounter = firstDayCounter; $"{dateTimeCounter:MM.yyyy}" != $"{firstDayCounter.AddMonths(12):MM.yyyy}"; dateTimeCounter = dateTimeCounter.AddMonths(1))
                {
                    int counterWeighing = 0;
                    double totalWeighing = 0;
                    for (int i = 0; i < Data.weightData.Count; i++)
                    {
                        if (Data.weightData[i].WeighingDate.Month == dateTimeCounter.Month)
                        {
                            counterWeighing++;
                            totalWeighing = Data.weightData[i].Weighing + totalWeighing;
                        }
                        if (i == Data.weightData.Count - 1)
                        {
                            if (totalWeighing != 0)
                            {
                                chart.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:MMM}", Math.Round(totalWeighing / counterWeighing));
                            }
                            else
                            {
                                chart.Series[0].Points.AddXY($"{dateTimeCounter:MMM}", 0);
                                chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                            }
                        }
                    }
                }
            }
            else if (buttonKcal.BackColor == Color.Silver)
            {
                DateTime firstDayCounter = DateTime.Now;
                while (firstDayCounter.DayOfYear.ToString() != "1")
                {
                    firstDayCounter = firstDayCounter.AddDays(-1);
                }
                for (DateTime dateTimeCounter = firstDayCounter; $"{dateTimeCounter:MM.yyyy}" != $"{firstDayCounter.AddMonths(12):MM.yyyy}"; dateTimeCounter = dateTimeCounter.AddMonths(1))
                {
                    int counterCalories = 0;
                    double totalCalories = 0;
                    for (int i = 0; i < Data.mealData.Count; i++)
                    {
                        if (Data.mealData[i].MealDate.Month == dateTimeCounter.Month)
                        {
                            counterCalories++;
                            totalCalories = Data.mealData[i].TotalCaloriesPerMeal + totalCalories;
                        }
                        if (i == Data.mealData.Count - 1)
                        {
                            if (totalCalories != 0)
                            {
                                chart.Series[0].Points.AddXY($"{Data.mealData[i].MealDate:MMM}", Math.Round(totalCalories / counterCalories));
                            }
                            else
                            {
                                chart.Series[0].Points.AddXY($"{dateTimeCounter:MMM}", 0);
                                chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                            }
                        }
                    }
                }
            }
        }
        //Клик на кнопку За всё время
        private void buttonAllTime_Click(object sender, EventArgs e)
        {
            buttonDay.BackColor = Color.Gainsboro;
            buttonWeek.BackColor = Color.Gainsboro;
            buttonMonth.BackColor = Color.Gainsboro;
            buttonYear.BackColor = Color.Gainsboro;
            buttonAllTime.BackColor = Color.Silver;
            chart.Series[0].Points.Clear();

            if (buttonWeight.BackColor == Color.Silver)
            {
                DateTime firstDayCounter = DateTime.Now;
                while (firstDayCounter.DayOfYear.ToString() != "1")
                {
                    firstDayCounter = firstDayCounter.AddDays(-1);
                }
                for (DateTime dateTimeCounter = firstDayCounter; $"{dateTimeCounter:MM.yyyy}" != $"{firstDayCounter.AddMonths(12):MM.yyyy}"; dateTimeCounter = dateTimeCounter.AddMonths(1))
                {
                    int counterWeighing = 0;
                    double totalWeighing = 0;
                    for (int i = 0; i < Data.weightData.Count; i++)
                    {
                        if (Data.weightData[i].WeighingDate.Month == dateTimeCounter.Month)
                        {
                            counterWeighing++;
                            totalWeighing = Data.weightData[i].Weighing + totalWeighing;
                        }
                        if (i == Data.weightData.Count - 1)
                        {
                            if (totalWeighing != 0)
                            {
                                chart.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:MMM}", Math.Round(totalWeighing / counterWeighing));
                            }
                            else
                            {
                                chart.Series[0].Points.AddXY($"{dateTimeCounter:MMM}", 0);
                                chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                            }
                        }
                    }
                }
            }
            else if (buttonKcal.BackColor == Color.Silver)
            {
                DateTime firstDayCounter = DateTime.Now;
                while (firstDayCounter.DayOfYear.ToString() != "1")
                {
                    firstDayCounter = firstDayCounter.AddDays(-1);
                }
                for (DateTime dateTimeCounter = firstDayCounter; $"{dateTimeCounter:MM.yyyy}" != $"{firstDayCounter.AddMonths(12):MM.yyyy}"; dateTimeCounter = dateTimeCounter.AddMonths(1))
                {
                    int counterCalories = 0;
                    double totalCalories = 0;
                    for (int i = 0; i < Data.mealData.Count; i++)
                    {
                        if (Data.mealData[i].MealDate.Month == dateTimeCounter.Month)
                        {
                            counterCalories++;
                            totalCalories = Data.mealData[i].TotalCaloriesPerMeal + totalCalories;
                        }
                        if (i == Data.mealData.Count - 1)
                        {
                            if (totalCalories != 0)
                            {
                                chart.Series[0].Points.AddXY($"{Data.mealData[i].MealDate:MMM}", Math.Round(totalCalories / counterCalories));
                            }
                            else
                            {
                                chart.Series[0].Points.AddXY($"{dateTimeCounter:MMM}", 0);
                                chart.Series[0].Points[chart.Series[0].Points.Count - 1].IsEmpty = true;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        private void tableLayoutPanelChart_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
