using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    internal class DishProduct
    {
        private int id;
        private int idDish;
        private int idProduct;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdDish
        {
            get { return idDish; }
            set { idDish = value; }
        }
        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
        public DishProduct()
        {
            id = -1;
            idDish = -1;
            idProduct = -1;
        }
        public DishProduct(int id, int idDish, int idProduct)
        {
            Id = id;
            IdDish = idDish;
            IdProduct = idProduct;
        }
    }
}
