using RogueLikeGame.resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Image = System.Drawing.Image;


namespace RogueLikeGame {
	public static class Map {


		//Graphics & Images
		public static Form form;
		private static readonly Image wallSewers = Image.FromFile("../../resources/Wall_sewers.png");
		private static readonly Image tileSewers = Image.FromFile("../../resources/Tile_sewers.png");
		private static readonly Image tileSewersGrass = Image.FromFile("../../resources/Tile_GrassSewers.png");
		private static readonly Image playerWarrior = Image.FromFile("../../resources/Player_Warrior.png");
		private static readonly Image enemyRat = Image.FromFile("../../resources/Enemy_Rat.png");
		private static readonly Image enemyGnollScout = Image.FromFile("../../resources/Enemy_GnollScout.png");
		private static readonly Image itemPotion = Image.FromFile("../../resources/Item_CrimsonPotion.png");




		//Sounds
		public static System.Windows.Media.MediaPlayer backgroundMusic = new System.Windows.Media.MediaPlayer();
		public static System.Windows.Media.MediaPlayer playerDeath = new System.Windows.Media.MediaPlayer();
		public static System.Windows.Media.MediaPlayer attackHit = new System.Windows.Media.MediaPlayer();
		public static System.Windows.Media.MediaPlayer attackMiss = new System.Windows.Media.MediaPlayer();



		//Debug UI
		private static string strHealth;
		private static string strDamage;
		private static string strPosX;
		private static string strPosY;
		private static string strTick;
		private static string strTime;

		//Map
		public static int gridSize = 50;
		public static int size = 10;
		private static int offsetX = 100;
		private static int offsetY = 100;
		public static int[,] mapBackground = new int[size, size];
		public static int[,] mapObjects = new int[size, size];

		//Enemys
		private static int tick;
		private static int time;
		private static readonly Random rnd = new Random();
		public static List<Enemy> enemis = new List<Enemy>();



		//=========================
		//===---Map-ID-Legend---===
		//=========================
		public static class mapID {
			//ID 0 <--> 99 Walkable
			public static int Tiles_Start = 0;
			public static int Tile_Sewers = 1;
			public static int Tile_Sewers_Grass = 2;
			public static int Tiles_End = 99;

			//ID 100 <--> 199 NonWalkable
			public static int Walls_Start = 100;
			public static int Wall_Sewers = 101;
			public static int Walls_End = 199;

			//ID 200 <--> 299 Enemys
			public static int Enemys_Start = 200;
			public static int Enemy_Rat = 201;
			public static int Enemy_Gnoll_Scout = 202;
			public static int Enemys_End = 299;

			//ID 300 <--> 399 Items
			public static int Items = 300;
			public static int Items_Sword = 301;
			public static int Items_Potion = 302;

			//ID 400 <--> 499 Player
			public static int Player = 400;
		}



		//Acess Map Creation
		//==================
		public static void Init(Form f1)
		{
			form = f1;
			tick = 0;
			time = 0;
			CreateMap();
			Player.CreatePlayer();

			Enemy_Rat rats;
			rats = new Enemy_Rat();
			enemis.Add(rats);
		}

		public static void CreateMap()
		{
			size = rnd.Next(6, 20);
			mapBackground = new int[size, size];
			mapObjects = new int[size, size];

			//Map Center Offset
			offsetX = (form.Width / 2) - ((size + 1) * (gridSize + 1) / 2);
			offsetY = (form.Height / 2) - ((size + 1) * (gridSize + 1) / 2);
			GenerateMap_Cube();

			string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			backgroundMusic.Open(new Uri(location + @"\MateInfo\Anul 2 Sem1\Proiect_MetodeAvansateDeProgramate\RogueLikeGame\resources\Music\Exploration_Theme.wav"));
			backgroundMusic.Position = new TimeSpan(0);
			backgroundMusic.Volume = 0.2;
			backgroundMusic.Play();

			playerDeath.Open(new Uri(location + @"\MateInfo\Anul 2 Sem1\Proiect_MetodeAvansateDeProgramate\RogueLikeGame\resources\Music\Sound_Death.wav"));
			playerDeath.Position = new TimeSpan(0);
			playerDeath.Volume = 0.2;

			attackHit.Open(new Uri(location + @"\MateInfo\Anul 2 Sem1\Proiect_MetodeAvansateDeProgramate\RogueLikeGame\resources\Music\Sound_Hit.wav"));
			attackHit.Position = new TimeSpan(0);
			attackHit.Volume = 0.2;

			attackMiss.Open(new Uri(location + @"\MateInfo\Anul 2 Sem1\Proiect_MetodeAvansateDeProgramate\RogueLikeGame\resources\Music\Sound_Miss.wav"));
			attackMiss.Position = new TimeSpan(0);
			attackMiss.Volume = 0.2;

		}



