using System;

namespace First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15;
            double speed = 1.65;
            String characterName = "Ahmed", superPower1 = "Strong Aromer", superPower2 = "Night Vision";
            Console.WriteLine("\nMy name is " + characterName + 
                              ".\nMy Super powers are " + superPower1 + " and " + superPower2 + 
                              ". \nMy age is " + age + ".\nMy speed is "+speed+".");
                              ". \nMy age is " + age + ".\nMy speed is "+speed+".\n");

            //Another Hero

            String heroSuperPower1 = "Strength", heroSuperPower2 = "stealth", heroName = "Kasandra";
            int heroAge = 50;
            double heroHeight = 190.5;
            int ageDifference;

            if (age > heroAge)
            {
                ageDifference = age - heroAge;
            }
            else
            {
                ageDifference = heroAge - age;
            }
            Console.WriteLine("\nMy name is " + heroName +
                              ".\nMy Super powers are " + heroSuperPower1 + " and " + heroSuperPower2 +
                              ". \nMy age is " + heroAge + ".\nMy height is " + heroHeight + ".\n");
            Console.WriteLine("Age difference is "+ageDifference);
        }
    }
}
