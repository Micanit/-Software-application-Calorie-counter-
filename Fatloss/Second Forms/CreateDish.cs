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
    public partial class CreateDish : Form
    {
        public CreateDish()
        {
            InitializeComponent();
        }
        private void CreateDish_Load(object sender, EventArgs e)
        {
            if (Data.clickThroughButtonChangedFood == true)
            {
                this.Text = "Измененить блюдо";
                textBoxNameDish.Text = Data.dishData[Data.idChangedFood - 1].Name;
                textBoxAmountKcal.Text = Data.dishData[Data.idChangedFood - 1].Kcal.ToString();
                textBoxAmountProtein.Text = Data.dishData[Data.idChangedFood - 1].Protein.ToString();
                textBoxAmountFats.Text = Data.dishData[Data.idChangedFood - 1].Fats.ToString();
                textBoxAmountCarbohydrates.Text = Data.dishData[Data.idChangedFood - 1].Carbohydrates.ToString();

                DataTable dataTableSearchEngine = new DataTable();
                dataTableSearchEngine.Columns.Add("Id", typeof(int));
                dataTableSearchEngine.Columns.Add("Название", typeof(string));
                dataTableSearchEngine.Columns.Add("Калории", typeof(double));
                dataTableSearchEngine.Columns.Add("Белок", typeof(double));
                dataTableSearchEngine.Columns.Add("Жиры", typeof(double));
                dataTableSearchEngine.Columns.Add("Углеводы", typeof(double));
                for (int i = 0; i < Data.dishProductData.Count; i++)
                {
                    if (Data.dishProductData[i].IdDish == Data.idChangedFood)
                    {
                        dataTableSearchEngine.Rows.Add(Data.productData[Data.dishProductData[i].IdProduct - 1].Id, Data.productData[Data.dishProductData[i].IdProduct - 1].Name, Data.productData[Data.dishProductData[i].IdProduct - 1].Kcal, Data.productData[Data.dishProductData[i].IdProduct - 1].Protein, Data.productData[Data.dishProductData[i].IdProduct - 1].Fats, Data.productData[Data.dishProductData[i].IdProduct - 1].Carbohydrates);
                    }
                }
                dataGridViewSelectedProducts.DataSource = dataTableSearchEngine;
                dataGridViewSelectedProducts.Columns[0].Visible = false;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data.clickThroughButtonChangedFood == true)
                {
                    Data.dishData.RemoveAt(Data.idChangedFood - 1);
                    Data.dishData.Insert(Data.idChangedFood - 1, new Dish()
                    {
                        Id = Convert.ToInt32(Data.idChangedFood),
                        Name = Convert.ToString(textBoxNameDish.Text),
                        Kcal = Convert.ToDouble(textBoxAmountKcal.Text),
                        Protein = Convert.ToDouble(textBoxAmountProtein.Text),
                        Fats = Convert.ToDouble(textBoxAmountFats.Text),
                        Carbohydrates = Convert.ToDouble(textBoxAmountCarbohydrates.Text),
                        IdUser = Convert.ToInt32(1)
                    });
                    for (int i = 0; i < Data.dishProductData.Count; i++)
                    {
                        if (Data.dishProductData[i].IdDish == Data.idChangedFood)
                        {
                            Data.dishProductData.RemoveAt(i);
                            i = -1;
                        }
                    }
                    for (int i = 0; i < dataGridViewSelectedProducts.Rows.Count - 1; i++)
                    {
                        Data.dishProductData.Add(new DishProduct()
                        {
                            Id = Data.dishProductData.Count + 1,
                            IdDish = Data.idChangedFood,
                            IdProduct = Convert.ToInt32(dataGridViewSelectedProducts[0, i].Value)
                        });
                    }
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите все данные корректно", "Внимание");
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
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

            for (int i = 0; i < Data.productData.Count; i++)
            {
                if (searchEngineText.Length <= Data.productData[i].Name.Length)
                {
                    int resultCompareString = string.Compare(searchEngineText.ToLower(), Data.productData[i].Name.Substring(0, searchEngineText.Length).ToLower());
                    if (resultCompareString == 0)
                        dataTableSearchEngine.Rows.Add(Data.productData[i].Id, Data.productData[i].Name, Data.productData[i].Kcal, Data.productData[i].Protein, Data.productData[i].Fats, Data.productData[i].Carbohydrates);
                }
            }
            dataGridViewSearchProduct.DataSource = dataTableSearchEngine;
            dataGridViewSearchProduct.Columns[0].Visible = false;
        }
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
            }
            dataGridViewSelectedProducts.DataSource = dataTableSearchEngine;
            dataGridViewSelectedProducts.Columns[0].Visible = false;
        }
    }
}
