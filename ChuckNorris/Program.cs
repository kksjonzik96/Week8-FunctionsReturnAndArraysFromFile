﻿using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJokes;
            randomJokes = GetRandomFromFile("chuck.txt");
            


            Console.WriteLine($"Chuck Norris joke: {randomJokes}");

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }


        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\Desktop\nadal 8\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }

    }
}
