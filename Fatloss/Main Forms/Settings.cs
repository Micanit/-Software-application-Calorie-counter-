using Fatloss.Properties;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        //Переменные для отслеживания закрытия вкладки
        bool trackerExit = true;
        private void Settings_Load(object sender, EventArgs e)
        {
            comboBoxWeightChange.Text = Data.WeightChanges.ToString();
        }
        #region Переходы по разделам: Главная, Еда, Отчёт

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
        //Переход в раздел Отчёт
        private void toolStripReport_Click(object sender, EventArgs e)
        {
            trackerExit = false;
            Report report = new Report();
            report.Owner = this;
            this.Hide();
            report.ShowDialog();
        }
        #endregion
        #region Переход по доп. разделам: Изменение личных параметров
        //Переход в раздел Изменение личных параметров
        private void buttonChangePersonalSettings_Click(object sender, EventArgs e)
        {
            ChangingPersonalSettings changingPersonalSettings = new ChangingPersonalSettings();
            changingPersonalSettings.Owner = this;
            this.Enabled = false;
            changingPersonalSettings.ShowDialog();
            this.Enabled = true;
        }
        #endregion
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.WeightChanges = comboBoxWeightChange.Text;
            if (trackerExit == true)
            {
                Application.Exit();
            }
            /*
            //КОД С БАГОМ
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
                        Settings settings = new Settings();
                        settings.Owner = this;
                        settings.ShowDialog();
                    }
                }
            }
            */
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
