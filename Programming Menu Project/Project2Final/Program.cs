using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Projek
{
    public class Enum_Menu_Project
    {
        //Reece Palk 577656
        //Manissha Packary 577639
        //Shayur Caithram 577312
        //Werner Janse van Rensburg 577930
        //Zack Pieters 577422

        //ALL GROUP MEMBERS PARTICIPATED


        public enum Combo_Meals
        {
            HamBurger = 95,
            SeaFoodPizza = 125,
            DoubleRibBurgers = 130
        }

        public enum BreakFast_Menu
        {
            EnglishBreakfast = 35,
            BreakfastSpecial = 45,
            BreakfastWrap = 60,
            AvoAndToast = 85
        }

        public enum Burgers_Menu
        {
            CheeseBurger = 90,
            RibEyeBurger = 110,
            ChickenPregoBurger = 115,
            MegaBaconRoyale = 125
        }

        public enum Chip_Menu
        {
            SmallChipNoDip = 35,
            MediumChipWtDip = 45,
            LargeChipWtDip = 55,
            UltraCheesy = 65
        }


        public enum Cool_Dronk
        {
            SmallKoce = 15,
            SmallSpront = 15,
            SmallMoonTanDoo = 15,
            MediumKoce = 25,
            MediumSpront = 25,
            MediumMoonTanDoo = 25,
            LargeKoce = 35,
            LargeSpront = 35,
            LargeMoonTanDoo = 35
        }


        static ArrayList arr = new ArrayList();
        static Stack<int> sadnumber = new Stack<int>();

        public static void Main(string[] args)
        {

            while (true)
            {
                Loop:
                Console.WriteLine("Welcome to the restaurant, We hope you enjoy!");
                Console.ReadKey();
                Console.WriteLine("Please press enter to see the meal options we have in store.");
                Console.ReadKey();
                Console.WriteLine("The options are as follows: " +
                                  "\n1. Breakfast" +
                                  "\n2. Combos" +
                                  "\n3. Burgers" +
                                  "\n4. Chips" +
                                  "\n5. Drinks" +
                                  "\n6. Checking Out" +
                                  "\nAnd lastly \bExiting the program\n\nPlease input the number of your choice:");
                int selectionOption = Convert.ToInt32(Console.ReadLine());

                if (selectionOption == 1)
                {
                    Console.WriteLine("You've chosen the Breakfast Menu:");
                    Console.ReadKey();

                    BreakFast_Menu choice1 = BreakFast_Menu.EnglishBreakfast;
                    BreakFast_Menu choice2 = BreakFast_Menu.BreakfastSpecial;
                    BreakFast_Menu choice3 = BreakFast_Menu.BreakfastWrap;
                    BreakFast_Menu choice4 = BreakFast_Menu.AvoAndToast;

                    int brakeSlow = 0;
                    string brakeSlowOption;
                    int brakeSlowNumber;


                    //Console.WriteLine("You've chosen the Breakfast Menu:");
                    //Console.ReadKey();

                    Console.WriteLine("1. " + choice1 + "\t" + "R" + (int)choice1 +
                                    "\n2. " + choice2 + "\t" + "R" + (int)choice2 +
                                    "\n3. " + choice3 + "\t" + "R" + (int)choice3 +
                                    "\n4. " + choice4 + "\t\t" + "R" + (int)choice4 +
                                    "\n5. To Return to the our menu on display");
                    //Console.ReadKey();
                    brakeSlow = Convert.ToInt32(Console.ReadLine());


                    switch (brakeSlow)
                    {
                        case 1:
                            brakeSlowOption = BreakFast_Menu.EnglishBreakfast.ToString();
                            brakeSlowNumber = (int)BreakFast_Menu.EnglishBreakfast;
                            Console.WriteLine("You decided to opt for: " + brakeSlowOption + "\t R " + brakeSlowNumber);
                            arr.Add(brakeSlowOption);
                            sadnumber.Push(brakeSlowNumber);
                            Console.ReadKey();
                            Console.Clear();
                            goto Loop;
                            break;


                        case 2:
                            brakeSlowOption = BreakFast_Menu.BreakfastSpecial.ToString();
                            brakeSlowNumber = (int)BreakFast_Menu.BreakfastSpecial;
                            Console.WriteLine("You decided to opt for: " + brakeSlowOption + "\t R " + brakeSlowNumber);
                            arr.Add(brakeSlowOption);
                            sadnumber.Push(brakeSlowNumber);
                            Console.ReadKey();
                            Console.Clear();
                            goto Loop;
                            break;

                        case 3:
                            brakeSlowOption = BreakFast_Menu.BreakfastWrap.ToString();
                            brakeSlowNumber = (int)BreakFast_Menu.BreakfastWrap;
                            Console.WriteLine("You decided to opt for: " + brakeSlowOption + "\t R " + brakeSlowNumber);
                            arr.Add(brakeSlowNumber);
                            sadnumber.Push(brakeSlowNumber);
                            Console.ReadKey();
                            Console.Clear();
                            goto Loop;
                            break;

                        case 4:
                            brakeSlowOption = BreakFast_Menu.AvoAndToast.ToString();
                            brakeSlowNumber = (int)BreakFast_Menu.AvoAndToast;
                            Console.WriteLine("You decided to opt for: " + brakeSlowOption + "\t R " + brakeSlowNumber);
                            arr.Add(brakeSlowNumber);
                            sadnumber.Push(brakeSlowNumber);
                            Console.ReadKey();
                            Console.Clear();
                            goto Loop;
                            break;

                        case 5:
                            Console.WriteLine("Eish...");
                            goto Loop;
                            break;



                    }
                }
                else if (selectionOption == 2)
                {
                    Console.WriteLine("You've chosen the Combo Menu");
                    Console.ReadKey();

                    Combo_Meals comboNo1 = Combo_Meals.HamBurger;
                    Combo_Meals comboNo2 = Combo_Meals.SeaFoodPizza;
                    Combo_Meals comboNo3 = Combo_Meals.DoubleRibBurgers;

                    int comboOption = 0;
                    string optionOfCombo;
                    int comboOptionNumber;

                    Console.WriteLine("1. " + comboNo1 + "\t R " + (int)comboNo1 +
                                    "\n2. " + comboNo2 + "\t R " + (int)comboNo2 +
                                    "\n3. " + comboNo3 + "\t R " + (int)comboNo3 +
                                    "\n4. To return back to the menu on display" +
                                    "\nPlease enter the number you would like:");

                    comboOption = Convert.ToInt32(Console.ReadLine());

                    switch (comboOption)
                    {
                        case 1:
                            optionOfCombo = Combo_Meals.HamBurger.ToString();
                            comboOptionNumber = (int)Combo_Meals.HamBurger;
                            Console.WriteLine("You decided to top for: " + optionOfCombo + "\t R " + comboOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfCombo);
                            sadnumber.Push(comboOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 2:
                            optionOfCombo = Combo_Meals.SeaFoodPizza.ToString();
                            comboOptionNumber = (int)Combo_Meals.SeaFoodPizza;
                            Console.WriteLine("You decided to top for: " + optionOfCombo + "\t R " + comboOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfCombo);
                            sadnumber.Push(comboOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 3:
                            optionOfCombo = Combo_Meals.DoubleRibBurgers.ToString();
                            comboOptionNumber = (int)Combo_Meals.DoubleRibBurgers;
                            Console.WriteLine("You decided to top for: " + optionOfCombo + "\t R " + comboOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfCombo);
                            sadnumber.Push(comboOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;
                    }
                }
                else if (selectionOption == 3)
                {
                    Console.WriteLine("You've chosen the Burgers Menu");
                    Console.ReadKey();

                    Burgers_Menu burgerOption1 = Burgers_Menu.CheeseBurger;
                    Burgers_Menu burgerOption2 = Burgers_Menu.RibEyeBurger;
                    Burgers_Menu burgerOption3 = Burgers_Menu.ChickenPregoBurger;
                    Burgers_Menu burgerOption4 = Burgers_Menu.MegaBaconRoyale;


                    int burgerOption = 0;
                    string optionOfBurger;
                    int burgerOptionNumber;

                    Console.WriteLine("1. " + burgerOption1 + "\t R " + (int)burgerOption1 +
                                    "\n2. " + burgerOption2 + "\t R " + (int)burgerOption2 +
                                    "\n3. " + burgerOption3 + "\t R " + (int)burgerOption3 +
                                    "\n4. " + burgerOption4 + "\t R " + (int)burgerOption4 +
                                    "\n4. To return back to the menu on display" +
                                    "\nPlease enter the number you would like:");

                    burgerOption = Convert.ToInt32(Console.ReadLine());

                    switch (burgerOption)
                    {
                        case 1:
                            optionOfBurger = Burgers_Menu.CheeseBurger.ToString();
                            burgerOptionNumber = (int)Burgers_Menu.CheeseBurger;
                            Console.WriteLine("You decided to top for: " + optionOfBurger + "\t R " + burgerOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfBurger);
                            sadnumber.Push(burgerOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 2:
                            optionOfBurger = Burgers_Menu.RibEyeBurger.ToString();
                            burgerOptionNumber = (int)Burgers_Menu.RibEyeBurger;
                            Console.WriteLine("You decided to top for: " + optionOfBurger + "\t R " + burgerOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfBurger);
                            sadnumber.Push(burgerOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 3:
                            optionOfBurger = Burgers_Menu.ChickenPregoBurger.ToString();
                            burgerOptionNumber = (int)Burgers_Menu.ChickenPregoBurger;
                            Console.WriteLine("You decided to top for: " + optionOfBurger + "\t R " + burgerOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfBurger);
                            sadnumber.Push(burgerOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 4:
                            optionOfBurger = Burgers_Menu.MegaBaconRoyale.ToString();
                            burgerOptionNumber = (int)Burgers_Menu.MegaBaconRoyale;
                            Console.WriteLine("You decided to top for: " + optionOfBurger + "\t R " + burgerOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfBurger);
                            sadnumber.Push(burgerOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;
                    }
                }

                else if (selectionOption == 4)
                {
                    Console.WriteLine("You've chosen the Chip Menu");
                    Console.ReadKey();

                    Chip_Menu chipOption1 = Chip_Menu.SmallChipNoDip;
                    Chip_Menu chipOption2 = Chip_Menu.MediumChipWtDip;
                    Chip_Menu chipOption3 = Chip_Menu.LargeChipWtDip;
                    Chip_Menu chipOption4 = Chip_Menu.UltraCheesy;


                    int chipOption;
                    string optionOfChip;
                    int chipOptionNumber;

                    Console.WriteLine("1. " + chipOption1 + "\t R " + (int)chipOption1 +
                                    "\n2. " + chipOption2 + "\t R " + (int)chipOption2 +
                                    "\n3. " + chipOption3 + "\t R " + (int)chipOption3 +
                                    "\n4. " + chipOption4 + "\t R " + (int)chipOption4 +
                                    "\n4. To return back to the menu on display" +
                                    "\nPlease enter the number you would like:");

                    chipOption = Convert.ToInt32(Console.ReadLine());

                    switch (chipOption)
                    {
                        case 1:
                            optionOfChip = Chip_Menu.SmallChipNoDip.ToString();
                            chipOptionNumber = (int)Chip_Menu.SmallChipNoDip;
                            Console.WriteLine("You decided to top for: " + optionOfChip + "\t R " + chipOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfChip);
                            sadnumber.Push(chipOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 2:
                            optionOfChip = Chip_Menu.MediumChipWtDip.ToString();
                            chipOptionNumber = (int)Chip_Menu.MediumChipWtDip;
                            Console.WriteLine("You decided to top for: " + optionOfChip + "\t R " + chipOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfChip);
                            sadnumber.Push(chipOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 3:
                            optionOfChip = Chip_Menu.LargeChipWtDip.ToString();
                            chipOptionNumber = (int)Chip_Menu.LargeChipWtDip;
                            Console.WriteLine("You decided to top for: " + optionOfChip + "\t R " + chipOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfChip);
                            sadnumber.Push(chipOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 4:
                            optionOfChip = Chip_Menu.UltraCheesy.ToString();
                            chipOptionNumber = (int)Chip_Menu.UltraCheesy;
                            Console.WriteLine("You decided to top for: " + optionOfChip + "\t R " + chipOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfChip);
                            sadnumber.Push(chipOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                    }
                }
                else if (selectionOption == 5)
                {
                    Console.WriteLine("You've chosen the Dronk Menu");
                    Console.ReadKey();

                    Cool_Dronk drinkOption1 = Cool_Dronk.SmallKoce;
                    Cool_Dronk drinkOption2 = Cool_Dronk.SmallSpront;
                    Cool_Dronk drinkOption3 = Cool_Dronk.SmallMoonTanDoo;
                    Cool_Dronk drinkOption4 = Cool_Dronk.MediumKoce;
                    Cool_Dronk drinkOption5 = Cool_Dronk.MediumSpront;
                    Cool_Dronk drinkOption6 = Cool_Dronk.MediumMoonTanDoo;
                    Cool_Dronk drinkOption7 = Cool_Dronk.LargeKoce;
                    Cool_Dronk drinkOption8 = Cool_Dronk.LargeSpront;
                    Cool_Dronk drinkOption9 = Cool_Dronk.LargeMoonTanDoo;


                    int drinkOption;
                    string optionOfDrink;
                    int drinkOptionNumber;

                    Console.WriteLine("1. " + drinkOption1 + "\t R " + (int)drinkOption1 +
                                    "\n2. " + drinkOption2 + "\t R " + (int)drinkOption2 +
                                    "\n3. " + drinkOption3 + "\t R " + (int)drinkOption3 +
                                    "\n4. " + drinkOption4 + "\t R " + (int)drinkOption4 +
                                    "\n5. " + drinkOption5 + "\t R " + (int)drinkOption5 +
                                    "\n6. " + drinkOption6 + "\t R " + (int)drinkOption6 +
                                    "\n7. " + drinkOption7 + "\t R " + (int)drinkOption7 +
                                    "\n8. " + drinkOption8 + "\t R " + (int)drinkOption8 +
                                    "\n9. " + drinkOption9 + "\t R " + (int)drinkOption9 +
                                    "\n9. To return back to the menu on display" +
                                    "\nPlease enter the number you would like:");

                    drinkOption = Convert.ToInt32(Console.ReadLine());

                    switch (drinkOption)
                    {
                        case 1:
                            optionOfDrink = Cool_Dronk.SmallKoce.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.SmallKoce;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 2:
                            optionOfDrink = Cool_Dronk.SmallSpront.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.SmallSpront;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 3:
                            optionOfDrink = Cool_Dronk.SmallMoonTanDoo.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.SmallMoonTanDoo;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 4:
                            optionOfDrink = Cool_Dronk.MediumKoce.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.MediumKoce;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 5:
                            optionOfDrink = Cool_Dronk.MediumSpront.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.MediumSpront;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 6:
                            optionOfDrink = Cool_Dronk.MediumMoonTanDoo.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.MediumMoonTanDoo;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 7:
                            optionOfDrink = Cool_Dronk.LargeKoce.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.LargeKoce;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 8:
                            optionOfDrink = Cool_Dronk.LargeSpront.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.LargeSpront;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                        case 9:
                            optionOfDrink = Cool_Dronk.LargeMoonTanDoo.ToString();
                            drinkOptionNumber = (int)Cool_Dronk.LargeMoonTanDoo;
                            Console.WriteLine("You decided to top for: " + optionOfDrink + "\t R " + drinkOptionNumber);
                            Console.ReadKey();
                            arr.Add(optionOfDrink);
                            sadnumber.Push(drinkOptionNumber);
                            Console.Clear();
                            goto Loop;
                            break;

                    }
                }
                else if (selectionOption == 6)
                {
                    Console.WriteLine("The items of your purchase is: ");
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item + "\t");
                    }
                    Console.WriteLine($"The total amount for your purchases are: " + sadnumber.Sum());
                }
                else Environment.Exit(0);
            }
        }
    }

}