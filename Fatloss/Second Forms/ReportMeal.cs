using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatloss.Second_Forms
{
    public partial class ReportMeal : Form
    {
        public ReportMeal()
        {
            InitializeComponent();
        }
        private void ReportMeal_Load(object sender, EventArgs e)
        {
            dataGridViewMeals.DataSource = null;
            dataGridViewMeals.Rows.Clear();
            dataGridViewMeals.Columns.Clear();
            DataTable dataTableSearchMeal = new DataTable();
            dataTableSearchMeal.Columns.Add("Id", typeof(int));
            dataTableSearchMeal.Columns.Add("Название", typeof(string));
            dataTableSearchMeal.Columns.Add("Дата", typeof(DateTime));
            dataTableSearchMeal.Columns.Add("Всего калорий", typeof(double));
            for (int i = 0; i < Data.mealData.Count; i++)
            {
                dataTableSearchMeal.Rows.Add(Data.mealData[i].Id, Data.mealData[i].Name, Data.mealData[i].MealDate, Data.mealData[i].TotalCaloriesPerMeal);
            }
            dataGridViewMeals.DataSource = dataTableSearchMeal;
            dataGridViewMeals.Columns[0].Visible = false;
        }
        private void dataGridViewMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List <int> idMealsProduct = new List<int>();
            List<int> idMealsDish = new List<int>();
            if (dataGridViewMeals.SelectedCells.Count > 1)
            {
                MessageBox.Show("Выберите только 1 приём пищи", "Внимание");
            }
            else
            {
                for (int i = 0; i < Data.mealProductData.Count; i++)
                {
                    if (Data.mealProductData[i].IdMeal == Convert.ToInt32(dataGridViewMeals[0, dataGridViewMeals.SelectedCells[0].RowIndex].Value))
                    {
                        idMealsProduct.Add(Data.mealProductData[i].IdProduct);
                    }
                }
                for (int i = 0; i < Data.mealDishData.Count; i++)
                {
                    if (Data.mealDishData[i].IdMeal == Convert.ToInt32(dataGridViewMeals[0, dataGridViewMeals.SelectedCells[0].RowIndex].Value))
                    {
                        idMealsProduct.Add(Data.mealDishData[i].IdDish);
                    }
                }

                DataTable dataTableSearchProductAndDish = new DataTable();
                dataTableSearchProductAndDish.Columns.Add("Название", typeof(string));
                dataTableSearchProductAndDish.Columns.Add("Калории", typeof(double));
                dataTableSearchProductAndDish.Columns.Add("Белок", typeof(double));
                dataTableSearchProductAndDish.Columns.Add("Жиры", typeof(double));
                dataTableSearchProductAndDish.Columns.Add("Углеводы", typeof(double));
                for (int i = 0; i < idMealsProduct.Count; i++)
                {
                    dataTableSearchProductAndDish.Rows.Add(Data.productData[idMealsProduct[i]].Name, Data.productData[idMealsProduct[i]].Kcal, Data.productData[idMealsProduct[i]].Protein, Data.productData[idMealsProduct[i]].Fats, Data.productData[idMealsProduct[i]].Carbohydrates);
                }
                for (int i = 0; i < idMealsDish.Count; i++)
                {
                    dataTableSearchProductAndDish.Rows.Add(Data.dishData[idMealsDish[i]].Name, Data.dishData[idMealsDish[i]].Kcal, Data.dishData[idMealsDish[i]].Protein, Data.dishData[idMealsDish[i]].Fats, Data.dishData[idMealsDish[i]].Carbohydrates);
                }
                dataGridViewProductAndDish.DataSource = dataTableSearchProductAndDish;
            }
        }
    }
}
