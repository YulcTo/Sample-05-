using SampleCode05;


public class Program
{
	public static void Main(string[] args)
	{
		//ゲーム実行
		Play(); 
	}

	private static void Play()
	{
		//プレイヤーのパーティを生成
		List<Player> playerParty = new List<Player>();
		playerParty.Add(new Player("Aさん", 100f, 10f, 5f, CharacterJobs.Knight));
		playerParty.Add(new Player("Bさん", 90f, 5f, 10f, CharacterJobs.Warrior));
		playerParty.Add(new Player("Cさん", 60f, 15f, 0f, CharacterJobs.Mage));

		int battleState = 0;

		while (battleState != 2)
		{
			//敵パーティを生成
			List<Enemy> enemyParty = new List<Enemy>();
			enemyParty.Add(new Enemy(50f, 8f, 2f, 10, CharacterJobs.Warrior));
			enemyParty.Add(new Enemy(70f, 5f, 2f, 10, CharacterJobs.Warrior));
			enemyParty.Add(new Enemy(30f, 12f, 2f, 10, CharacterJobs.Warrior));

			Console.WriteLine("敵が現れた！");
			Functions.DisplayState(playerParty, enemyParty);

			//一旦Enterを押すまで待機する
			Console.ReadLine();
			
			battleState = 0;
			//0:バトル継続中 1:プレイヤーが勝った 2: 敵が勝った
			battleState = Functions.PartyBattle(playerParty, enemyParty);

			if (battleState == 1)
				Console.WriteLine("プレイヤーの勝ち！");
			else
				Console.WriteLine("プレイヤーの負け...");

			Console.WriteLine("バトル終了");

			//改善点:バトルが終わったらプレイヤーのHPを一定量回復する
			//改善点:敵の経験値を得てプレイヤーがレベルアップしてパラメータが強化される
		}

		Console.WriteLine("ゲームオーバー");
	}
}

