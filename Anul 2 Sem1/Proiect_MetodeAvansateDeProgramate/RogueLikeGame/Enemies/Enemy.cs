using System;
using System.Drawing;

namespace RogueLikeGame {
	public class Enemy {



		//Stats
		public int health;
		public int damage = 10;
		public int movementSpeed = 5;
		public int attackSpeed = 5;
		public int level = 1;

		//private readonly int sight = 2;

		//Map Interaction
		public readonly int posX;
		public readonly int posY;



		//Initializators
		//==============
		public Enemy() {
			health = 100;
			damage= 10;
			attackSpeed = 2;
			movementSpeed= 2;
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
			if (dmg >= health) {
				Player.AttackPlayer(damage, true, posX, posY);
				Map.mapObjects[posX, posY] = 0;
			}
			else {
				health -= dmg;
				Player.AttackPlayer(damage, false, posX, posY);
			}
		}


	}
}
