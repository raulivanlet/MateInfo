using System;
using System.Drawing;
using System.Windows.Forms;

namespace RogueLikeGame {
	public class Sword : Object {

		//Images
		public Image image;

		public int health = 100;
		public int damage = 100;

		//World Interaction
		public int id;
		public int posX;
		public int posY;

		//Initializators
		//==============
		public Sword() {
			//id = Map.enemies.Count;
			//this.image = img;
		}


		public void InitializeEnemy() {
			//InitStaticPosition();
			InitPosition();
			health = 100;
		}

		private void InitPosition() {
			Random rnd = new Random();

			do {
				posX = rnd.Next(1, Map.size);
				posY = rnd.Next(1, Map.size);
			}
			while (Map.mapBackground[posX, posY] != 0);

			Map.mapBackground[posX, posY] = 4;
		}


		//Player Interactions
		//===================
		public void Interact() {
			/*
			Map.mapBackground[this.posX, this.posY] = 0;
			Map.enemisRat.RemoveAt(0);
			MessageBox.Show("You picked up a sword.");
			*/

		}

	}
}
