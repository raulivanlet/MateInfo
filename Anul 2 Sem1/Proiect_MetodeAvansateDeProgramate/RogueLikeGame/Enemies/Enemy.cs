using System;
using System.Drawing;

namespace RogueLikeGame {
	public class Enemy {

		//Images
		private static readonly Image image = Image.FromFile("../../resources/Enemy_Rat.png");

		//Stats
		private int health = 100;
		private readonly int damage = 10;
		private readonly int speed = 5;
		private static readonly int attackSpeed = 5;
		private readonly int sight = 2;

		//Map Interaction
		private readonly int posX;
		private readonly int posY;



		//Gett-ers
		//=========
		public int Health {
			get { return health; }
		}

		public int Speed {
			get { return speed; }
		}

		public int PosX {
			get { return posX; }
		}

		public int PosY {
			get { return posY; }
		}



		//Initializators
		//==============
		public Enemy() {
			Random rnd = new Random();
			do {
				posX = rnd.Next(1, Map.size);
				posY = rnd.Next(1, Map.size);
			}
			while (!(Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY] && Map.mapBackground[posX, posY] <= Map.mapID.Tiles_End && Map.mapObjects[posX, posY] == 0));
			Map.mapObjects[posX, posY] = Map.mapID.Enemy_Rat;
		}



		//Player Interactions
		//===================
		public void TakeDamage(int dmg) {
			if (dmg >= this.health) {
				Player.AttackPlayer(this.damage, true, posX, posY);
				Map.mapObjects[this.posX, this.posY] = 0;
			}
			else {
				this.health -= dmg;
				Player.AttackPlayer(this.damage, false, posX, posY);
			}
		}

		public void AttackPlayer() {
			if (Player.PosX == this.posX - 1 || Player.PosX == this.posX + 1) {
				if (Player.PosY == this.posY - 1 || Player.PosY == this.posY + 1) {
					Player.TakeDamage(this.damage);
				}
			}

			/*
			if (dmg >= this.health) {
				Player.AttackPlayer(this.damage, true, posX, posY);
				Map.mapObjects[this.posX, this.posY] = 0;
			}
			else {
				this.health -= dmg;
				Player.AttackPlayer(this.damage, false, posX, posY);
			}
			*/

		}

	}
}
