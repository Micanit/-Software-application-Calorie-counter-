using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    internal class Dish
    {
        private int id;
        private string name;
        private double kcal;
        private double protein;
        private double fats;
        private double carbohydrates;
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
        public double Kcal
        {
            get { return kcal; }
            set { kcal = value; }
        }
        public double Protein
        {
            get { return protein; }
            set { protein = value; }
        }
        public double Fats
        {
            get { return fats; }
            set { fats = value; }
        }
        public double Carbohydrates
        {
            get { return carbohydrates; }
            set { carbohydrates = value; }
        }
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public Dish()
        {
            id = -1;
            name = string.Empty;
            kcal = 0;
            protein = 0;
            fats = 0;
            carbohydrates = 0;
            idUser = -1;
        }
        public Dish(int id, string name, double kcal, double protein, double fats, double carbohydrates, int idUser)
        {
            Id = id;
            Name = name;
            Kcal = kcal;
            Protein = protein;
            Fats = fats;
            Carbohydrates = carbohydrates;
            IdUser = idUser;
        }
    }
}
