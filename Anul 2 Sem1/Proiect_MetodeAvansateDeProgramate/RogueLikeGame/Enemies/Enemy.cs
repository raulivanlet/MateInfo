using System;
using System.Drawing;

namespace RogueLikeGame {
	public class Enemy {

		

		//Stats
		public int health;
		public int damage;
		public int movementSpeed;
		public int attackSpeed;
		public int level;
		public int id;


		//private readonly int sight = 2;

		//Map Interaction
		public int posX;
		public int posY;



		//Initializators
		//==============
		public Enemy() {
			health = 100;
			damage= 10;
			movementSpeed = 2;
			attackSpeed = 2;
			level = 1;
			id = Map.mapID.Enemy_Rat;
			Random rnd = new Random();
			do {
				posX = rnd.Next(1, Map.size);
				posY = rnd.Next(1, Map.size);
			}
			while (!(Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY] && Map.mapBackground[posX, posY] <= Map.mapID.Tiles_End && Map.mapObjects[posX, posY] == 0));
			
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
