using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatloss
{
    public partial class CreateMeal : Form
    {
        public CreateMeal()
        {
            InitializeComponent();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchEngineText = textBoxSearchEngine.Text;

            dataGridViewSearchProduct.DataSource = null;
            dataGridViewSearchProduct.Rows.Clear();
            dataGridViewSearchProduct.Columns.Clear();
            DataTable dataTableSearchEngine = new DataTable();
            dataTableSearchEngine.Columns.Add("Id", typeof(int));
            dataTableSearchEngine.Columns.Add("Название", typeof(string));
            dataTableSearchEngine.Columns.Add("Калории", typeof(double));
            dataTableSearchEngine.Columns.Add("Белок", typeof(double));
            dataTableSearchEngine.Columns.Add("Жиры", typeof(double));
            dataTableSearchEngine.Columns.Add("Углеводы", typeof(double));
            dataTableSearchEngine.Columns.Add("ПродуктИлиБлюдо", typeof(string));

            for (int i = 0; i < Data.productData.Count; i++)
            {
                if (searchEngineText.Length <= Data.productData[i].Name.Length)
                {
                    int resultCompareString = string.Compare(searchEngineText.ToLower(), Data.productData[i].Name.Substring(0, searchEngineText.Length).ToLower());
                    if (resultCompareString == 0)
                        dataTableSearchEngine.Rows.Add(Data.productData[i].Id, Data.productData[i].Name, Data.productData[i].Kcal, Data.productData[i].Protein, Data.productData[i].Fats, Data.productData[i].Carbohydrates, "Продукт");
                }
            }
            for (int i = 0; i < Data.dishData.Count; i++)
            {
                if (searchEngineText.Length <= Data.dishData[i].Name.Length)
                {
                    int resultCompareString = string.Compare(searchEngineText.ToLower(), Data.dishData[i].Name.Substring(0, searchEngineText.Length).ToLower());
                    if (resultCompareString == 0)
                        dataTableSearchEngine.Rows.Add(Data.dishData[i].Id, Data.dishData[i].Name, Data.dishData[i].Kcal, Data.dishData[i].Protein, Data.dishData[i].Fats, Data.dishData[i].Carbohydrates, "Блюдо");
                }
            }
            dataGridViewSearchProduct.DataSource = dataTableSearchEngine;
            dataGridViewSearchProduct.Columns[0].Visible = false;
            dataGridViewSearchProduct.Columns[6].Visible = false;
        }
        List<int> idSelectedProducts = new List<int>();
        List<int> idSelectedDish = new List<int>();
        private void buttonMovingProduct_Click(object sender, EventArgs e)
        {
            DataTable dataTableSearchEngine = new DataTable();
            dataTableSearchEngine.Columns.Add("Id", typeof(int));
            dataTableSearchEngine.Columns.Add("Название", typeof(string));
            dataTableSearchEngine.Columns.Add("Калории", typeof(double));
            dataTableSearchEngine.Columns.Add("Белок", typeof(double));
            dataTableSearchEngine.Columns.Add("Жиры", typeof(double));
            dataTableSearchEngine.Columns.Add("Углеводы", typeof(double));
            //Нужно докидывать продукты в уже готовые. а не создавать заново список.
            for (int i = 0; i < dataGridViewSearchProduct.SelectedCells.Count; i++)
            {
                dataTableSearchEngine.Rows.Add(dataGridViewSearchProduct[0, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value, dataGridViewSearchProduct[1, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value, dataGridViewSearchProduct[2, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value, dataGridViewSearchProduct[3, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value, dataGridViewSearchProduct[4, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value, dataGridViewSearchProduct[5, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value);
                if (dataGridViewSearchProduct[6, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value.ToString() == "Продукт")
                {
                    idSelectedProducts.Add(Convert.ToInt32(dataGridViewSearchProduct[0, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value));
                }
                else if(dataGridViewSearchProduct[6, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value.ToString() == "Блюдо")
                {
                    idSelectedDish.Add(Convert.ToInt32(dataGridViewSearchProduct[0, dataGridViewSearchProduct.SelectedCells[i].RowIndex].Value));
                }
            }
            dataGridViewSelectedProducts.DataSource = dataTableSearchEngine;
            dataGridViewSelectedProducts.Columns[0].Visible = false;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Data.mealData.Add(new Meal()
                {
                    Id = Data.mealData.Count + 1,
                    Name = comboBoxMealName.Text,
                    MealDate = dateTimePicker.Value,
                    TotalCaloriesPerMeal = Convert.ToDouble(textBoxTotalColories.Text),
                    IdUser = 1
                });
                if (Data.mealData[Data.mealData.Count + 1].Name.Length >= 30)
                {
                    throw new Exception ("Длина имени должна быть меньше 30");
                }
                if (Data.mealData[Data.mealData.Count + 1].TotalCaloriesPerMeal.ToString().Length >= 6)
                {
                    throw new Exception("Кол-во каллорий должно быть меньше 6 знаков");
                }
                for (int i = 0; i < idSelectedProducts.Count; i++)
                {
                    Data.mealProductData.Add(new MealProduct()
                    {
                        Id = Data.mealProductData.Count + 1,
                        IdMeal = Data.mealData.Count,
                        IdProduct = Convert.ToInt32(idSelectedProducts[i])
                    });
                }
                for (int i = 0; i < idSelectedDish.Count; i++)
                {
                    Data.mealDishData.Add(new MealDish()
                    {
                        Id = Data.mealDishData.Count + 1,
                        IdMeal = Data.mealData.Count,
                        IdDish = Convert.ToInt32(idSelectedDish[i])
                    });
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        }
    }
}
