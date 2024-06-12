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
    public partial class ChangingPersonalSettings : Form
    {
        public ChangingPersonalSettings()
        {
            InitializeComponent();
        }
        private void ChangingPersonalSettings_Load(object sender, EventArgs e)
        {
            textBoxWeight.Text = Data.weightData.Last().Weighing.ToString();
            textBoxHeight.Text = Data.userData[0].Height.ToString();
            textBoxAge.Text = Data.userData[0].Age.ToString();
            comboBoxHPA.SelectedText = Data.userData[0].PhysicalActivityRate;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Data.userData[0].Age = Convert.ToInt32(textBoxAge.Text);
                Data.userData[0].Height = Convert.ToInt32(textBoxHeight.Text);
                Data.userData[0].PhysicalActivityRate = comboBoxHPA.Text;
                if (textBoxWeight.Text != Data.weightData.Last().Weighing.ToString())
                {
                    Data.weightData.Add(new Weight()
                    {
                        Id = Data.weightData.Count + 1,
                        Weighing = Convert.ToInt32(textBoxWeight.Text),
                        WeighingDate = DateTime.Now,
                        IdUser = 1
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите все данные корректно", "Внимание");
            }
            this.Close();
        }
    }
}
