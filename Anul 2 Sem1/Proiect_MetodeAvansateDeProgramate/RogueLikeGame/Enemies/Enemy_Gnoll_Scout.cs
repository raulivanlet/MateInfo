using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame.resources {
	public class Enemy_Gnoll_Scout : Enemy{



		//Initializators
		//==============
		public Enemy_Gnoll_Scout() {
			health = 100;
			damage = 15;
			attackSpeed = 3;
			movementSpeed = 2;
			id = Map.mapID.Enemy_Gnoll_Scout;
			Map.mapObjects[posX, posY] = id;
		}



		//Player Interactions
		//===================
		public void Attack(int dmg) {

		}
		

	}
}
