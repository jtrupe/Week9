/// Week 9 Project 1
///
/// @author: Julian Trupe
/// Date:  October 25, 2021
///
/// Problem Statement: Create an Odometer class with some methods
//
/// Overall Plan:
/// 1) Create Odometer class with two constructors and method to simulate driving
/// 2) Test each constructor in the main method
/// 3) Calculate mileage for each car
/// 4) Display results to the user


using System;

namespace hw9project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will test our Odometer class: ");
            Console.WriteLine("Testing no arg constructor");
            Odometer noArgCar = new Odometer();
            Console.WriteLine("No Arg Car Drives 200 miles and uses 6 gallons of gas");
            noArgCar.add(200, 6);
            noArgCar.ToString();
            Console.WriteLine("Testing other constructor");
            Odometer testCar = new Odometer(200, 6);
            testCar.ToString();
        }
    }

    class Odometer
    {
        int milesDriven;
        int fuelUsed;

        public Odometer()
        {
            milesDriven = 0;
            fuelUsed = 0;
        }

        public Odometer(int miles, int fuel)
        {
            this.milesDriven = miles;
            this.fuelUsed = fuel;
        }
        
        public void add(int miles, int fuel)
        {
            this.milesDriven += miles;
            this.fuelUsed += fuel;
        }

        public double calcMileage(int miles, int fuel)
        {
            double mileage = (double)miles / fuel;
            return mileage;
        }

        public void ToString()
        {
            double mileage = Math.Round(calcMileage(this.milesDriven, this.fuelUsed),2);
            Console.WriteLine("You drove " + this.milesDriven + " miles and used " + this.fuelUsed + " gallons of fuel, so your mileage is " + mileage + " miles per gallon");
        }
    }
}
