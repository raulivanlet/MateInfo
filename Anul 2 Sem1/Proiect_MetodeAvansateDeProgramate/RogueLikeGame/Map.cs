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

		//UI
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
		public static List<Enemy_Rat> enemies = new List<Enemy_Rat>();
		//public static List<Enemy> objects = new List<Enemy>();



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
			public static int Enemys_End = 299;

			//ID 300 <--> 399 Items
			public static int Items = 300;

			//ID 400 <--> 499 Player
			public static int Player = 400;
		}



		//Acess Map Creation
		//==================
		public static void Init(Form f1) {
			form = f1;
			tick = 0;
			time = 0;
			CreateMap();
			Player.CreatePlayer();

			Enemy_Rat rats;
			rats = new Enemy_Rat();
			enemies.Add(rats);
		}

		public static void CreateMap() {
			size = rnd.Next(6, 20);
			mapBackground = new int[size, size];
			mapObjects = new int[size, size];

			//Map Center Offset
			offsetX = (form.Width / 2) - ((size + 1) * (gridSize + 1) / 2);
			offsetY = (form.Height / 2) - ((size + 1) * (gridSize + 1) / 2);

			GenerateMap_Cube();
		}



		//Timer and Ai Spawn & Logic
		//=====
		public static void Tick(int passedTime) {
			time += passedTime;
			tick += passedTime;
			foreach (Enemy var in enemies) {
				int maxSpeed= var.Speed;
			}

			if (time % 100 == 0) {
				//int type = rnd.Next(2);
				int type = 1;
				//for (int i = 0; i < rnd.Next(size / 4, size / 2); i++) {

				for (int i = 0; i < rnd.Next(1, 2); i++) {

					if(type == 1) {
						Enemy_Rat rats;
						rats = new Enemy_Rat();
						enemies.Add(rats);
					}
					
				}
			}
			


			Map.form.Refresh();
		}



		//Draw the Map
		//==============
		//public static void
		public static void Draw(PaintEventArgs e) {
			strHealth = "Health:" + Player.Health.ToString();
			strDamage = "Damage:" + Player.Damage.ToString();
			strPosX = "PosX:" + Player.PosX.ToString();
			strPosY = "PosY:" + Player.PosY.ToString();
			strTick = "Tick:" + tick.ToString();
			strTime = "Time:" + time.ToString();
			

			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {

					e.Graphics.DrawString(strHealth, new Font(FontFamily.GenericSansSerif, 16), Brushes.Black, 10, 10);
					e.Graphics.DrawString(strDamage, new Font(FontFamily.GenericSansSerif, 16), Brushes.Black, 150, 10);
					e.Graphics.DrawString(strPosX, new Font(FontFamily.GenericSansSerif, 16), Brushes.Black, 300, 10);
					e.Graphics.DrawString(strPosY, new Font(FontFamily.GenericSansSerif, 16), Brushes.Black, 400, 10);
					e.Graphics.DrawString(strTick, new Font(FontFamily.GenericSansSerif, 16), Brushes.Black, 500, 10);
					e.Graphics.DrawString(strTime, new Font(FontFamily.GenericSansSerif, 16), Brushes.Black, 600, 10);

					if (mapBackground[i, j] == mapID.Tile_Sewers) {
						e.Graphics.DrawImage(tileSewers, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);
					}

					if (mapBackground[i, j] == mapID.Tile_Sewers_Grass) {
						e.Graphics.DrawImage(tileSewersGrass, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);
					}

					if (mapBackground[i, j] == mapID.Wall_Sewers) {
						e.Graphics.DrawImage(wallSewers, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);
					}

					e.Graphics.DrawImage(playerWarrior, (Player.PosX * gridSize) + offsetX, (Player.PosY * gridSize) + offsetY, gridSize, gridSize);

					if (mapObjects[i, j] == mapID.Enemy_Rat) {
						e.Graphics.DrawImage(enemyRat, (i * gridSize) + offsetX, (j * gridSize) + offsetY, gridSize, gridSize);
					}



				}

			}

		}



		//Generate Map Types
		//==================
		private static void GenerateMap_Cube() {
			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {
					if (i == 0 || i == size - 1 || j == 0 || j == size - 1) {
						mapBackground[i, j] = mapID.Wall_Sewers;
					}
					else {
						mapBackground[i, j] = mapID.Tile_Sewers;
						int tmp = rnd.Next(8);
						if (tmp == 1) {
							mapBackground[i, j] = mapID.Tile_Sewers_Grass;
						}
					}

				}
			}
		}

		private static void GenerateMap_WeirdCube() {
			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {
					if (i == 0 || i == size - 1 || j == 0 || j == size - 1) {
						mapBackground[i, j] = 1;
					}
				}
			}
		}


	}
}