		//Timer and Ai Spawn & Logic
		//=====
		public static void Tick(int passedTime)
		{
			time += passedTime;
			tick += passedTime;

			for (int i = 0; i < enemis.Count; i++)
			{
				if (enemis[i].spottedPlayer && (System.Math.Abs(enemis[i].posX - Player.PosX) <= enemis[i].spotDistance) && (System.Math.Abs(enemis[i].posY - Player.PosY) <= enemis[i].spotDistance))
				{
					if (enemis[i].posX > Player.PosX)
						enemis[i].MoveX(-1);
					else if (enemis[i].posX < Player.PosX)
						enemis[i].MoveX(1);

					if (enemis[i].posY > Player.PosY)
						enemis[i].MoveY(-1);
					else if (enemis[i].posY < Player.PosY)
						enemis[i].MoveY(1);
				}


				if ((System.Math.Abs(enemis[i].posX - Player.PosX) <= enemis[i].spotDistance) || (System.Math.Abs(enemis[i].posY - Player.PosY) <= enemis[i].spotDistance))
				{
					enemis[i].spottedPlayer = true;
				}
			}


			if ((time % 20 == 0) && (time / 4 >= 1))
			{
				int type = rnd.Next(1, 3);
				for (int i = 0; i < rnd.Next(2); i++)
				{
					if (type == 1)
					{
						enemis.Add(new Enemy_Rat());
					}
					else if (type == 2)
					{
						enemis.Add(new Enemy_Gnoll_Scout());
					}
				}
			}
			form.Refresh();
		}



		//Draw the Map
		//==============
		//public static void
		public static void Draw(PaintEventArgs e)
		{
			strHealth = "Health:" + Player.Health.ToString();
			strDamage = "Damage:" + Player.Damage.ToString();
			strPosX = "PosX:" + Player.PosX.ToString();
			strPosY = "PosY:" + Player.PosY.ToString();
			strTick = "Tick:" + tick.ToString();
			strTime = "Time:" + time.ToString();

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{

					e.Graphics.DrawString(strHealth, new Font(System.Drawing.FontFamily.GenericSansSerif, 16), System.Drawing.Brushes.Black, 10, 10);
					e.Graphics.DrawString(strDamage, new Font(System.Drawing.FontFamily.GenericSansSerif, 16), System.Drawing.Brushes.Black, 150, 10);
					e.Graphics.DrawString(strPosX, new Font(System.Drawing.FontFamily.GenericSansSerif, 16), System.Drawing.Brushes.Black, 300, 10);
					e.Graphics.DrawString(strPosY, new Font(System.Drawing.FontFamily.GenericSansSerif, 16), System.Drawing.Brushes.Black, 400, 10);
					e.Graphics.DrawString(strTick, new Font(System.Drawing.FontFamily.GenericSansSerif, 16), System.Drawing.Brushes.Black, 500, 10);
					e.Graphics.DrawString(strTime, new Font(System.Drawing.FontFamily.GenericSansSerif, 16), System.Drawing.Brushes.Black, 600, 10);

					if (mapBackground[i, j] == mapID.Tile_Sewers)
						e.Graphics.DrawImage(tileSewers, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);

					if (mapBackground[i, j] == mapID.Tile_Sewers_Grass)
						e.Graphics.DrawImage(tileSewersGrass, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);

					if (mapBackground[i, j] == mapID.Wall_Sewers)
						e.Graphics.DrawImage(wallSewers, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);

					if (mapObjects[i, j] == mapID.Player)
						e.Graphics.DrawImage(playerWarrior, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);

					if (mapObjects[i, j] == mapID.Enemy_Rat)
						e.Graphics.DrawImage(enemyRat, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);

					if (mapObjects[i, j] == mapID.Enemy_Gnoll_Scout)
						e.Graphics.DrawImage(enemyGnollScout, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);
				}
			}
		}



		//Generate Map Types
		//==================
		private static void GenerateMap_Cube()
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
					{
						mapBackground[i, j] = mapID.Wall_Sewers;
					}
					else
					{
						mapBackground[i, j] = mapID.Tile_Sewers;
						int tmp = rnd.Next(8);
						if (tmp == 1)
							mapBackground[i, j] = mapID.Tile_Sewers_Grass;
					}
				}
			}
		}

		private static void GenerateMap_WeirdCube()
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
					{
						mapBackground[i, j] = 1;
					}
				}
			}
		}


	}
}
