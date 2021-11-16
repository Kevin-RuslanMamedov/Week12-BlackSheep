﻿using System;
using System.IO;

namespace ChuckNorrisRandomJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\opilane\Samples\chuck.txt";
            //string[] jokesAboutChuck = File.ReadAllLines(filePath);

            //Random rnd = new Random();
            //int randomIndex = rnd.Next(0, jokesAboutChuck.Length);
            //Console.WriteLine(jokesAboutChuck[randomIndex]);
        }

        public static string GetRandomJokes()
        {
            string filePath = @"C:\Users\opilane\Samples\chuck.txt";
            string[] jokesAboutChuck = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokesAboutChuck.Length);

            return jokesAboutChuck[randomIndex];


        }

    }
}
