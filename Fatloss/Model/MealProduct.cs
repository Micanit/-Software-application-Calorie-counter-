using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    internal class MealProduct
    {
        private int id;
        private int idMeal;
        private int idProduct;
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
        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        public MealProduct()
        {
            id = -1;
            idMeal = -1;
            idProduct = -1;
        }
        public MealProduct(int id, int idMeal, int idProduct)
        {
            Id = id;
            IdMeal = idMeal;
            IdProduct = idProduct;
        }
    }
}
