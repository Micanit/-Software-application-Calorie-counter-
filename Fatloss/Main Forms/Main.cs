using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fatloss
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            #region Перенос данных c БД в объекты
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|FatlossLocalD" +
            "B.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConnection.Open();

            SqlCommand commandReadTableDish = new SqlCommand("SELECT * FROM Dish", sqlConnection);
            SqlDataReader reader2 = commandReadTableDish.ExecuteReader();
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {

                    Data.dishData.Add(new Dish()
                    {
                        Id = Convert.ToInt32(reader2.GetValue(0)),
                        Name = Convert.ToString(reader2.GetValue(1)),
                        Kcal = Convert.ToDouble(reader2.GetValue(2)),
                        Protein = Convert.ToDouble(reader2.GetValue(3)),
                        Fats = Convert.ToDouble(reader2.GetValue(4)),
                        Carbohydrates = Convert.ToDouble(reader2.GetValue(5)),
                        IdUser = Convert.ToInt32(reader2.GetValue(6))
                    });
                }
            }
            reader2.Close();

            SqlCommand commandReadTableDishProduct = new SqlCommand("SELECT * FROM Dish_Product", sqlConnection);
            SqlDataReader reader3 = commandReadTableDishProduct.ExecuteReader();
            if (reader3.HasRows)
            {
                while (reader3.Read())
                {

                    Data.dishProductData.Add(new DishProduct()
                    {
                        Id = Convert.ToInt32(reader3.GetValue(0)),
                        IdDish = Convert.ToInt32(reader3.GetValue(1)),
                        IdProduct = Convert.ToInt32(reader3.GetValue(2)),
                    });
                }
            }
            reader3.Close();

            SqlCommand commandReadTableMeal = new SqlCommand("SELECT * FROM Meal", sqlConnection);
            SqlDataReader reader4 = commandReadTableMeal.ExecuteReader();
            if (reader4.HasRows)
            {
                while (reader4.Read())
                {

                    Data.mealData.Add(new Meal()
                    {
                        Id = Convert.ToInt32(reader4.GetValue(0)),
                        Name = Convert.ToString(reader4.GetValue(1)),
                        MealDate = Convert.ToDateTime(reader4.GetValue(2)),
                        TotalCaloriesPerMeal = Convert.ToDouble(reader4.GetValue(3)),
                        IdUser = Convert.ToInt32(reader4.GetValue(4)),
                    });
                }
            }
            reader4.Close();

            SqlCommand commandReadTableMealDish = new SqlCommand("SELECT * FROM Meal_Dish", sqlConnection);
            SqlDataReader reader5 = commandReadTableMealDish.ExecuteReader();
            if (reader5.HasRows)
            {
                while (reader5.Read())
                {

                    Data.mealDishData.Add(new MealDish()
                    {
                        Id = Convert.ToInt32(reader5.GetValue(0)),
                        IdMeal = Convert.ToInt32(reader5.GetValue(1)),
                        IdDish = Convert.ToInt32(reader5.GetValue(2)),
                    });
                }
            }
            reader5.Close();

            SqlCommand commandReadTableProduct = new SqlCommand("SELECT * FROM Product", sqlConnection);
            SqlDataReader reader6 = commandReadTableProduct.ExecuteReader();
            if (reader6.HasRows)
            {
                while (reader6.Read())
                {

                    Data.productData.Add(new Product()
                    {
                        Id = Convert.ToInt32(reader6.GetValue(0)),
                        Name = Convert.ToString(reader6.GetValue(1)),
                        Unit = Convert.ToString(reader6.GetValue(2)),
                        Kcal = Convert.ToDouble(reader6.GetValue(3)),
                        Protein = Convert.ToDouble(reader6.GetValue(4)),
                        Fats = Convert.ToDouble(reader6.GetValue(5)),
                        Carbohydrates = Convert.ToDouble(reader6.GetValue(6)),
                        IsItAnAllergen = Convert.ToString(reader6.GetValue(7)),
                        IdUser = Convert.ToInt32(reader6.GetValue(8)),
                    });
                }
            }
            reader6.Close();

            SqlCommand commandReadTableMealProduct = new SqlCommand("SELECT * FROM Meal_Product", sqlConnection);
            SqlDataReader reader7 = commandReadTableMealProduct.ExecuteReader();
            if (reader7.HasRows)
            {
                while (reader7.Read())
                {

                    Data.mealProductData.Add(new MealProduct()
                    {
                        Id = Convert.ToInt32(reader7.GetValue(0)),
                        IdMeal = Convert.ToInt32(reader7.GetValue(1)),
                        IdProduct = Convert.ToInt32(reader7.GetValue(2)),
                    });
                }
            }
            reader7.Close();

            SqlCommand commandReadTableUser = new SqlCommand("SELECT * FROM \"User\"", sqlConnection);
            SqlDataReader reader8 = commandReadTableUser.ExecuteReader();
            if (reader8.HasRows)
            {
                while (reader8.Read())
                {
                    Data.userData.Add(new User()
                    {
                        Id = Convert.ToInt32(reader8.GetValue(0)),
                        Name = Convert.ToString(reader8.GetValue(1)),
                        StartWeight = Convert.ToInt32(reader8.GetValue(2)),
                        Height = Convert.ToInt32(reader8.GetValue(3)),
                        Age = Convert.ToInt32(reader8.GetValue(4)),
                        PhysicalActivityRate = Convert.ToString(reader8.GetValue(5)),
                        ManOrWoman = Convert.ToString(reader8.GetValue(6))
                    });
                }
            }
            reader8.Close();

            SqlCommand commandReadTableWeight = new SqlCommand("SELECT * FROM Weight", sqlConnection);
            SqlDataReader reader9 = commandReadTableWeight.ExecuteReader();
            if (reader9.HasRows)
            {
                while (reader9.Read())
                {

                    Data.weightData.Add(new Weight()
                    {
                        Id = Convert.ToInt32(reader9.GetValue(0)),
                        Weighing = Convert.ToInt32(reader9.GetValue(1)),
                        WeighingDate = Convert.ToDateTime(reader9.GetValue(2)),
                        IdUser = Convert.ToInt32(reader9.GetValue(3)),
                    });
                }
            }
            reader9.Close();
            sqlConnection.Close();
            #endregion
            #region Подсчёт и вывод всех параметров
            //Текущий вес
            labelWeightValue.Text = Data.weightData.Last().Weighing.ToString() + " кг";
            //Нужное кол-во каллорий
            if (Data.userData[0].ManOrWoman == "man")
            {
                labelKcalValue.Text = Math.Round(88.36 + (13.4 * Data.weightData.Last().Weighing) + (4.8 * Data.userData[0].Height) - (5.7 * Data.userData[0].Age) * Data.ratePhysicalActivity[Data.userData[0].PhysicalActivityRate]).ToString();
            }
            else if (Data.userData[0].ManOrWoman == "woman")
            {
                labelKcalValue.Text = Math.Round(447.6 + (9.2 * Data.weightData.Last().Weighing) + (3.1 * Data.userData[0].Height) - (4.3 * Data.userData[0].Age) * Data.ratePhysicalActivity[Data.userData[0].PhysicalActivityRate]).ToString();
            }
            //Создание графика
            chartMain.Series[0].Points.Clear();
            DateTime mondayCounter = DateTime.Now;
            while (mondayCounter.DayOfWeek.ToString() != "Monday")
            {
                mondayCounter = mondayCounter.AddDays(-1);
            }
            for (DateTime dateTimeCounter = mondayCounter; $"{dateTimeCounter:d}" != $"{DateTime.Now.AddDays(6):d}"; dateTimeCounter = dateTimeCounter.AddDays(1))
            {
                for (int i = 0; i < Data.weightData.Count; i++)
                {
                    if ($"{Data.weightData[i].WeighingDate:d}" == $"{dateTimeCounter:d}")
                    {
                        chartMain.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:dddd}", Data.weightData[i].Weighing);
                        break;
                    }

                    if (i == Data.weightData.Count - 1)
                    {
                        chartMain.Series[0].Points.AddXY($"{dateTimeCounter:m}", 0);
                        chartMain.Series[0].Points[chartMain.Series[0].Points.Count - 1].IsEmpty = true;
                    }
                }
            }
            #endregion
        }

        #region Переходы по разделам: Главная, Еда, Отчёт
        //Переход в раздел Еда
        private void toolStripFood_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.Owner = this;
            this.Hide();
            food.ShowDialog();
        }
        //Переход в раздел Настройки
        private void toolStripSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            this.Hide();
            settings.ShowDialog();
        }
        //Переход в раздел Отчёт
        private void toolStripReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Owner = this;
            this.Hide();
            report.ShowDialog();
        }
        #endregion
        #region Переход по доп. разделам: Создать приём пищи
        //Переход в раздел Создать приём пищи
        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            CreateMeal createMeal = new CreateMeal();
            createMeal.Owner = this;
            createMeal.ShowDialog();
        }
        #endregion
        private void Main_Activated(object sender, EventArgs e)
        {
            labelWeightChange.Text = "Изменение веса " + Data.WeightChanges;
            if (Data.WeightChanges == "День")
            {
                chartMain.Series[0].Points.Clear();
                for (int i = 0; i < Data.weightData.Count; i++)
                {
                    if ($"{Data.weightData[i].WeighingDate:d}" == $"{DateTime.Today:d}")
                    {
                        chartMain.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:t}", Data.weightData[i].Weighing);
                    }
                }
            }
            else if (Data.WeightChanges == "Неделя")
            {
                chartMain.Series[0].Points.Clear();
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
                            chartMain.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:dddd}", Data.weightData[i].Weighing);
                            break;
                        }

                        if (i == Data.weightData.Count - 1)
                        {
                            chartMain.Series[0].Points.AddXY($"{dateTimeCounter:dddd}", 0);
                            chartMain.Series[0].Points[chartMain.Series[0].Points.Count - 1].IsEmpty = true;
                        }
                    }
                }
            }
            else if (Data.WeightChanges == "Месяц")
            {
                chartMain.Series[0].Points.Clear();
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
                                chartMain.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:M}", Data.weightData[i].Weighing);
                                break;
                            }
                        }
                        if (i == Data.weightData.Count - 1)
                        {
                            chartMain.Series[0].Points.AddXY($"{dateTimeCounter:M}", 0);
                            chartMain.Series[0].Points[chartMain.Series[0].Points.Count - 1].IsEmpty = true;
                        }
                    }
                }
            }
            else if (Data.WeightChanges == "Год")
            {
                chartMain.Series[0].Points.Clear();
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
                                chartMain.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:MMM}", Math.Round(totalWeighing / counterWeighing));
                            }
                            else
                            {
                                chartMain.Series[0].Points.AddXY($"{dateTimeCounter:MMM}", 0);
                                chartMain.Series[0].Points[chartMain.Series[0].Points.Count - 1].IsEmpty = true;
                            }
                        }
                    }
                }
            }
            else if (Data.WeightChanges == "За всё время")
            {
                chartMain.Series[0].Points.Clear();
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
                                chartMain.Series[0].Points.AddXY($"{Data.weightData[i].WeighingDate:MMM}", Math.Round(totalWeighing / counterWeighing));
                            }
                            else
                            {
                                chartMain.Series[0].Points.AddXY($"{dateTimeCounter:MMM}", 0);
                                chartMain.Series[0].Points[chartMain.Series[0].Points.Count - 1].IsEmpty = true;
                            }
                        }
                    }
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            #region Перенос данных c объектов в БД
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|FatlossLocalD" +
            "B.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConnection.Open();

            SqlCommand commandReadTableDish = new SqlCommand("SELECT * FROM Dish", sqlConnection);
            SqlDataReader reader2 = commandReadTableDish.ExecuteReader();
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    Data.dishData.Add(new Dish()
                    {
                        Id = Convert.ToInt32(reader2.GetValue(0)),
                        Name = Convert.ToString(reader2.GetValue(1)),
                        Kcal = Convert.ToDouble(reader2.GetValue(2)),
                        Protein = Convert.ToDouble(reader2.GetValue(3)),
                        Fats = Convert.ToDouble(reader2.GetValue(4)),
                        Carbohydrates = Convert.ToDouble(reader2.GetValue(5)),
                        IdUser = Convert.ToInt32(reader2.GetValue(6))
                    });
                }
            }
            reader2.Close();

            SqlCommand commandReadTableDishProduct = new SqlCommand("SELECT * FROM Dish_Product", sqlConnection);
            SqlDataReader reader3 = commandReadTableDishProduct.ExecuteReader();
            if (reader3.HasRows)
            {
                while (reader3.Read())
                {
                    Data.dishProductData.Add(new DishProduct()
                    {
                        Id = Convert.ToInt32(reader3.GetValue(0)),
                        IdDish = Convert.ToInt32(reader3.GetValue(1)),
                        IdProduct = Convert.ToInt32(reader3.GetValue(2)),
                    });
                }
            }
            reader3.Close();

            SqlCommand commandReadTableMeal = new SqlCommand("SELECT * FROM Meal", sqlConnection);
            SqlDataReader reader4 = commandReadTableMeal.ExecuteReader();
            if (reader4.HasRows)
            {
                while (reader4.Read())
                {

                    Data.mealData.Add(new Meal()
                    {
                        Id = Convert.ToInt32(reader4.GetValue(0)),
                        Name = Convert.ToString(reader4.GetValue(1)),
                        MealDate = Convert.ToDateTime(reader4.GetValue(2)),
                        TotalCaloriesPerMeal = Convert.ToDouble(reader4.GetValue(3)),
                        IdUser = Convert.ToInt32(reader4.GetValue(4)),
                    });
                }
            }
            reader4.Close();

            SqlCommand commandReadTableMealDish = new SqlCommand("SELECT * FROM Meal_Dish", sqlConnection);
            SqlDataReader reader5 = commandReadTableMealDish.ExecuteReader();
            if (reader5.HasRows)
            {
                while (reader5.Read())
                {

                    Data.mealDishData.Add(new MealDish()
                    {
                        Id = Convert.ToInt32(reader5.GetValue(0)),
                        IdMeal = Convert.ToInt32(reader5.GetValue(1)),
                        IdDish = Convert.ToInt32(reader5.GetValue(2)),
                    });
                }
            }
            reader5.Close();

            SqlCommand commandReadTableProduct = new SqlCommand("SELECT * FROM Product", sqlConnection);
            SqlDataReader reader6 = commandReadTableProduct.ExecuteReader();
            if (reader6.HasRows)
            {
                while (reader6.Read())
                {

                    Data.productData.Add(new Product()
                    {
                        Id = Convert.ToInt32(reader6.GetValue(0)),
                        Name = Convert.ToString(reader6.GetValue(1)),
                        Unit = Convert.ToString(reader6.GetValue(2)),
                        Kcal = Convert.ToDouble(reader6.GetValue(3)),
                        Protein = Convert.ToDouble(reader6.GetValue(4)),
                        Fats = Convert.ToDouble(reader6.GetValue(5)),
                        Carbohydrates = Convert.ToDouble(reader6.GetValue(6)),
                        IsItAnAllergen = Convert.ToString(reader6.GetValue(7)),
                        IdUser = Convert.ToInt32(reader6.GetValue(8)),
                    });
                }
            }
            reader6.Close();

            SqlCommand commandReadTableMealProduct = new SqlCommand("SELECT * FROM Meal_Product", sqlConnection);
            SqlDataReader reader7 = commandReadTableMealProduct.ExecuteReader();
            if (reader7.HasRows)
            {
                while (reader7.Read())
                {

                    Data.mealProductData.Add(new MealProduct()
                    {
                        Id = Convert.ToInt32(reader7.GetValue(0)),
                        IdMeal = Convert.ToInt32(reader7.GetValue(1)),
                        IdProduct = Convert.ToInt32(reader7.GetValue(2)),
                    });
                }
            }
            reader7.Close();

            SqlCommand commandReadTableUser = new SqlCommand("SELECT * FROM \"User\"", sqlConnection);
            SqlDataReader reader8 = commandReadTableUser.ExecuteReader();
            if (reader8.HasRows)
            {
                while (reader8.Read())
                {
                    Data.userData.Add(new User()
                    {
                        Id = Convert.ToInt32(reader8.GetValue(0)),
                        Name = Convert.ToString(reader8.GetValue(1)),
                        StartWeight = Convert.ToInt32(reader8.GetValue(2)),
                        Height = Convert.ToInt32(reader8.GetValue(3)),
                        Age = Convert.ToInt32(reader8.GetValue(4)),
                        PhysicalActivityRate = Convert.ToString(reader8.GetValue(5)),
                        ManOrWoman = Convert.ToString(reader8.GetValue(6))
                    });
                }
            }
            reader8.Close();

            SqlCommand commandReadTableWeight = new SqlCommand("SELECT * FROM Weight", sqlConnection);
            SqlDataReader reader9 = commandReadTableWeight.ExecuteReader();
            if (reader9.HasRows)
            {
                while (reader9.Read())
                {

                    Data.weightData.Add(new Weight()
                    {
                        Id = Convert.ToInt32(reader9.GetValue(0)),
                        Weighing = Convert.ToInt32(reader9.GetValue(1)),
                        WeighingDate = Convert.ToDateTime(reader9.GetValue(2)),
                        IdUser = Convert.ToInt32(reader9.GetValue(3)),
                    });
                }
            }
            reader9.Close();
            sqlConnection.Close();
            #endregion*/
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
