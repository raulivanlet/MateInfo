using System.Drawing;

namespace RogueLikeGame {
	public class Enemy_Rat : Enemy {



		//Initializators
		//==============
		public Enemy_Rat() {
			health= 100;
			damage= 10;
			attackSpeed = 2;
			movementSpeed = 2;
			id = Map.mapID.Enemy_Rat;

			Map.mapObjects[posX, posY] = id;
		}



		//Player Interactions
		//===================
		public void Attack(int dmg) {
			
		}

	}
}
