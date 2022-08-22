using System;
using System.Collections.Generic;
using System.Text;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            // Dot Notation
            var eddiesCar = new Car();

                eddiesCar.Make = "Ford";
                eddiesCar.Model = "Mustang";
                eddiesCar.Year = 2015;
                eddiesCar.EngineNoise = "vroooom";
                eddiesCar.HonkNoise = "buumm";
                eddiesCar.IsDriveable = true;
            
            lot.Cars.Add(eddiesCar);
            CarLot.numberOfCars += 1;
            
            
            //Object Initializer Syntax
            var matteosCar = new Car()
            {
                Year = 2018,
                Make = "Chevy",
                Model = "Malibu",
                EngineNoise = "eeee",
                HonkNoise = "beep beep",
                IsDriveable = true
            };
            lot.Cars.Add(matteosCar);
            CarLot.numberOfCars ++;
            
            //Using the Constructor to allow parameter values to be placed inside properties
            var ghulisCar = new Car(2020, "Lambo", "Veneno", "wruum", "Get out the way", true);
            lot.Cars.Add(ghulisCar);
            CarLot.numberOfCars  ++;
            Console.WriteLine($"Cars in lot= {CarLot.numberOfCars}");
            
            // Calling specific methods
            eddiesCar.MakeEngineNoise();
            ghulisCar.MakeEngineNoise();
            matteosCar.MakeEngineNoise();


            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($" Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

        }
    }
}
            
            




           

           




