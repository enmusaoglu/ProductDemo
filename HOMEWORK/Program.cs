using System;

namespace homework1
{
    class Program
    {
        class myProduct
        {
            public string productName { get; set; }
            public string productBand { get; set; }
            public string productModel { get; set; }
            public int productPrice { get; set; }

        }
        static void Main(string[] args)
        {



            myProduct product1 = new myProduct();
            product1.productName = "Smart Phone";
            product1.productBand = "Apple";
            product1.productModel = "Iphone 11 Pro Max";
            product1.productPrice = 11999;

            myProduct product2 = new myProduct();
            product2.productName = "Car";
            product2.productBand = "Ferrari";
            product2.productModel = "458 Spider";
            product2.productPrice = 3500000;

            myProduct product3 = new myProduct();
            product3.productName = "Headphones";
            product3.productBand = "Samsung";
            product3.productModel = "Buds";
            product3.productPrice = 1099;

            myProduct product4 = new myProduct();
            product4.productName = "Notebook";
            product4.productBand = "Monster";
            product4.productModel = "Abra A5";
            product4.productPrice = 7699;

            Console.WriteLine("----------------foreach ile------------------");
            myProduct[] products = new myProduct[] { product1, product2, product3, product4 };
            foreach (myProduct product in products)
            {
                Console.WriteLine(product.productName + " " + product.productBand + " " + product.productModel + " : " + product.productPrice + "TL");


            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("--------------for döngüsü ile----------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName + " " + products[i].productBand + " " + products[i].productModel + " : " + products[i].productPrice + "TL");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("--------------while döngüsü ile----------------");
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].productName + " " + products[a].productBand + " " + products[a].productModel + " : " + products[a].productPrice + "TL");
                a++;
            }
        }
    }
}
