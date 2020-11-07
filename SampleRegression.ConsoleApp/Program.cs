//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using SampleRegression.Model;

namespace SampleRegression.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Longitude = -114.31F,
                Latitude = 34.19F,
                Housing_median_age = 15F,
                Population = 1015F,
                Households = 472F,
                Median_income = 1.4936F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Median_house_value with predicted Median_house_value from sample data...\n\n");
            Console.WriteLine($"Longitude: {sampleData.Longitude}");
            Console.WriteLine($"Latitude: {sampleData.Latitude}");
            Console.WriteLine($"Housing_median_age: {sampleData.Housing_median_age}");
            Console.WriteLine($"Population: {sampleData.Population}");
            Console.WriteLine($"Households: {sampleData.Households}");
            Console.WriteLine($"Median_income: {sampleData.Median_income}");
            Console.WriteLine($"\n\nPredicted Median_house_value: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
