using System;

namespace Cost
{
    class Program
    {
        static void Main()
        {
            float[] Items = { 100.0f, 112.2f, 301.1f };
            float[] Discounts = { 10.0f, 0.0f, 0.0f };
            Product products = new Product(Items, Discounts);
            products.CalculateCost();

            Console.WriteLine("Order Items: [" + products.ToString(Items) + "]");
            Console.WriteLine("Discounts: [" + products.ToString(Discounts) + "]");
            Console.WriteLine("Total sum: " + products.Cost);
        }
    }
    public class Product
    {
        public float[] Items { get; private set; }
        public float[] Discounts { get; private set; }
        public float Cost { get; private set; }

        public Product(float[] Items, float[] Discounts)
        {
            this.Items = Items;
            this.Discounts = Discounts;
        }
        public void CalculateCost()
        {
            Cost = 0;
            for (int index = 0; index < Items.Length; index++)
                Cost += Items[index] - (Items[index] * (Discounts[index] / 100));
        }
        public string ToString(float[] arr)
        {
            string str = "";
            for (int index = 0; index < arr.Length; index++)
                str += arr[index].ToString() + ", ";
            return str.Remove(str.Length - 2); ;
        }
    }
}
