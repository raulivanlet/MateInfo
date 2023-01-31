using System;
using System.Linq;
using System.Windows.Forms;

namespace RogueLikeGame {
	public static class Player {

		//Player Stats
		private static int health;
		private static int damage;
		private static int speed;
		private static int attackSpeed;
		private static int id;
		public static int level;
		private static bool hasDied;

		//Player position
		private static int posX;
		private static int posY;



		//Getters & Setters
		//=========
		public static int Damage
		{
			get { return damage; }
			//set { damage = value; }
		}

		public static int Health
		{
			get { return health; }
		}

		public static int PosX
		{
			get { return posX; }
		}
		public static int PosY
		{
			get { return posY; }
		}



		//Initializators
		//==============
		public static void CreatePlayer()
		{
			health = 30;
			damage = 8;
			speed = 2;
			attackSpeed = 2;
			level = 1;
			id = Map.mapID.Player;
			hasDied = false;
			Random rnd = new Random();
			do
			{
				posX = rnd.Next(1, Map.size);
				posY = rnd.Next(1, Map.size);
			}
			while (!(Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY] && Map.mapBackground[posX, posY] <= Map.mapID.Tiles_End && Map.mapObjects[posX, posY] == 0));
			Map.mapObjects[posX, posY] = id;
		}



		//Player Interactions
		//===================
		private static void FightEnemy(int varx, int vary)
		{

			foreach (Enemy var in Map.enemis.ToList())
			{
				if (var.posX == varx && var.posY == vary)
					var.TakeDamage(damage);
			}
			Map.attackHit.Position = new TimeSpan(0);
			Map.attackHit.Play();

		}

		public static void AttackPlayer(int dmg, bool killedEnemy, int varX, int varY)
		{
			Map.attackHit.Position = new TimeSpan(0);
			Map.attackHit.Play();
			if (dmg >= health)
			{
				if (killedEnemy)
				{
					Map.mapObjects[posX, posY] = 0;
					Map.playerDeath.Play();
					MessageBox.Show("You Have Traded With an Enemy");
				}

				else
				{
					Map.mapObjects[posX, posY] = 0;
					Map.playerDeath.Play();
					MessageBox.Show("You Have Died");
				}

				health = 0;
				hasDied = true;
			}
			else
			{
				health -= dmg;
				if (killedEnemy)
				{
					for (int i = 0; i < Map.enemis.Count; i++)
						if (Map.enemis[i].posX == varX && Map.enemis[i].posY == varY)
							Map.enemis.RemoveAt(i);

					for (int i = 0; i < Map.enemis.Count; i++)
						if (Map.enemis[i].posX == varX && Map.enemis[i].posY == varY)
							Map.enemis.RemoveAt(i);
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
		public static void MoveRight()
		{
			if (!hasDied)
			{
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX + 1, posY] && Map.mapBackground[posX + 1, posY] <= Map.mapID.Tiles_End)
				{
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX + 1, posY] && Map.mapObjects[posX + 1, posY] <= Map.mapID.Enemys_End)
					{
						FightEnemy(posX + 1, posY);
						Map.Tick(attackSpeed);
					}
					else
					{
						Map.mapObjects[posX, posY] = 0;
						posX++;
						Map.mapObjects[posX, posY] = id;
						Map.Tick(speed);
					}
				}
			}
		}

		public static void MoveLeft()
		{
			if (!hasDied)
			{
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX - 1, posY] && Map.mapBackground[posX - 1, posY] <= Map.mapID.Tiles_End)
				{
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX - 1, posY] && Map.mapObjects[posX - 1, posY] <= Map.mapID.Enemys_End)
					{
						FightEnemy(posX - 1, posY);
						Map.Tick(attackSpeed);
					}
					else
					{
						Map.mapObjects[posX, posY] = 0;
						posX--;
						Map.mapObjects[posX, posY] = id;
						Map.Tick(speed);
					}
				}
			}
		}

		public static void MoveUp()
		{
			if (!hasDied)
			{
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY - 1] && Map.mapBackground[posX, posY - 1] <= Map.mapID.Tiles_End)
				{
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX, posY - 1] && Map.mapObjects[posX, posY - 1] <= Map.mapID.Enemys_End)
					{
						FightEnemy(posX, posY - 1);
						Map.Tick(attackSpeed);
					}
					else
					{
						Map.mapObjects[posX, posY] = 0;
						posY--;
						Map.mapObjects[posX, posY] = id;
						Map.Tick(speed);
					}
				}
			}
		}

		public static void MoveDown()
		{
			if (!hasDied)
			{
				if (Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY + 1] && Map.mapBackground[posX, posY + 1] <= Map.mapID.Tiles_End)
				{
					if (Map.mapID.Enemys_Start <= Map.mapObjects[posX, posY + 1] && Map.mapObjects[posX, posY + 1] <= Map.mapID.Enemys_End)
					{
						FightEnemy(posX, posY + 1);
						Map.Tick(attackSpeed);
					}
					else
					{
						Map.mapObjects[posX, posY] = 0;
						posY++;
						Map.mapObjects[posX, posY] = id;
						Map.Tick(speed);
					}
				}
			}
		}



	}
}
