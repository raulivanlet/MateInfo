using System;

namespace RogueLikeGame {
	public class Sword : Object {




		//Initializators
		//==============
		public Sword()
		{
			id = Map.mapID.Items_Sword;
			Map.mapObjects[posX, posY] = id;
		}



		private void InitPosition()
		{
			Random rnd = new Random();
			do
			{
				posX = rnd.Next(1, Map.size);
				posY = rnd.Next(1, Map.size);
			}
			while (Map.mapBackground[posX, posY] != 0);
			Map.mapBackground[posX, posY] = 4;
		}

	}
}
