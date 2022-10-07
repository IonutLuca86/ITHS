// See https://aka.ms/new-console-template for more information


using System.Net.Security;
using System.Xml.Linq;


List<Player> playerLista = new List<Player>()
{  new Player("MonsterHunter", 1, 100),
   new Player("Merlin", 3, 90),
   new Player("Lancelot", 2, 80),
   new Player("King Arthur", 5, 100)
};
List<Monster> monsterLista = new List<Monster>()
{
    new Monster("Gargoil", 1, 80),
    new Monster("Dragon", 2, 100),
    new Monster("Wolf", 1, 50),
    new Monster("Giant snake", 3, 80),
    new Monster("Troll", 1, 100)
};
List<Villager> villagerLista = new List<Villager>()
{
    new Villager("Farmer", 1, 30),
    new Villager("Sheppard", 1, 30),
    new Villager("Trader", 1, 30)
};
Random rand = new Random();
int indexPlayer = rand.Next(playerLista.Count);
int indexMonster = rand.Next(monsterLista.Count);
int indexVillager = rand.Next(villagerLista.Count);
Game playGame = new Game();
playGame.GameAttack(playerLista[indexPlayer], monsterLista[indexMonster], villagerLista[indexVillager]);
abstract class Character
{
    public int startLevel, startlife;
    public int Strike;
    public abstract void Attack();
}
class Player : Character
{
    public string Name { get; set; }
    public override void Attack()
    {
        Console.WriteLine($"Have no fear! {this.Name} is here to help you!");
    }
    public Player(string name, int level, int life)
    {
        Name = name;
        startLevel = level;
        startlife = life;
        Strike = 10 * startLevel;
    }
}
class Monster : Character
{
    public string Type { get; set; }
    public Monster(string type, int level, int life)
    {
        Type = type;
        startLevel = level;
        startlife = life;
        Strike = 5 * startLevel;
    }
    public override void Attack()
    {
        Console.WriteLine($"GRRRR! {this.Type} want meat!");
    }
}
class Villager : Character
{
    public string Proffesion { get; set; }
    public Villager(string proffesion, int level, int life)
    {
        Proffesion = proffesion;
        startlife = life;
        startLevel = level;
    }
    public override void Attack()
    {
        Console.WriteLine($"Help me! I'm just a {this.Proffesion}. The monster is eating all my animals!!!");
    }
}
class Game
{
    public void GameAttack(Player player, Monster monster, Villager villager)
    {
        int temp;
        villager.Attack();
        monster.Attack();
        player.Attack();
        if (player.startlife > monster.startlife)
            temp = monster.startlife / 10;
        else
            temp = player.startlife / 10;
        for (int i = 1; i <= temp; i++)
        {
            Console.WriteLine($" {i} Round");
            monster.startlife -= player.Strike;
            Console.WriteLine($"{player.Name} hit {monster.Type}! The enemy has {monster.startlife} HP left!");
            if (monster.startlife <= 0)
            {
                Console.WriteLine($" {player.Name} has defeated the {monster.Type} ! Game over!");
                break;
            }
            player.startlife -= monster.Strike;
            Console.WriteLine($"{player.Name} was wounded and has {player.startlife} HP left.");
            if (player.startlife <= 0)
            {
                Console.WriteLine($" {player.Name} has been defeated by the {monster.Type}. Try again!");
                break;
            }
        }
    }
}