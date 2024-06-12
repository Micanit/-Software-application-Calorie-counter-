using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    internal class MealDish
    {
        private int id;
        private int idMeal;
        private int idDish;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdMeal
        {
            get { return idMeal; }
            set { idMeal = value; }
        }
        public int IdDish
        {
            get { return idDish; }
            set { idDish = value; }
        }
        public MealDish()
        {
            id = -1;
            idMeal = -1;
            idDish = -1;
        }
        public MealDish(int id, int idMeal, int idDish)
        {
            Id = id;
            IdMeal = idMeal;
            IdDish = idDish;
        }
    }
}
