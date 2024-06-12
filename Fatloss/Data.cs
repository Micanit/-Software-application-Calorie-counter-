using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    static class Data
    {
        public static List<Dish> dishData = new List<Dish>();
        public static List<DishProduct> dishProductData = new List<DishProduct>();
        public static List<Meal> mealData = new List<Meal>();
        public static List<MealDish> mealDishData = new List<MealDish>();
        public static List<Product> productData = new List<Product>();
        public static List<MealProduct> mealProductData = new List<MealProduct>();
        public static List<User> userData = new List<User>();
        public static List<Weight> weightData = new List<Weight>();

        //Для формы Food
        public static bool clickThroughButtonChangedFood = false;
        public static string foodProductOrDishButtonChangedFood = string.Empty;
        public static int idChangedFood = -1;

        public static Dictionary<string, double> ratePhysicalActivity = new Dictionary<string, double>()
        {
            {"Минимум или отсутствие физцической нагрузки", 1.2},
            {"Занятие фитнесом 3 раза в неделю", 1.375},
            {"Занятие фитнесом 5 раз в неделю", 1.4625},
            {"Интенсивная физическая нагрузка 5 раз в неделю", 1.55},
            {"Занятие фитнесом каждый день", 1.6375},
            {"Каждый день интенсивно или по 2 раза в день", 1.725},
            {"Ежедневная физическая нагрузка плюс физическая работа", 1.9}
        };

        //Для формы Settings
        public static string WeightChanges = "Неделя";
    }
}
