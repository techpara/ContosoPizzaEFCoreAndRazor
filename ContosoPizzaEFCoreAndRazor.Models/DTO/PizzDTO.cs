﻿namespace ContosoPizzaEFCoreAndRazor.Models.DTO
{
    public class PizzDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public int PizzaCategoryID { get; set; }
    }
}
