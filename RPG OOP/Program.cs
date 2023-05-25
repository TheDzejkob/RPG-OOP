using RPG_OOP.classy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Spectre.Console;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

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

            startScrean();
            void startScrean() 
            {
                AnsiConsole.Write(new FigletText("Text RPG")
            .Centered()
            .Color(Color.Red));
                // Create a list of Items
                var columns = new List<Text>(){
                new Text("                                      "),
                new Text("                                      "),
                new Text("Made by LedzGames",new Style(Color.Red, Color.Black)),
                };
                AnsiConsole.Write(new Columns(columns));

                // Asynchronous
                AnsiConsole.Status()
                    .Spinner(Spinner.Known.Noise)
                    .StartAsync("Načítání...", async ctx =>
                    {
                        Thread.Sleep(2000);
                    });

                Console.Clear();
            }


            jmeno();
            void jmeno() { 
            while (meno == "")
            {

                var name = AnsiConsole.Ask<string>("[italic green]Jak ti máme říkat dobrodruhu?[/]");
                meno = name;
                overeniMeno();

            }
            }
            void overeniMeno()
            {
                var overeni = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("Přeješ si být tedy nazíván/a " + meno + "?")
                    .PageSize(3)
                    .AddChoices(new[] {
                        "Ano", "Ne",
                    }));
                    if (overeni == "Ano")
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
                    if (player.Hp <= 0 || input == "exit") { smrt();}
                    


                if (input == "menu")
                    {
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
                        }
                    }
                    void staty() {
                        //Console.Clear();
                        //Console.WriteLine("Tvá postava");
                        //Console.WriteLine("-----------");
                        //Console.WriteLine("Jméno: " + player.Name);
                        //Console.WriteLine("Životy: " + player.Hp);
                        //Console.WriteLine("Počet kroků: " + player.Stepcounter);
                        //Console.WriteLine("Coiny: " + player.Coiny);

                        //Console.ReadLine();
                        var table = new Table();
                        table.AddColumn("Stat");
                        table.AddColumn("Hodnota");
                        table.AddRow("Jméno", ": " + player.Name);
                        table.AddRow("Životy", ": " + player.Hp);
                        table.AddRow("Kroky", ": " + player.Stepcounter);
                        table.AddRow("Coiny", ": " + player.Stepcounter);
                        table.Title("[bold orange1]Staty[/]");
                        table.Border = TableBorder.AsciiDoubleHead;
                        table.BorderColor(Color.Orange1);
                        table.Centered();
                        AnsiConsole.Write(table);


                    }

                    void inventory()
                    {
                        //if (player.Items.Count == 0)
                        //{
                        //    Console.WriteLine("Tvůj inventář: " + "Tvůj Inventář je prázdný");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("-Tvůj inventář-");
                        //    Console.WriteLine("       ↓      ");
                        //    for (int i = 0; i < player.Items.Count; i++)
                        //    {
                        //        Console.WriteLine(player.Items[i].Name);
                        //    }
                        //}
                        if (player.Items.Count == 0)
                        {
                            var panel = new Panel("Tvůj inventář je prázdný");
                            panel.Header = new PanelHeader("Inventář");
                            panel.Border = BoxBorder.Rounded;
                            panel.HeaderAlignment(Justify.Center);
                            AnsiConsole.Write(panel);
                        }
                        else

                            for (int i = 0; i < player.Items.Count; i++)
                        {

                            var panel = new Panel(player.Items[i].Name);
                            panel.Header = new PanelHeader("Inventář");
                            panel.Border = BoxBorder.Rounded;
<<<<<<< HEAD
                                panel.BorderColor(Color.Orange1);
=======
>>>>>>> parent of d7e1e3c (inv)
                            panel.HeaderAlignment(Justify.Center);
                            AnsiConsole.Write(panel);

                        }


                        Console.ReadLine();
                    }


                }
            }

            void smrt()
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
                Environment.Exit(0);

            }

            void krok()
            {

                string filePath = "C:\\Users\\axolo\\Source\\Repos\\TheDzejkob\\RPG-OOP\\RPG OOP\\negr.txt";




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
                        var trad = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("[underline yellow]Vyber akci kterou provedeš[/]")
                        .PageSize(4)
                        .AddChoices(new[] {
                            "Ano ukaž co nabýzíš", "Ne nemám zájem o obchodování"
                        }));

                        
                            if (trad == "Ano ukaž co nabýzíš")
                            {
                                trade();
                                tra = false;
                            }
                            else if (trad == "Ne nemám zájem o obchodování")
                            {
                                tra = false;
                            }
                            else
                            {
                                
                            }
                    }

                    //Jsou 4h rano a mam v sobe 4ty kafe, miluju svuj zivot xD
                    // progress solidní ale kofein levels furt stejný
                    // dalsi progress dalsi koment :D 
                }


                void combat()
                {
                    comb = true;


                    Console.WriteLine();
                    AnsiConsole.Write(new BarChart()
                    .Width(60)
                    .Label("[green bold underline]Životy[/]")
                    .CenterLabel()
                    .AddItem(player.Name, player.Hp, Color.Green)
                    .AddItem(enemy.Name,enemy.Hp, Color.Red));
                    Console.WriteLine();

                    var comba = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[underline yellow]Vyber akci kterou provedeš[/]")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "Základní útok", "Těžký útok","Pokus o útěk"
                    }));

                    if (enemy.Hp <= 0)
                    {
                        krok();
                    }
                    

                    if (comba == "Základní útok" && player.Hp >0)
                    {
                        int result1 = enemy.Hp - player.Dmg;
                        enemy.Hp = result1;
                        AnsiConsole.Write(new Markup("[green]Udělil jsi[/] " + player.Dmg + " [green]poškození nepříteli[/] " + enemy.Name));
                        Console.ReadLine();
                        if (enemy.Hp > 0)
                        {
                            enemyAtt();
                        }


                    }
                    if (comba == "Těžký útok" && heavy == false && player.Hp > 0)
                    {
                        Console.WriteLine("-----------------------------");
                        AnsiConsole.Write(new Markup("[red]Teď nemůžeš použít těžký útok[/]"));
                        Console.ReadLine();
                    }

                    if (comba == "Těžký útok" && heavy == true && player.Hp > 0)
                    {
                        heavy = false;
                        int result2 = (int)(enemy.Hp - (player.Dmg * player.Multiplier));
                        enemy.Hp = result2;
                        AnsiConsole.Write(new Markup("[green]Zasadil jsi nepříteli[/] " + enemy.Name + " [green]těžký úder[/] "));
                        Console.ReadLine();
                        if (enemy.Hp > 0)
                        {
                            enemyAtt();
                        }


                    }

                    if (comba == "Pokus o útěk" && utek == false && player.Hp > 0)
                    {
                        AnsiConsole.Write(new Markup("[red]O útěk jsi se již pokusil a nevyšlo to[/]"));
                        Console.ReadLine();

                    }

                    if (comba == "Pokus o útěk" && utek == true && player.Hp > 0)
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
                            AnsiConsole.Write(new Markup("[green]Povedlo se ti utéct[/]"));
                            Console.ReadLine() ;
                            enemy.Hp = 0;
                        }
                        if (sance == false)
                        {
                            Console.WriteLine("---------------------");
                            AnsiConsole.Write(new Markup("[red]Nepovedlo se ti utéct[/]"));
                            Console.ReadLine();
                            utek = false;
                        }


                    }

                }

                void enemyAtt()
                {

                    int result2 = player.Hp - enemy.Dmg;
                    player.Hp = result2;
                    AnsiConsole.Write(new Markup("[red]Nepřítel[/] " + enemy.Name + " [red]ti udělil[/] " + enemy.Dmg + " [red]poškození[/]"));
                    Console.ReadLine();

                }

                if (kro == true)
                {
                    zacatek();
                }

                void trade()
                {
                    bool trading = true;
                    while (trading == true) 
                    {

                        var table = new Table();
                        table.AddColumn(new TableColumn("Produkt"));
                        table.AddColumn(new TableColumn("Cena"));
                        table.AddRow("Topůrko","5 Coinů");
                        table.AddRow("Čepel","3 Coiny");
                        table.AddRow("Obvaz", "10 Coinů");
                        table.Title("[bold yellow]Obchodník[/]");
                        table.Border(TableBorder.AsciiDoubleHead);
                        table.BorderColor(Color.LightCyan1);
                        table.Centered();
                        AnsiConsole.Write(table);

                        var tradeRoz = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("[underline yellow]Vyber akci kterou provedeš[/]")
                        .PageSize(5)
                        .AddChoices(new[] {
                        "Zakoupit topůrko", "Zakoupit čepel","Zakoupit obvaz","Odchod"
                        }));

                    if (tradeRoz == "Zakoupit topůrko" && player.Coiny >= 5)
                    {
                        Item topurko = new Item("Topůrko", 0, 0, true, 4, 0);
                        player.Items.Add(topurko);
                        Console.WriteLine("Zakoupil jsi topůrko za 5 coinů, bylo ti přidáno do Inventáře");


                    }
                    if (tradeRoz == "Zakoupit topůrko" && player.Coiny < 5)
                    {
                        Console.WriteLine("Nemáš dostatek Coinů");
                    }


                    if (tradeRoz == "Zakoupit čepel" && player.Coiny >= 3)
                    {
                        Item cepel = new Item("Čepel sekery", 0, 0, true, 2, 0);
                        player.Items.Add(cepel);
                        Console.WriteLine("Zakoupil jsi čepel sekery za 3 coiny, byla ti přidáno do Inventáře");

                    }
                    if (tradeRoz == "Zakoupit čepel" && player.Coiny < 3)
                    {
                        Console.WriteLine("Nemáš dostatek Coinů");
                    }


                    if (tradeRoz == "Zakoupit obvaz" && player.Coiny >= 10)
                    {
                        Item obvaz = new Item("Obvaz", 0, 0, false, 0, 10);
                        player.Items.Add(obvaz);
                        Console.WriteLine("Zakoupil jsi obvaz za 10 Coinů, byl ti přidán do Inventáře ");

                    }
                    if (tradeRoz == "Zakoupit obvaz" && player.Coiny < 10)
                    {
                        Console.WriteLine("Nemáš dostatek Coinů");
                    }
                    if (tradeRoz == "Odchod")
                    {
                            trading = false;
                    }
                    }
                }

            }
        }
    }
}
