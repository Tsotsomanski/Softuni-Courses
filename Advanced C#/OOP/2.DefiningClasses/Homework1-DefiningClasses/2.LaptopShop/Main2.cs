using System;
namespace _2.LaptopShop
{
    class Main2
    {
        static void Main()
        {
            Laptop lenovo = new Laptop("Lenovo Yoga", 3000, new Battery("Nqkakva", 2), "Lenovo", "Intel", 5, "NVIDIA", "", "Full HD");

            Console.WriteLine(lenovo);
        }
    }
}
