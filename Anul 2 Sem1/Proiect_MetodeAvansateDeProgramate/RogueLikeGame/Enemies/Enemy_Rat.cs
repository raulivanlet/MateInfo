﻿namespace RogueLikeGame {
	public class Enemy_Rat : Enemy {



		//Initializators
		//==============
		public Enemy_Rat()
		{
			level = Player.level;
			health = 6 + (2 * level);
			damage = 2;
			attackSpeed = 2;
			movementSpeed = 2;
			spottedPlayer = false;
			id = Map.mapID.Enemy_Rat;

			Map.mapObjects[posX, posY] = id;
		}

	}
}
