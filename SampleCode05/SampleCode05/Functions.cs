using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
	public class Functions
	{
		public static float CalcDamage(Character attacker, Character target)
		{
			//ダメージ計算
			float damage = attacker.AttackPoint - target.DefencePoint;
			if (damage < 1) damage = 1;
			return damage;
		}

		//1vs1バトル(現在使用していない)
		public static int Battle(Player player, Enemy enemy)
		{
			Console.WriteLine("戦闘開始！");
			int battleState = 0;
			while (battleState == 0)
			{
				//Enter押すまで処理を止める
				Console.ReadLine();

				//改善点:Attackメソッドの中でダメージ表示をコンソールに出す
				player.Attack(enemy);
				enemy.Attack(player);
				Console.WriteLine("プレイヤー:" + player.HP + ", 敵:" + enemy.HP);

				//勝敗判定
				if (player.HP <= 0)
					battleState = 2;
				else if (enemy.HP <= 0)
					battleState = 1;
				else
					battleState = 0;
			}
			return battleState;
		}

		public static int PartyBattle(List<Player> players, List<Enemy> enemies)
		{
			Random random = new Random();

			Console.WriteLine("戦闘開始！");
			int battleState = 0;
			while (battleState == 0)
			{
				//プレイヤーパーティーの攻撃
				for (int i = 0; i < players.Count; i++)
				{
					Player player = players[i];
					//死んでいたら攻撃できない
					if (player.HP <= 0)
						continue;

					int targetIndex = RequestTargetInput(player, enemies);
					Enemy targetEnemy = enemies[targetIndex];

					//敵が死んでいたら攻撃失敗
					if(targetEnemy.HP <= 0)
					{
						Console.WriteLine("敵" + targetIndex + "は倒れているため攻撃は失敗...");
						continue;
					}

					float damage = player.Attack(targetEnemy);
					Console.WriteLine(player.Name + "の攻撃! 敵" + targetIndex + "に" + damage + "のダメージ！");
					//敵を倒したか判定
					if (targetEnemy.HP <= 0)
						Console.WriteLine("敵" + targetIndex + "を倒した！");
				}

				//Enter押すまで処理を止める
				Console.ReadLine();

				//敵の攻撃
				for(int i = 0; i < enemies.Count; i++)
				{
					Enemy enemy = enemies[i];
					//死んでいたら攻撃できない
					if (enemy.HP <= 0)
						continue;


					//プレイヤーをランダムに攻撃
					int playerIndex = random.Next(players.Count);
					Player targetPlayer = players[playerIndex];

					//プレイヤーが死んでいたら攻撃失敗
					if(targetPlayer.HP <= 0)
					{
						Console.WriteLine(targetPlayer.Name + "は倒れているため攻撃は失敗...");
						continue;
					}

					float damage = enemy.Attack(targetPlayer);
					Console.WriteLine("敵" + i + "の攻撃! " + targetPlayer.Name + "に" + damage + "のダメージ！");

					//Enter押すまで処理を止める
					Console.ReadLine();
				}

				Functions.DisplayState(players, enemies);


				//勝敗判定
				if (CheckAnnihilation(players))
					battleState = 2;
				else if (CheckAnnihilation(enemies))
					battleState = 1;
				else
					battleState = 0;
			}
			return battleState;
		}

		private static int RequestTargetInput(Player player, List<Enemy> enemies)
		{
			string indices = "";
			for (int i = 0; i < enemies.Count; i++)
			{
				indices += i.ToString();
				if (i != enemies.Count - 1)
					indices += ", ";
			}
			Console.WriteLine(player.Name + "の攻撃先を選択してください(" + indices + ")");

			//攻撃先を選択させる
			int parsedIndex = -1;
			while(parsedIndex == -1)
			{
				string input = Console.ReadLine() ?? "";

				if(!int.TryParse(input, out parsedIndex))
				{
					Console.WriteLine("数値を入力してください");
					parsedIndex = -1;
					continue;
				}

				if(parsedIndex < 0 || parsedIndex >= enemies.Count)
				{
					Console.WriteLine("正しい攻撃先を選択してください");
					parsedIndex = -1;
					continue;
				}
			}
			return parsedIndex;
		}

		//全滅チェック
		private static bool CheckAnnihilation(List<Player> players)
		{
			foreach (Player player in players)
			{
				if (player.HP > 0)
					return false;
			}
			return true;
		}
		private static bool CheckAnnihilation(List<Enemy> enemies)
		{
			foreach (Enemy enemy in enemies)
			{
				if (enemy.HP > 0)
					return false;
			}
			return true;
		}

		public static Dictionary<CharacterJobs, string> JapaneseJobNames
			= new Dictionary<CharacterJobs, string>()
		{
				{CharacterJobs.Knight, "ナイト"},
				{CharacterJobs.Priest, "僧侶"},
				{CharacterJobs.Mage, "魔法使い"},
				{CharacterJobs.Warrior, "戦士"},
		};

		//現在のステータス画面を表示する
		public static void DisplayState(List<Player> playerParty,
			List<Enemy> enemyParty)
		{
			string[] PlayerParameters = new string[3];
			PlayerParameters[0] = "";
			PlayerParameters[1] = "";
			PlayerParameters[2] = "";

			for (int i = 0; i < playerParty.Count; i++)
			{
				PlayerParameters[0] += playerParty[i].Name + "\t";
				PlayerParameters[1] += playerParty[i].HP + "\t";
				PlayerParameters[2] += JapaneseJobNames[playerParty[i].Job] + "\t";
			}

			Console.WriteLine(PlayerParameters[0]);
			Console.WriteLine(PlayerParameters[1]);
			Console.WriteLine(PlayerParameters[2]);

			Console.WriteLine();
			string enemyInfo = "";
			for (int i = 0; i < enemyParty.Count; i++)
			{
				if(enemyParty[i].HP >= 0)
				enemyInfo += "敵" + i + "\t";
			}
			Console.WriteLine(enemyInfo);
		}
	}
}
