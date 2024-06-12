using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fatloss
{
    public partial class Food : Form
    { 
        public Food()
        {
            InitializeComponent();
        }
        //Переменные для отслеживания закрытия вкладки
        bool trackerExit = true;
        
        private void Food_Load(object sender, EventArgs e)
        {
            buttonSearch_Click(sender, e);
        }
        #region Переходы по разделам: Главная, Отчёт, Настройки
        //Переход в раздел Главная
        private void toolStripMenu_Click(object sender, EventArgs e)
        {
            trackerExit = false;
            this.Close();
            Form openForm = Application.OpenForms[0];
            openForm.Show();
        }
        //Переход в раздел Отчёт
        private void toolStripReport_Click(object sender, EventArgs e)
        {
            trackerExit = false;
            Report report = new Report();
            report.Owner = this;
            this.Hide();
            report.ShowDialog();
        }
        //Переход в раздел Настройки
        private void toolStripSettings_Click(object sender, EventArgs e)
        {
            trackerExit = false;
            this.Close();
            Settings settings = new Settings();
            settings.Owner = this;
            this.Hide();
            settings.ShowDialog();
        }
        #endregion
        #region Переход по доп. разделам: Создать продукт, Создать блюдо
        //Переход в раздел Создать продукт
        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.Owner = this;
            createProduct.ShowDialog();
        }
        //Переход в раздел Создать блюдо
        private void buttonCreateMeal_Click(object sender, EventArgs e)
        {
            CreateDish createDish = new CreateDish();
            createDish.Owner = this;
            createDish.ShowDialog();
        }
        #endregion
        //Работа поисковой строки
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchEngineText = textBoxSearchEngine.Text;

            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            DataTable dataTableSearchEngine = new DataTable();
            dataTableSearchEngine.Columns.Add("Id", typeof(int));
            dataTableSearchEngine.Columns.Add("Название", typeof(string));
            dataTableSearchEngine.Columns.Add("Калории", typeof(double));
            dataTableSearchEngine.Columns.Add("Белок", typeof(double));
            dataTableSearchEngine.Columns.Add("Жиры", typeof(double));
            dataTableSearchEngine.Columns.Add("Углеводы", typeof(double));
            dataTableSearchEngine.Columns.Add("ПродуктИлиБлюдо", typeof(string));

            for (int i = 0; i < Data.dishData.Count; i++)
            {
                if (searchEngineText.Length <= Data.dishData[i].Name.Length)
                {
                    int resultCompareString = string.Compare(searchEngineText.ToLower(), Data.dishData[i].Name.Substring(0, searchEngineText.Length).ToLower());
                    if (resultCompareString == 0)
                        dataTableSearchEngine.Rows.Add(Data.dishData[i].Id, Data.dishData[i].Name, Data.dishData[i].Kcal, Data.dishData[i].Protein, Data.dishData[i].Fats, Data.dishData[i].Carbohydrates, "Блюдо");
                }
            }
            for (int i = 0; i < Data.productData.Count; i++)
            {
                if (searchEngineText.Length <= Data.productData[i].Name.Length)
                {
                    int resultCompareString = string.Compare(searchEngineText.ToLower(), Data.productData[i].Name.Substring(0, searchEngineText.Length).ToLower());
                    if (resultCompareString == 0)
                        dataTableSearchEngine.Rows.Add(Data.productData[i].Id, Data.productData[i].Name, Data.productData[i].Kcal, Data.productData[i].Protein, Data.productData[i].Fats, Data.productData[i].Carbohydrates, "Продукт");
                }
            }
            dataGridView.DataSource = dataTableSearchEngine;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[6].Visible = false;

            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.AllowUserToOrderColumns = false;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].Resizable = DataGridViewTriState.False;
            }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Resizable = DataGridViewTriState.False;
            }
        }
        //Клик мышкой по полю
        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonChangeFood.Visible = true;
            buttonDeleteFood.Visible = true;
        }
        //Нажатие на кнопку Изменить Еду
        private void buttonChangeFood_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count < 2)
            {
                Data.clickThroughButtonChangedFood = true;
                Data.foodProductOrDishButtonChangedFood = dataGridView[6, dataGridView.SelectedCells[0].RowIndex].Value.ToString();
                if (Data.foodProductOrDishButtonChangedFood == "Продукт")
                {
                    Data.idChangedFood = Convert.ToInt32(dataGridView[0, dataGridView.SelectedCells[0].RowIndex].Value);
                    buttonCreateProduct_Click(sender,e);
                    Data.clickThroughButtonChangedFood = false;
                    buttonSearch_Click(sender,e);
                    buttonChangeFood.Visible = false;
                    buttonDeleteFood.Visible = false;
                }
                else if (Data.foodProductOrDishButtonChangedFood == "Блюдо")
                {
                    Data.idChangedFood = Convert.ToInt32(dataGridView[0, dataGridView.SelectedCells[0].RowIndex].Value);
                    buttonCreateMeal_Click(sender, e);
                    Data.clickThroughButtonChangedFood = false;
                    buttonSearch_Click(sender, e);
                    buttonChangeFood.Visible = false;
                    buttonDeleteFood.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Для изменения выберите всего один продукт или одно блюдо", "Внимание");
            }
        }
        //Нажатие на кнопку Удалить Еду
        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            string textSelectedCells = string.Empty;
            for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
            {
                if (i == dataGridView.SelectedCells.Count - 1)
                {
                    textSelectedCells = textSelectedCells + dataGridView[1, dataGridView.SelectedCells[i].RowIndex].Value + "?";
                }
                else
                {
                    textSelectedCells = textSelectedCells + dataGridView[1, dataGridView.SelectedCells[i].RowIndex].Value + ", ";
                }
            }
            DialogResult resultDeleteFood = MessageBox.Show($"Вы точно хотите удалить: {textSelectedCells} ", "Внимание", MessageBoxButtons.YesNo);
            if (resultDeleteFood == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView.SelectedCells.Count; i++)
                {
                    for (int j = 0; j < Data.dishData.Count; j++)
                    {
                        if (Convert.ToInt32(dataGridView[0, dataGridView.SelectedCells[i].RowIndex].Value) == Data.dishData[j].Id && dataGridView[1, dataGridView.SelectedCells[i].RowIndex].Value.ToString() == Data.dishData[j].Name)
                        {
                            Data.dishData.RemoveAt(Data.dishData[j].Id - 1);
                        }
                    }
                    for (int j = 0; j < Data.productData.Count; j++)
                    {
                        if (Convert.ToInt32(dataGridView[0, dataGridView.SelectedCells[i].RowIndex].Value) == Data.productData[j].Id && dataGridView[1, dataGridView.SelectedCells[i].RowIndex].Value.ToString() == Data.productData[j].Name)
                        {
                            Data.productData.RemoveAt(Data.productData[j].Id - 1);
                        }
                    }
                }
            }
            buttonSearch_Click(sender, e);
        }
        private void Food_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trackerExit == true)
            {
                Application.Exit();
            }
            /* КОД С БАГОМ
            //Метод закрытия формы при нажатии красной кнопки Выход
            //Внимание данные код выполняется 2 раза, так что сохранение файлов лучше здесь не делать
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
                        Food food = new Food();
                        food.Owner = this;
                        food.ShowDialog();
                    }
                }
            }
            */
        }
        private void Food_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
