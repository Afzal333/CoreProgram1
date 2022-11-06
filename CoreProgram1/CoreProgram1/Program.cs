﻿using System;

namespace CoreProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CoreProgram Exercise 1");
            Console.WriteLine("1.FlipCoin" + "\n" +
                                "2.LeapYear" + "\n" +
                                "3.Powerof2"+"\n" +
                                "4.Harmonic Number"+"\n"+
                                "5.PrimeFactor"+"\n");
            Console.WriteLine("Enter option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.play(100);
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Year();
                    break;
                case 3:
                    PowerofTwo powerofTwo = new PowerofTwo();
                    Console.WriteLine("\n"+"Enter the power value");
                    int power = Convert.ToInt32(Console.ReadLine());
                    powerofTwo.Power(power);
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    Console.WriteLine("Enter the Range for Harmonic Number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    harmonicNumber.Calculate(number);
                    break;
                case 5:
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.Factor();
                    break;

            }
        }
    }
}
