/// Week 9 Lab 1
///
/// @author: Julian Trupe
/// Date:  October 25, 2021
///
/// Problem Statement: Create a pizza class with some methods
//
/// Overall Plan:
/// 1) Create a Pizza class with properties for size, toppings, getters, setters, and methods for calculating and displaying the cost
/// 2) Greet the user and prompt for input 
/// 3) create specified pizza
/// 4) display the pizza and cost to the user

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Will make you a pizza");
            Console.WriteLine("What size pizza would you like: s, m, or l?");
            string size = Console.ReadLine();
            bool sizeFail = !(size.StartsWith('s') || size.StartsWith("S") || size.StartsWith('m') || size.StartsWith('M') || size.StartsWith('l') || size.StartsWith('L'));
            if (sizeFail){
                Console.WriteLine("Please choose pizza size s, m, or l");
                size = Console.ReadLine();
            }
            Console.WriteLine("How many cheese toppings would you like? ");
            int cheeses = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pepperoni toppings would you like? ");
            int pepperonis = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ham toppings would you like? ");
            int hams = int.Parse(Console.ReadLine());
            Pizza yourPizza = new Pizza(size, cheeses, pepperonis, hams);
            yourPizza.ToString();
        }
    }

    class Pizza
    {
        private string size;
        private int cheeseTops;
        private int peppTops;
        private int hamTops;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public int CheeseTops
        {
            get { return cheeseTops; }
            set { cheeseTops = value; }
        }
        public int PeppTops
        {
            get { return peppTops; }
            set { peppTops = value; }
        }
        public int HamTops
        {
            get { return hamTops; }
            set { hamTops = value; }
        }

        public Pizza(string size, int cheeses, int pepps, int hams)
        {
            this.size = size;
            this.cheeseTops = cheeses;
            this.peppTops = pepps;
            this.hamTops = hams;
        }

        public double CalculateCost(string size, int cheeses, int pepps, int hams)
        {
            double sum = 0;
            if(size.StartsWith('s') || size.StartsWith('S'))
            {
                sum = 10 + (2 * cheeses) + (2 * pepps) + (2 * hams);
            }else if (size.StartsWith('m') || size.StartsWith('M'))
            {
                sum = 12 + (2 * cheeses) + (2 * pepps) + (2 * hams);

            }
            else if (size.StartsWith('l') || size.StartsWith('L'))
            {
                sum = 14 + (2 * cheeses) + (2 * pepps) + (2 * hams);

            }
            else
            {
                Console.WriteLine("Please choose size s, m, or l ");
            }
            return sum;
        }

        public void ToString()
        {
            double cost = CalculateCost(this.size, this.cheeseTops, this.peppTops, this.hamTops);
            Console.WriteLine("Your " + this.Size + " pizza with " + this.CheeseTops + " cheese toppings, " + this.PeppTops + " pepperoni toppings, and " + this.HamTops + " ham toppings will cost you $" + cost);
        }
    }
}
