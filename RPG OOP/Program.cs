﻿using RPG_OOP.classy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Spectre.Console;
using System.Security.Cryptography.X509Certificates;

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
            jmeno();
            void jmeno()
            {
                while (meno == "")
                {

                    var name = AnsiConsole.Ask<string>("[italic green]Jak ti máme říkat dobrodruhu?[/]");
                    meno = name;
                    overeniMeno();

                }
            }
            void overeniMeno()
            {
<<<<<<< HEAD
                var overeni = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("Přeješ si být tedy nazíván/a " + meno + "?")
                    .PageSize(3)
                    .AddChoices(new[] {
                        "Ano", "Ne",
                    }));
                if (overeni == "Ano")
=======
                input = Console.ReadLine();
                if (input == "") 
                {
                krok();
                }


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

                if (input == "help")
                {
                    
                    Console.WriteLine("Všechny použitelné příkazy");
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("exit  příkaz pro opuštění programu");
                    Console.WriteLine("help pro zobrazeni tohoto menu");
                    Console.WriteLine("postava pro výpis atributů a inventáře tvé postavy");
                    Console.ReadLine();

                }

                if (input == "postava")
                {
                    Console.Clear();
                    Console.WriteLine("Tvá postava");
                    Console.WriteLine("-----------");
                    Console.WriteLine("Jméno: " + player.Name);
                    Console.WriteLine("Životy: " + player.Hp);
                    Console.WriteLine("Počet kroků: " + player.Stepcounter);
                    Console.WriteLine("Míradongy: " + player.Coiny);
                    if (player.Items.Count == 0) 
>>>>>>> 4ad409952bcdebc87047262041c53dac0de638e2
                {
                    AnsiConsole.Write(new Markup("[bold green] Dobrá tedy tvé jméno je [/] " + meno + "."));
                }
                else
                {
                    meno = "";
                    jmeno();
                }
            }


            Console.ReadLine();
            AnsiConsole.Write(new Markup("[#8d99ae]------------------[/]"));

            Player player = new Player(meno, 20, 2, true, 0, 1.5, new List<Item>(), 0);


            zacatek();
            void zacatek()
            {
                string input = "";

                while (input == "" || comb == false)
                {
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        krok();
                    }


                    if (player.Hp <= 0 || input == "exit")
                    {
<<<<<<< HEAD
<<<<<<< HEAD
                    Console.WriteLine("-Tvůj inventář-");
                    Console.WriteLine("       ↓      ");
                        for(int i = 0; i < player.Items.Count; i++)
{
                            Console.WriteLine(player.Items[i].Name);
=======
                        Console.Clear();
                        var table = new Table();
                        table.AddColumn(new TableColumn("SuperTajnýSkrytýNadpis"));
                        table.AddRow("Zemřel hrdina jménem " + player.Name + " \nS počtem kroků " + player.Stepcounter + "\nNechť je ti zem lehká příteli");
                        table.Title("[bold red]Zemřel Jsi[/]"); table.HideHeaders();
                        table.Border(TableBorder.AsciiDoubleHead);
                        table.BorderColor(Color.Red);
                        table.Centered();
                        AnsiConsole.Write(table);
                        Console.ReadLine();
                        break;
                    }

                    if (input == "help")
                    {
<<<<<<< HEAD
                        menu();
                    }
                    void menu()
                    {
                        var overeni = AnsiConsole.Prompt(
                       new SelectionPrompt<string>()
                       .Title("[green]MENU[/]")
                       .PageSize(6)
                       .AddChoices(new[] {
                        "Staty", "Inventář","Bestiář (Work in progress)","Crafting (Work in progress)",
                       }));
                        if (overeni == "Staty")
                        {
                            staty();
                        }
                        if (overeni == "Inventář")
                        {
                            inventory();
>>>>>>> 51d890e05b67384df4016b4ff26783c6de3ef154
                        }
                    }
                    void staty()
                    {
=======

                        Console.WriteLine("Všechny použitelné příkazy");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("exit  příkaz pro opuštění programu");
                        Console.WriteLine("help pro zobrazeni tohoto menu");
                        Console.WriteLine("postava pro výpis atributů a inventáře tvé postavy");
                        Console.ReadLine();

                    }

                    if (input == "postava")
                    {
>>>>>>> parent of ddfbac7 (Menu)
                        Console.Clear();
                        Console.WriteLine("Tvá postava");
                        Console.WriteLine("-----------");
                        Console.WriteLine("Jméno: " + player.Name);
                        Console.WriteLine("Životy: " + player.Hp);
                        Console.WriteLine("Počet kroků: " + player.Stepcounter);
                        Console.WriteLine("Coiny: " + player.Coiny);
                        if (player.Items.Count == 0)
                        {
                            Console.WriteLine("Tvůj inventář: " + "Tvůj Inventář je prázdný");
                        }
                        else
                        {
                            Console.WriteLine("-Tvůj inventář-");
                            Console.WriteLine("       ↓      ");
                            for (int i = 0; i < player.Items.Count; i++)
                            {
                                Console.WriteLine(player.Items[i].Name);
                            }
                        }

                        Console.ReadLine();

<<<<<<< HEAD
<<<<<<< HEAD
                    Console.ReadLine();
=======
                    meno = "";
                    jmeno();
                    }
            }
            

            Console.ReadLine();
            AnsiConsole.Write(new Markup("[#8d99ae]------------------[/]"));

            Player player = new Player(meno, 20, 2, true, 0, 1.5, new List<Item>(), 0);


            zacatek();
            void zacatek()
            {
                string input = "";

                while (input == "" || comb == false)
                {
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        krok();
                    }


                    if (player.Hp <= 0 || input == "exit")
                    {
                        Console.Clear();
                        var table = new Table();
                        table.AddColumn(new TableColumn("SuperTajnýSkrytýNadpis"));
                        table.AddRow("Zemřel hrdina jménem " + player.Name + " \nS počtem kroků " + player.Stepcounter + "\nNechť je ti zem lehká příteli");
                        table.Title("[bold red]Zemřel Jsi[/]"); table.HideHeaders();
                        table.Border(TableBorder.AsciiDoubleHead);
                        table.BorderColor(Color.Red);
                        table.Centered();
                        AnsiConsole.Write(table);
                        Console.ReadLine();
                        break;
                    }

                    if (input == "help")
                    {

                        Console.WriteLine("Všechny použitelné příkazy");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("exit  příkaz pro opuštění programu");
                        Console.WriteLine("help pro zobrazeni tohoto menu");
                        Console.WriteLine("postava pro výpis atributů a inventáře tvé postavy");
                        Console.ReadLine();

                    }

                    if (input == "postava")
                    {
                        Console.Clear();
                        Console.WriteLine("Tvá postava");
                        Console.WriteLine("-----------");
                        Console.WriteLine("Jméno: " + player.Name);
                        Console.WriteLine("Životy: " + player.Hp);
                        Console.WriteLine("Počet kroků: " + player.Stepcounter);
                        Console.WriteLine("Coiny: " + player.Coiny);
                        if (player.Items.Count == 0)
                        {
                            Console.WriteLine("Tvůj inventář: " + "Tvůj Inventář je prázdný");
                        }
                        else
                        {
                            Console.WriteLine("-Tvůj inventář-");
                            Console.WriteLine("       ↓      ");
                            for (int i = 0; i < player.Items.Count; i++)
                            {
                                Console.WriteLine(player.Items[i].Name);
                            }
                        }

                        Console.ReadLine();

                    }
<<<<<<< HEAD
>>>>>>> parent of ddfbac7 (Menu)
=======
>>>>>>> 51d890e05b67384df4016b4ff26783c6de3ef154
=======
                    }
>>>>>>> parent of ddfbac7 (Menu)
=======
>>>>>>> parent of ddfbac7 (Menu)

                }
