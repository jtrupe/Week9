/// Week 9 Project 2
///
/// @author: Julian Trupe
/// Date:  October 25, 2021
///
/// Problem Statement: Create an Odometer class with some methods
//
/// Overall Plan:
/// 1) Create temperature class with four constructors and methods for conversion, printing t0 screen
/// 2) Test each constructor in the main method
/// 3) display results to the console

using System;

namespace hw9project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will test our Temperature class:");
            Temperature temp1 = new Temperature();
            Console.WriteLine("No argument constructor");
            temp1.ToString();
            Temperature temp2 = new Temperature(0);
            temp2.ToString();
            temp1.tempEquals(temp1, temp2);
            Temperature temp3 = new Temperature('F');
            temp3.ToString();
            Temperature temp4 = new Temperature(50, 'f');
            temp4.ToString();
            temp1.tempEquals(temp3, temp4);
            temp3.setTemp(50);
            temp1.tempEquals(temp3, temp4);
            temp1.setScale('f');
            temp2.setAll(50, 'F');
            temp1.tempEquals(temp2, temp4);
           
        }
    }

    class Temperature
    {
        double temp;
        char scale;

        public Temperature()
        {
            this.scale = 'C';
            this.temp = 0;
        }
        public Temperature(double tempC)
        {
            this.scale = 'C';
            this.temp = tempC;
        }
        public Temperature(char cf)
        {
            this.temp = 0;
            this.scale = cf;
            if(scale != 'f' && scale != 'F' && scale!= 'c' && scale != 'C')
            {
                Console.WriteLine("Please Choose F or C for desired temperature scale");
                this.scale = ' ';
            }
        }
        public Temperature(double tempCF, char cf)
        {
            this.temp = tempCF;
            this.scale = cf;
        }

        public void setTemp(double tempCF)
        {
            this.temp = tempCF;
        }

        public void setScale(char cf)
        {
            this.scale = cf;
            if (scale != 'f' && scale != 'F' && scale != 'c' && scale != 'C')
            {
                Console.WriteLine("Please Choose F or C for desired temperature scale");
                this.scale = ' ';
            }
        }

        public void setAll(double tempCF, char cf)
        {
            this.temp = tempCF;
            this.scale = cf;
            if (scale != 'f' && scale != 'F' && scale != 'c' && scale != 'C')
            {
                Console.WriteLine("Please Choose F or C for desired temperature scale");
                this.scale = ' ';
            }
        }

        public double getTempF()
        {
            if(this.scale == 'f' || this.scale == 'F')
            {
                return Math.Round(this.temp, 1);
            }
            else if(this.scale == 'c' || this.scale == 'C')
            {
                double convertedTemp = this.temp*(9/5) + 32 ;
                return Math.Round(convertedTemp, 1);
            }
            else
            {
                Console.WriteLine("Please Choose F or C for desired temperature scale");
                return 0;
            }
        }

        public double getTempC()
        {
            if (this.scale == 'c' || this.scale == 'C')
            {
                return Math.Round(this.temp,1);
            }
            else if (this.scale == 'f' || this.scale == 'F')
            {
                double convertedTemp = (this.temp - 32) * (5 / 9);
                return Math.Round(convertedTemp, 1);
            }
            else
            {
                Console.WriteLine("Please Choose F or C for desired temperature scale");
                return 0;
            }
        }

        public void ToString()
        {
            if (this.scale == 'c' || this.scale == 'C')
            {
                double tempC = getTempC();
                Console.WriteLine("The temperature is " + tempC + " degrees Celsius");
            }
            else if (this.scale == 'f' || this.scale == 'F')
            {
                double tempF = getTempF();
                Console.WriteLine("The temperature is " + tempF + " degrees Fahrenheit");
            }
            else
            {
                Console.WriteLine("Please Choose F or C for desired temperature scale");
            }
        }

        public bool tempEquals(Temperature temp1, Temperature temp2)
        {
            if (Char.ToUpper(temp1.scale) == Char.ToUpper(temp2.scale))
            {
                if (temp1.temp == temp2.temp)
                {
                    Console.WriteLine("The temperatures are equal");
                    return true;
                }
                else
                {
                    Console.WriteLine("The temperatures are not equal");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("The temperatures are not equal");
                return false;
            }
        }
    }

}
