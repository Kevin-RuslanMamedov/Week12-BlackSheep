using System;
using System.IO;

namespace FruitAndVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            //read data from fruit.txt
            string fruitPath = @"C:\Users\opilane\Samples\fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);

            //read data from veggies.txt
            string veggiePath = @"C:\Users\opilane\Samples\veggie.txt";
            string[] fruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitPath, fruitData);
            File.WriteAllLines(veggiePath, veggieData);



        }
    }
}
