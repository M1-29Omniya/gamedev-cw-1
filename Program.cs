using System;

namespace SecAttempt
{
    using System;
        class Program
        {
            static double playerSpeed;
            static int[] characterPowerValues = { 10, 20, 20, 30, 60 };
            static void Main(string[] args)
            {
                int age = 15;
                double speed = 1.65;
                String characterName = "Ahmed", superPower1 = "Strong Aromer", superPower2 = "Night Vision";
                Console.WriteLine("\nMy name is " + characterName +
                                  ".\nMy Super powers are " + superPower1 + " and " + superPower2 +
                                  ". \nMy age is " + age + ".\nMy speed is " + speed + ".\n");

                //Another Hero

                String heroSuperPower1 = "Strength", heroSuperPower2 = "stealth", heroName = "Kasandra";
                int heroAge = 50;
                double heroHeight = 190.5;
                int ageDifference;

                if (heroSuperPower1 == superPower1 || superPower2 == heroSuperPower2)
                {
                    Console.WriteLine("The heros has one common super power.");
                }
                else
                {
                    Console.WriteLine("The heros has different super power.");
                }

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
                Console.WriteLine("Age difference is " + ageDifference + "\n");

                //Ex3
                setSpeed(2.5);
                Console.WriteLine("The current speed is " + getSpeed() + ".\n");

                //Ex4
                comparePowers();
            }
            static void setSpeed(double ps)
            {
                playerSpeed = ps;
            }
            static double getSpeed()
            {
                return playerSpeed;
            }
            static void comparePowers()
            {
                if (characterPowerValues[0] < characterPowerValues[2])
                {
                    Console.WriteLine("The strongest power is in level " + characterPowerValues[characterPowerValues.Length - 1]);
                }
            }
        }
    }