using System;

namespace RogueLikeGame {
	public class Object {

		//Stats
		public int id;

		//Map Interaction
		public int posX;
		public int posY;



		//Initializators
		//==============
		public Object()
		{
			id = Map.mapID.Items;
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
		public void Interact()
		{
			/*Map.mapBackground[this.posX, this.posY] = 0;
			Map.enemyRat.RemoveAt(0);
			MessageBox.Show("You picked up a sword.");
			*/
		}
	}
}
