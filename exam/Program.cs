using System;
using System.Collections.Generic;

class Enemy
{
    public string Name;
    public int Power;
    public int X, Y;
    public bool Defeated = false;

    public Enemy(string name, int power, int x, int y)
    {
        Name = name;
        Power = power;
        X = x;
        Y = y;
    }
}

class Resource
{
    public string Name;
    public int X, Y;

    public Resource(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }
}

class Hero
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
    public int Strength { get; set; } = 10;
    public int Health { get; set; } = 100;
    public int Stamina { get; set; } = 50;

    public void Move()
    {
        Console.Write("Enter direction (W/A/S/D): ");
        char ch = char.ToUpper(Console.ReadKey().KeyChar);
        switch (ch)
        {
            case 'W': 
                Y--; 
                break;
            case 'A':
                X--;
                break;
            case 'S': 
                Y++; 
               break;
            case 'D': 
                X++;
                break;
        }
    }

    public void Fight(Enemy enemy)
    {
        Console.WriteLine($"Fighting {enemy.Name}");
        if (Strength > enemy.Power)
        {
            Console.WriteLine("You won");
            enemy.Defeated = true;
        }
        else
        {
            Console.WriteLine("You lost Health decreased");
            Health -= 20;
            if (Health <= 0)
            {
                Console.WriteLine("Game Over");
                return; 
            }
        }
        Console.ReadKey();
    }

    public void Collect(Resource resource)
    {
        Console.WriteLine($"Collected {resource.Name}");
        Console.ReadKey();
    }

    public bool HasDefeatedAllBosses(List<Enemy> enemies)
    {
        return enemies.TrueForAll(e => e.Defeated);
    }
}



class Shop
{
    public void OpenShop(Hero player)
    {
        Console.WriteLine("Welcome to the shop! Available items:");
        Console.WriteLine("1. Sword (+5 Strength) - 12 gold");
        Console.WriteLine("2. Potion (+20 Health) - 7 gold");
        Console.Write("Choose an item or press any other key to exit: ");
        string choice = Console.ReadLine()!;

        if (choice == "1")
        {
            Console.WriteLine("You bought a Sword");
            player.Strength += 5; 
        }
        else if (choice == "2")
        {
            Console.WriteLine("You bought a Potion");
            player.Health += 20; 
        }
        else
        {
            Console.WriteLine("You left the shop");
        }

        Console.ReadKey();
    }
}

class Game
{
    static Hero player = new Hero();
    static List<Enemy> enemies = new List<Enemy>() { new Enemy("Dragon", 20, 4, 4), new Enemy("Monster", 10, 2, 2), new Enemy("Minotaur", 15, 4, 3) };
    static List<Resource> resources = new List<Resource>() { new Resource("Wood", 1, 3), new Resource("Gold", 2, 4) };
    static Shop shop = new Shop();

    

    static void DrawMap()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                if (player.X == x && player.Y == y) 
                    Console.Write("H ");
                else if (enemies.Exists(e => e.X == x && e.Y == y)) 
                    Console.Write("E ");
                else if (resources.Exists(r => r.X == x && r.Y == y)) 
                    Console.Write("R ");
                else 
                    Console.Write(". ");
            }
            Console.WriteLine();
        }
    }

    static void Interact()
    {
        foreach (var enemy in enemies)
        {
            if (player.X == enemy.X && player.Y == enemy.Y)
            {
                player.Fight(enemy);
                return;
            }
        }

        foreach (var resource in resources)
        {
            if (player.X == resource.X && player.Y == resource.Y)
            {
                player.Collect(resource);
                return;
            }
        }

        Console.WriteLine("Nothing to interact with");
        Console.ReadKey();
    }

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            DrawMap();
            Console.WriteLine($"Hero Position: ({player.X}, {player.Y}) Health: {player.Health} Stamina: {player.Stamina} Strength {player.Strength}");
            Console.WriteLine("1. Move (W - forward/A - right/S - backward/D - left)");
            Console.WriteLine("2. Interact");
            Console.WriteLine("3. Open Shop");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1": player.Move(); break;
                case "2": Interact(); break;
                case "3": shop.OpenShop(player); break;
                case "4": return;
            }

            if (player.HasDefeatedAllBosses(enemies))
            {
                Console.WriteLine("Congratulations! You have defeated all bosses and won the game");
                break;
            }
        }
    }
}

