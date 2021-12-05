using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Practice_2.ExceptionClasses;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Search By Country");
            Console.WriteLine("2.Search By City");
            Console.Write("Choose one option : ");
            int answer = Convert.ToInt32(Console.ReadLine());
            string path = @"../../../Cities.txt";
            string[] data = File.ReadAllLines(path);
            string response = string.Empty;
            bool errorCheck;
            string logPath = @"C:\Users\Owner\source\repos\LashaSuliashvili\Day_18\Practice_2\Practice_2\ExceptionClasses\Log.txt";
            switch (answer)
            {
                case 1:
                    GeneralSearch searchByCountry = new SearchByCountry();
                    Console.WriteLine("Enter the Country: ");
                    response = Console.ReadLine();
                    errorCheck = File.ReadAllText(path).ToLower().Contains(response.ToLower());
                    try
                    {
                        if (errorCheck == false)
                        {
                            throw new CurrentCountryDoesNotInFileException($"shemotanili qveyana {response} failshi ar idzebneba");
                        }
                        for (int i = 0; i < data.Length; i++)
                        {
                            var result = GeneralSearch.Parse(data[i]);
                            searchByCountry.PrintInfo(result, response);
                        }
                        
                        break;
                    }
                    catch (CurrentCountryDoesNotInFileException ex)
                    {
                        Console.WriteLine($"\n{ex.Message}");
                        File.AppendAllText(logPath, $"\nshemotanili qveyana {response} ar idzebneba failshi");
                        break;
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(logPath, $"\n{ex.Message}");
                        break;
                    }

                case 2:
                    GeneralSearch searchByCity = new SearchByCity();
                    Console.WriteLine("Enter the city: ");
                    response = Console.ReadLine();
                    errorCheck = File.ReadAllText(path).ToLower().Contains(response.ToLower());
                    try
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            var result = GeneralSearch.Parse(data[i]);
                            searchByCity.PrintInfo(result, response);
                        }
                        if (errorCheck == false)
                        {
                            throw new CurrentCityDoesNotInFileException($"shemotanili qalaqi {response} ver moidzebna fileshi");
                        }
                        break;
                    }
                    catch (CurrentCityDoesNotInFileException ex)
                    {
                        Console.WriteLine($"\n{ex.Message}");
                        File.AppendAllText(logPath, $"\nshemotanili qalaqi {response} ar idzebneba failshi");
                        break;
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(logPath, $"\n{ex.Message}");
                        break;
                    }
            }
        }
    }
}