<<<<<<< HEAD
=======

                if (input == "clear")
                {
                    Console.Clear();
                }


                if (comb == true)
                {
                    break;
                }

                


>>>>>>> 4ad409952bcdebc87047262041c53dac0de638e2
            }

<<<<<<< HEAD
            void krok()
            {

                string filePath = "C:\\Users\\PCnetz\\Desktop\\PRG\\RPG-OOP\\RPG OOP\\negr.txt";



=======
                string filePath = @"C:\\Users\\axolo\\Source\\Repos\\TheDzejkob\\RPG-OOP\\RPG OOP\\negr.txt";
>>>>>>> 4ad409952bcdebc87047262041c53dac0de638e2

                string[] lines = File.ReadAllLines(filePath);


                Random random = new Random();
                int randomIndex = random.Next(lines.Length);


                string selectedLine = lines[randomIndex];
                string[] parts = selectedLine.Split(';');
                double iD = double.Parse(parts[0]);
                string text = parts[1];
                player.Stepcounter++;

                Console.WriteLine(text);


                if (iD == 0.00)
                {

                }
                else if (iD == 1.01)
                {

                    Entity krysa = new Entity("Krysa", 4, 1, false, 5);
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
                        int vysledek = player.Coiny + enemy.Reward;
                        player.Coiny = vysledek;


                    }

                }
                else if (iD == 1.02)
                {

                    Entity Vlk = new Entity("Vlk", 6, 3, false, 8);
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
                        utek = true;
                        int vysledek = player.Coiny + enemy.Reward;
                        player.Coiny = vysledek;


                    }


                }
                else if (iD == 2.00)
                {
                    bool tra = true;
                    while (tra == true)
                    {
                        Console.WriteLine("Chceš začít obchodovat?");
                        Console.WriteLine("1 Ano, ukaž mi co nabízíš");
                        Console.WriteLine("2 Ne, momentálně obchodovat nechci");
                        string trad = Console.ReadLine();
                        while (tra == true)
                        {
                            if (trad == "1")
                            {
                                trade();
                                tra = false;
                            }
                            else if (trad == "2")
                            {
                                tra = false;
                            }
                            else
                            {

                            }
                        }
                    }

                    //Jsou 4h rano a mam v sobe 4ty kafe, miluju svuj zivot xD
                    // progress solidní ale kofein levels furt stejný
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
                        if (enemy.Hp > 0)
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
                            Random en_random = new Random();
                            return en_random.Next(100) < 20;
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
                    zacatek();
                }

                void trade()
                {
                    Console.WriteLine("--Itemy nabýzené traderem--");
                    Console.WriteLine("1 pro zakoupení topůrka za 5 Coinů");
                    Console.WriteLine("2 pro zakoupení čepele sekery za 3 Coiny");
                    Console.WriteLine("3 pro zakoupení obvazu za 10 Coinů");
                    Console.WriteLine("4 pro odchod");

                    string tradeRoz = Console.ReadLine();

                    if (tradeRoz == "1" && player.Coiny >= 5)
                    {
                        Item topurko = new Item("Topůrko", 0, 0, true, 4, 0);
                        player.Items.Add(topurko);
                        Console.WriteLine("Zakoupil jsi topůrko za 5 coinů, bylo ti přidáno do Inventáře");


                    }
                    if (tradeRoz == "1" && player.Coiny < 5)
                    {
                        Console.WriteLine("Nemáš dostatek Coinů");
                    }


                    if (tradeRoz == "2" && player.Coiny >= 3)
                    {
                        Item cepel = new Item("Čepel sekery", 0, 0, true, 2, 0);
                        player.Items.Add(cepel);
                        Console.WriteLine("Zakoupil jsi čepel sekery za 3 coiny, byla ti přidáno do Inventáře");

                    }
                    if (tradeRoz == "2" && player.Coiny < 3)
                    {
                        Console.WriteLine("Nemáš dostatek Coinů");
                    }


                    if (tradeRoz == "3" && player.Coiny >= 10)
                    {
                        Item obvaz = new Item("Obvaz", 0, 0, false, 0, 10);
                        player.Items.Add(obvaz);
                        Console.WriteLine("Zakoupil jsi obvaz za 10 Coinů, byl ti přidán do Inventáře ");

                    }
                    if (tradeRoz == "3" && player.Coiny < 10)
                    {
                        Console.WriteLine("Nemáš dostatek Coinů");
                    }

<<<<<<< HEAD
                }

            }
