// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("RPSキャラクタークラス");

Player player =new Player(100f,10f,5f);
Player enemy = new Player(110f, 11f, 4f);
Console.WriteLine("player" + player.Hp + "敵" + enemy.Hp);

player.Attack(enemy);
enemy.Attack(player);
Console.WriteLine("player"+player.Hp+"敵"+enemy.Hp);


bool battle = false;
while(!battle)
{

    Console.WriteLine("player" + player.Hp + "敵" + enemy.Hp);
if(player.Hp<=0||enemy.Hp<=0) battle = false;
}