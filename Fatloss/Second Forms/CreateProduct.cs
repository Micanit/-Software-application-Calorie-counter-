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
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
        }
        private void CreateProduct_Load(object sender, EventArgs e)
        {
            if (Data.clickThroughButtonChangedFood == true)
            {
                this.Text = "Измененить продукт";
                textBoxNameProduct.Text = Data.productData[Data.idChangedFood - 1].Name;
                comboBoxProductUnit.SelectedText = Data.productData[Data.idChangedFood - 1].Unit;
                textBoxAmountKcal.Text = Data.productData[Data.idChangedFood - 1].Kcal.ToString();
                textBoxAmountProtein.Text = Data.productData[Data.idChangedFood - 1].Protein.ToString();
                textBoxAmountFats.Text = Data.productData[Data.idChangedFood - 1].Fats.ToString();
                textBoxAmountCarbohydrates.Text = Data.productData[Data.idChangedFood - 1].Carbohydrates.ToString();
                comboBoxIsProductAllergic.SelectedText = Data.productData[Data.idChangedFood - 1].IsItAnAllergen;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data.clickThroughButtonChangedFood == true)
                {
                    Data.productData.RemoveAt(Data.idChangedFood - 1);
                    if (textBoxNameProduct.Text.Length > 50)
                    {
                        throw new Exception("Длина имени должна быть меньше 50 символов");
                    }
                    Data.productData.Insert(Data.idChangedFood - 1, new Product()
                    {
                        Id = Convert.ToInt32(Data.idChangedFood),
                        Name = textBoxNameProduct.Text,
                        Unit = comboBoxProductUnit.Text,
                        Kcal = Convert.ToDouble(textBoxAmountKcal.Text),
                        Protein = Convert.ToDouble(textBoxAmountProtein.Text),
                        Fats = Convert.ToDouble(textBoxAmountFats.Text),
                        Carbohydrates = Convert.ToDouble(textBoxAmountCarbohydrates.Text),
                        IsItAnAllergen = comboBoxIsProductAllergic.Text,
                        IdUser = Convert.ToInt32(1),
                    });
                }
                else
                {
                    if (textBoxNameProduct.Text.Length > 50)
                    {
                        throw new Exception("Длина имени должна быть меньше 50 символов");
                    }
                    Data.productData.Add(new Product()
                    {
                        Id = Convert.ToInt32(Data.productData.Count + 2),
                        Name = textBoxNameProduct.Text,
                        Unit = comboBoxProductUnit.SelectedText,
                        Kcal = Convert.ToDouble(textBoxAmountKcal.Text),
                        Protein = Convert.ToDouble(textBoxAmountProtein.Text),
                        Fats = Convert.ToDouble(textBoxAmountFats.Text),
                        Carbohydrates = Convert.ToDouble(textBoxAmountCarbohydrates.Text),
                        IsItAnAllergen = comboBoxIsProductAllergic.SelectedText,
                        IdUser = Convert.ToInt32(1),
                    });
                }
                Data.clickThroughButtonChangedFood = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            } 
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
