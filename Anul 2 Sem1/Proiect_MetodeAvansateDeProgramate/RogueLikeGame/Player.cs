using System;
using System.Windows.Forms;

namespace RogueLikeGame {
	public static class Player {

		//Player Stats
		private static int health = 100;
		private static readonly int damage = 50;
		private static readonly int speed = 5;
		private static readonly int attackSpeed = 5;
		private static bool hasDied;

		//Player position
		private static int posX;
		private static int posY;



		//Getters & Setters
		//=========
		public static int Damage {
			get { return damage; }
			//set { damage = value; }
		}

		public static int Health {
			get { return health; }
		}

		public static int PosX {
			get { return posX; }
		}
		public static int PosY {
			get { return posY; }
		}



		//Initializators
		//==============
		public static void CreatePlayer() {
			hasDied = false;
			Random rnd = new Random();
			do {
				posX = rnd.Next(1, Map.size);
				posY = rnd.Next(1, Map.size);
			}
			while (!(Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY] && Map.mapBackground[posX, posY] <= Map.mapID.Tiles_End && Map.mapObjects[posX, posY] == 0));
			Map.mapObjects[posX, posY] = Map.mapID.Player;
		}



		//Player Interactions
		//===================
		private static void FightEnemy(int varx, int vary) {
			foreach (Enemy var in Map.enemies) {
				if (var.PosX == varx && var.PosY == vary) {
					var.TakeDamage(damage);
				}
			}
		}

		public static void TakeDamage(int dmg) {
			if (dmg >= health) {
				//Player.AttackPlayer(this.damage, true, posX, posY);
				//Map.mapObjects[this.posX, this.posY] = 0;
			}
			else {
				health -= dmg;
				//Player.AttackPlayer(this.damage, false, posX, posY);
			}
		}

		public static void AttackPlayer(int dmg, bool killedEnemy, int varX, int varY) {
			if (dmg >= health) {
				if (killedEnemy) {
					MessageBox.Show("You Have Traded With an Enemy");
				}
				else {
					MessageBox.Show("You Have Died");
				}
				hasDied = true;
			}
			else {
				health -= dmg;
				if (killedEnemy) {
					for (int i = 0; i < Map.enemies.Count; i++) {
						if (Map.enemies[i].PosX == varX && Map.enemies[i].PosY == varY)
							Map.enemies.RemoveAt(i);
					}
				}
			}
		}



		//========--Player-Movement--=======
		//==================================
		//						^
		//						|
		//					(PosY--)			
		//		<--(PosX--)		(PosX++)-->
		//					(PosY--)
		//		 				|
		//						v
		public static void MoveRight() {
			if (!hasDied) {
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX + 1, posY] && Map.mapBackground[posX + 1, posY] <= Map.mapID.Tiles_End) {
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX + 1, posY] && Map.mapObjects[posX + 1, posY] <= Map.mapID.Enemys_End) {
						FightEnemy(posX + 1, posY);
						Map.Tick(attackSpeed);
					}
					else {
						posX++;
						Map.Tick(speed);
					}
				}
			}
		}

		public static void MoveLeft() {
			if (!hasDied) {
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX - 1, posY] && Map.mapBackground[posX - 1, posY] <= Map.mapID.Tiles_End) {
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX - 1, posY] && Map.mapObjects[posX - 1, posY] <= Map.mapID.Enemys_End) {
						FightEnemy(posX - 1, posY);
						Map.Tick(attackSpeed);
					}
					else {
						posX--;
						Map.Tick(speed);
					}
				}
			}
		}

		public static void MoveUp() {
			if (!hasDied) {
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY - 1] && Map.mapBackground[posX, posY - 1] <= Map.mapID.Tiles_End) {
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX, posY - 1] && Map.mapObjects[posX, posY - 1] <= Map.mapID.Enemys_End) {
						FightEnemy(posX, posY - 1);
						Map.Tick(attackSpeed);
					}
					else {
						posY--;
						Map.Tick(speed);
					}
				}
			}
		}

		public static void MoveDown() {
			if (!hasDied) {
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY + 1] && Map.mapBackground[posX, posY + 1] <= Map.mapID.Tiles_End) {
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX, posY + 1] && Map.mapObjects[posX, posY + 1] <= Map.mapID.Enemys_End) {
						FightEnemy(posX, posY + 1);
						Map.Tick(attackSpeed);
					}
					else {
						posY++;
						Map.Tick(speed);
					}
				}
			}
		}



	}
}
