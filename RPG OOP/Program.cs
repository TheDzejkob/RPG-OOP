using RPG_OOP.classy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace RPG_OOP
{
    public class Program
    {


        static void Main(string[] args)
        {
            bool comb = false;

            Entity enemy;

            string meno = "";

            bool heavy = true;

            bool kro = false;

            bool utek = true;
            
            while (meno == "")
            {

                Console.WriteLine("Vspiš meno pro svou postavu");
                meno = Console.ReadLine();

            }


            Console.WriteLine("-----------------");

            Player player = new Player(meno, 20, 2, true, 0 ,1.5);

            zacatek:

            string input = "";

            while (input == "" || comb == false)
            {
                input = Console.ReadLine();
                krok();
                if (player.Hp <= 0 || input == "exit")
                {
                    Console.WriteLine("zemřel jsi");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Zemřel hrdina jménem: " + player.Name);
                    Console.WriteLine("S počtem kroků: " + player.Stepcounter);
                    Console.ReadLine();
                    break;
                }

                if (comb == true)
                {
                    break;
                }

                


            }
           
        void krok() 
        {

                string filePath = @"C:\\Users\\PCnetz\\Desktop\\RPG OOP\\negr.txt";

                
                string[] lines = File.ReadAllLines(filePath);

                
                Random random = new Random();
                int randomIndex = random.Next(lines.Length);

                
                string selectedLine = lines[randomIndex];
                string[] parts = selectedLine.Split(';');
                double iD = double.Parse(parts[0]);
                string text = parts[1];
                player.Stepcounter++;

                Console.WriteLine(text);


                if (iD == 0)
                {

                }
                else if (iD == 1.01)
                {

                    Entity krysa = new Entity("Krysa",5,1,false);
                    Console.WriteLine("-----------------");
                    enemy = krysa;
                    while (enemy.Hp > 0) 
                    { 

                    combat();
                    
                    }

                    if (enemy.Hp <= 0)
                    {
                        heavy = true;
                        kro = true;
                        utek = true;
                        
                    }

                }
                else if (iD == 1.02) 
                {

                    Entity Vlk = new Entity("Vlk", 8, 3, false);
                    Console.WriteLine("-----------------");
                    enemy = Vlk;
                    while (enemy.Hp > 0)
                    {

                        combat();

                    }

                    if (enemy.Hp <= 0)
                    {
                        heavy = true;
                        kro = true;


                    }


                }

                //Jsou 4h rano a mam v sobe 4ty kafe, miluju svuj zivot xD
                
        }


        void combat()
        {
                comb = true;
                
                
                Console.WriteLine();

                Console.WriteLine("Vyber jednu z nasledujících možností");
                Console.WriteLine("1 pro základní útok");
                Console.WriteLine("2 pro těžký útok");
                Console.WriteLine("3 pro pokus o útěk");

                string comba = Console.ReadLine();
                if (enemy.Hp <= 0)
                {
                    krok();
                }

                if (comba == "1")
                {
                    int result1 = enemy.Hp - player.Dmg;
                    enemy.Hp = result1;
                    Console.WriteLine("Udělil jsi " + player.Dmg + " poškození nepříteli " + enemy.Name + " a zbylo mu " + enemy.Hp + " životů.");
                    Console.ReadLine();
                    if(enemy.Hp > 0) 
                    { 
                    enemyAtt();
                    }


                }
                if (comba == "2" && heavy == false)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Teď nemůžeš použít těžký útok");
                    Console.ReadLine();
                }

                if (comba == "2" && heavy == true) 
                {
                    heavy = false;
                    int result2 = (int)(enemy.Hp - (player.Dmg * player.Multiplier));
                    enemy.Hp = result2;
                    Console.WriteLine("Zasadil jsi nepříteli " + enemy.Name + " těžký úder a zbývá mu " + enemy.Hp);
                    Console.ReadLine();
                    if (enemy.Hp > 0)
                    {
                        enemyAtt();
                    }


                }

                if (comba == "3" && utek == false)
                {
                    Console.WriteLine("O útěk jsi se již pokusil a nevyšlo to");

                }

                if (comba == "3" && utek == true)
                {
                    bool GeneratorBool()
                    {
                        Random random = new Random();
                        return random.Next(100) < 20;
                    }
                    bool sance = GeneratorBool();
                    if (sance == true) 
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Povedlo se ti utéct");
                        enemy.Hp = 0;
                    }
                    if (sance == false) 
                    {
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Nepovedlo se ti utéct");
                        utek = false;
                    }


                }





        }

        void enemyAtt()
        {
            
                int result2 = player.Hp - enemy.Dmg;
                player.Hp = result2;
                Console.WriteLine("Nepřítel " + enemy.Name + " ti udělil " + enemy.Dmg + " poškození a zbívá ti " + player.Hp + " životů.");
                Console.ReadLine();

        }

            if (kro == true) 
            {
                goto zacatek;
            }


        }
    }
}
