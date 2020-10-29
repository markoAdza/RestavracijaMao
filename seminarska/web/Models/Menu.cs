using System;
using System.Collections.Generic;

namespace web.Models
{

    public enum MenuType
    {
        Mesni, Veganski, brezSkladkorja, brezAlergenov
    }

    public class Menu
    {
        public int ID { get; set; }
        public MenuType? MenuType { get; set; }
        public string FoodName { get; set; }
        public DateTime DateAdded { get; set; }

    }
}