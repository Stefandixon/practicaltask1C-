using System;

namespace Practical_task_1._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character();
            Character character2 = new Character();
            Character character3 = new Character();
            Character character4 = new Character();

            character1.Name = "Dean Keaton";
            character1.Type = "Team Member";
            character1.WeaponEffect = 4;
            character1.Health = 15;
            character1.GameCredit = 5;

            character2.Name = "KeizerSoze";
            character2.Type = "Enemy";
            character2.WeaponEffect = 2;
            character2.Health = 100;
            character2.GameCredit = 15;

            character3.Name = "ToddHockney";
            character3.Type = "Team Member ";
            character3.WeaponEffect = 2;
            character3.Health = 25;
            character3.GameCredit = 10;

            character4.Name = "EddieFinneran";
            character4.Type = "Civilian";
            character4.WeaponEffect = 0;
            character4.Health = 90;
            character4.GameCredit = 30;

            Console.WriteLine("****** Welcome to fps Extreme *****");
            Console.WriteLine("The in game characters are: ");
            Console.WriteLine("{0} {1} {2} {3}", "Name: " + character1.Name, "Type: " + character1.Type, "Health: " + character1.Health, "Weapon Effect: " + character1.WeaponEffect, "Game Credits: " + character1.GameCredit);
            Console.WriteLine("{0} {1} {2} {3}", "Name: " + character2.Name, "Type: " + character2.Type, "Health: " + character2.Health, "Weapon Effect: " + character2.WeaponEffect, "Game Credits: " + character2.GameCredit);
            Console.WriteLine("{0} {1} {2} {3}", "Name: " + character3.Name, "Type: " + character3.Type, "Health: " + character3.Health, "Weapon Effect: " + character3.WeaponEffect, "Game Credits: " + character3.GameCredit);
            Console.WriteLine("{0} {1} {2} {3}", "Name: " + character4.Name, "Type: " + character4.Type, "Health: " + character4.Health, "Weapon Effect: " + character4.WeaponEffect, "Game Credits: " + character4.GameCredit);
            character1.SpendAllGameCredits();
            character4.SpendAllGameCredits();
        }
    }
    class Character
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }
        public int WeaponEffect { get; set; }
        public int GameCredit { get; set; }

        public void SpendAllGameCredits()
        {

            if (Type == "Team Member" & GameCredit > 0)
            {
                Console.WriteLine("Dean, Keizer and Todd do you want to upgrade your weapon effect? y or n");
                string spendcreditsTME = Console.ReadLine();
                if (spendcreditsTME == "y")
                {
                    for (int i = 0; GameCredit > 0; i = i + 1)
                    {
                        WeaponEffect = WeaponEffect + 1;
                        GameCredit = GameCredit - 1;
                        Console.WriteLine("Weapon Effect has been increased by 1, Weapon effect is now " + WeaponEffect);
                    }
                    Console.WriteLine("Weapon Effect now equals: " + WeaponEffect + " and you have  " + GameCredit + " game credits");
                }
                else
                {
                    Console.WriteLine("Credits not Spent");
                }
            }


            else if (Type == "Civilian" & GameCredit > 0)
            {
                Console.WriteLine("Eddie do you want to upgrade your health?  y or n");
                string spendcreditsC = Console.ReadLine();
                if (spendcreditsC == "y")
                {                                                                                           // this section of code is the calculation to spend all of the game credits
                    for (int i = 0; GameCredit > 0; i = i + 1)
                    {
                        Health = Health + 5;
                        GameCredit = GameCredit - 1;
                        Console.WriteLine("Health has been increased by 5, health is now " + Health);
                    }
                    Console.WriteLine("Health now equals: " + Health + " and you have  " + GameCredit + " game credits");
                }
                else
                {
                    Console.WriteLine("Credits not Spent");
                }
            }
            else
            {
                Console.WriteLine("Credits not Spent");
            }
        }

    }
}
    


    
