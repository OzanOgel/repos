using System;

namespace WelcomeTo2023
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int şuanyıl = DateTime.Now.Year;

            
            if (şuanyıl == 2023)
            {
                // Display the welcome message
                Console.WriteLine("Hoş geldin 2023!");
            }
            else
            {
                Console.WriteLine("2022 de yiz daha göt");
            }
        }
    }
}
