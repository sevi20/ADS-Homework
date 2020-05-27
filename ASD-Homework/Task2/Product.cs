using System;
using System.Collections.Generic;

namespace Task2
{
    class Product
    {
        private string name;
        private int quantity = 0;

        public static List<Product> Products = new List<Product>();

        public Product(string name, string quantity)
        {

            this.name = name;
            this.quantity = Math.Abs(Int32.Parse(quantity));

            Products.Add(this);
        }
        public void PrintInfo()
        {
            if (name != null && quantity != 0)
            {
                Console.WriteLine(" From " + this.name + " have " + this.quantity);
            }
        }

        public static void BubbleSort(List<Product> p) //p - product
        {
            bool size = true;

            do
            {
                for (int i = 0; i < p.Count - 1; i++)
                {
                    size = true;
                    if (p[i].quantity < p[i + 1].quantity)
                    {
                        Product temp = p[i];
                        p[i] = p[i + 1];
                        size = false;
                    }
                }
            } while (size == false);

        }



    }
}
