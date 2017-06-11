using System;
using System.Collections.Generic;
using System.Drawing;
namespace MachiKoro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players?");
            int numberOfPlayer = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("did you say " + numberOfPlayer + " players?");
            Console.WriteLine("What's the name of the first player?");
			string fpName = Console.ReadLine();
			Console.WriteLine(string.Format("Hi {0}!",fpName));
            Console.ReadKey();
        }

        static void function1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            function2();
            Console.WriteLine("Hello");
        }

        static void function2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello");
        }

    }
	public class Game
    {
        public Game (List<Player> players)
        {
            Players = players;
        }
        public List<Player> Players { get; set; }
        public int CurentPlayerIndex { get; set; }

    }
	public class Player
    {
        public string Name { get; set; }
        public int LandmarkCount { get; set; }

        public int Money { get; set; } 

        public List<Card> Cards { get; set; }

        public bool CanRole2Dices { get; set; }
    }
	public enum SymbolType {cup, bread, gear, wheat, cow, boat, tower, apple, factory }
    public abstract class  Card
    {
        public string ID { get; set; }
        public int MatchNum { get; set; }
        public Color FaceColor { get; set; }
        public int Cost { get; set; }

        public SymbolType Symbol { get; set; }

        public abstract void PayRule();

    class Person
    {
        string Name { get; set; }
        int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayName(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("My name is " + Name);
        }

        public void DisplayAge()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I'm " + Age + " years old");
        }


    }

    }
  
}
