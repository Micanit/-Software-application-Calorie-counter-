using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    internal class Meal
    {
        private int id;
        private string name;
        private DateTime mealDate;
        private double totalCaloriesPerMeal;
        private int idUser;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime MealDate
        {
            get { return mealDate; }
            set { mealDate = value; }
        }
        public double TotalCaloriesPerMeal
        {
            get { return totalCaloriesPerMeal; }
            set { totalCaloriesPerMeal = value; }
        }
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public Meal()
        {
            id = -1;
            name = String.Empty;
            mealDate = DateTime.MinValue;
            totalCaloriesPerMeal = 0;
            idUser = -1;
        }
        public Meal(int id, string name, DateTime mealDate,  double totalCaloriesPerMeal, int idUser)
        {
            Id = id;
            Name = name;
            MealDate = mealDate;
            TotalCaloriesPerMeal = totalCaloriesPerMeal;
            IdUser = idUser;
        }
    }
}