=======
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

            void trade()
            {
                bool trading = true;
                while (trading == true )
                {


                Console.WriteLine("--Itemy nabýzené traderem--");
                Console.WriteLine("1 pro zakoupení topůrka za 5 Míradongů");
                Console.WriteLine("2 pro zakoupení čepele sekery za 3 Míradogy");
                Console.WriteLine("3 pro zakoupení obvazu za 10 Míradongů");
                Console.WriteLine("4 pro odchod");

                string tradeRoz = Console.ReadLine();

                if (tradeRoz == "1" && player.Coiny >= 5)
                {
                    Item topurko = new Item("Topůrko", 0, 0, true, 4,0);
                    player.Items.Add(topurko);
                    Console.WriteLine("Zakoupil jsi topůrko za 5 Míradongů, bylo ti přidáno do Inventáře");


                }
                if (tradeRoz == "1" && player.Coiny < 5)
                {
                    Console.WriteLine("Nemáš dostatek Míradongů");
                }


                if (tradeRoz == "2" && player.Coiny >= 3)
                {
                    Item cepel = new Item("Čepel sekery", 0, 0, true, 2,0);
                    player.Items.Add(cepel);
                    Console.WriteLine("Zakoupil jsi čepel sekery za 3 Míradongy, byla ti přidáno do Inventáře");

                }
                if (tradeRoz == "2" && player.Coiny < 3)
                {
                    Console.WriteLine("Nemáš dostatek Míradongů");
                }


                if (tradeRoz == "3" && player.Coiny >= 10)
                {
                    Item obvaz = new Item("Obvaz", 0, 0, false,0, 10);
                    player.Items.Add(obvaz);
                    Console.WriteLine("Zakoupil jsi obvaz za 10 Míradongů, byl ti přidán do Inventáře ");

                }
                if (tradeRoz == "3" && player.Coiny < 10)
                {
                    Console.WriteLine("Nemáš dostatek Míradongů");
                }

                if (tradeRoz == "4"  )
                {
                        Console.WriteLine("Loučíš se s traderem");
                        trading = false;
                }

                }

            }
            
            //void crafting()
            //{
            //    Console.WriteLine("-crafting-");
            //    Console.WriteLine("Craftitelné předměty");
            //    Console.WriteLine("          ↓         ");
            //    Console.WriteLine("1 Pro sekirku");
            //    Console.WriteLine("2 Pro bandaze");
            //    string CraftRoz = Console.ReadLine();

            //    if (CraftRoz == "1" && player.Items.Contains(cepel) && player.Items.Contains(topurko))
            //    {
            //        player.Items.Remove(topurko, cepel);
            //        Item serika = new Item("Sekirka", 2, 0, true, 10, 0);
            //        player.Items.Add(serika);
            //    }
                

            //}



>>>>>>> 4ad409952bcdebc87047262041c53dac0de638e2
        }
    }
}
