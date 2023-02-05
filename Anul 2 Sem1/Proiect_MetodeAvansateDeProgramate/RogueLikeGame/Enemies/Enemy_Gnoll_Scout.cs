namespace RogueLikeGame.resources {
	public class Enemy_Gnoll_Scout : Enemy {



		//Initializators
		//==============
		public Enemy_Gnoll_Scout()
		{
			level = Player.level;
			health = 8 + (2 * level);
			damage = 5;
			attackSpeed = 3;
			movementSpeed = 2;
			spottedPlayer = false;
			//spotDistance = 2;
			id = Map.mapID.Enemy_Gnoll_Scout;

			Map.mapObjects[posX, posY] = id;
		}

	}
}
