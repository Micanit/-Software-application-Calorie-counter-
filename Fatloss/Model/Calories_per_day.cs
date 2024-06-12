using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    internal class Calories_per_day
    {
        private int id;
        private DateTime dateCaloriesPerDay;
        private double caloriesPerDay;
        private int idUser;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DateCaloriesPerDay
        {
            get { return dateCaloriesPerDay; }
            set {  dateCaloriesPerDay = value; }
        }
        public double CaloriesPerDay
        {
            get { return caloriesPerDay; }
            set { caloriesPerDay = value; }
        }
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public Calories_per_day()
        {
            id = -1;
            dateCaloriesPerDay = DateTime.MinValue;
            caloriesPerDay = 0;
            idUser = 0;
        }
        public Calories_per_day(int id, DateTime dateCaloriesPerDay, double caloriesPerDay, int idUser)
        {
            Id = id;
            DateCaloriesPerDay = dateCaloriesPerDay;
            CaloriesPerDay = caloriesPerDay;
            IdUser = idUser;
        }
    }
}
