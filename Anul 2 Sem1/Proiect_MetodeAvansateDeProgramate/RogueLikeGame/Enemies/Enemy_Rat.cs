using System.Drawing;

namespace RogueLikeGame {
	public class Enemy_Rat : Enemy {

		//Images
		private static readonly Image image = Image.FromFile("../../resources/Enemy_Rat.png");

		//Stats
		private readonly int health = 100;
		private readonly int damage = 60;
		//private readonly int speed = 5;
		private readonly int sight = 2;

		//Map Interaction
		private readonly int posX;
		private readonly int posY;



		//Gett-ers
		//=========
		public int Health {
			get { return health; }
		}
		/*
		public int Speed {
			get { return speed; }
		}
		*/
		public int PosX {
			get { return posX; }
		}

		public int PosY {
			get { return posY; }
		}



		//Initializators
		//==============
		public Enemy_Rat() {
			//Map.mapID.Enemy_Rat = Map.mapID.Enemys_Start + id;

			/*
			do {
				//posX = rnd.Next(1, Map.size);
				//posY = rnd.Next(1, Map.size);
				
			}
			while (!((Map.mapID.Tiles_Start <= Map.mapBackground[posX, posY] && Map.mapBackground[posX, posY] <= Map.mapID.Tiles_End) && Map.mapObjects[posX, posY] == 0));
			Map.mapObjects[posX, posY] = Map.mapID.Enemy_Rat;
			*/

			/*
			bool semafor = true;
			while (semafor) {

				int tmp1 = rnd.Next(1, Map.size);
				int tmp2 = rnd.Next(1, Map.size);

				if ((Map.mapID.Tiles_Start <= Map.mapBackground[tmp1, tmp2] && Map.mapBackground[tmp1, tmp2] <= Map.mapID.Tiles_End)) {

					if (Map.mapObjects[tmp1, tmp2] == 0) {
						Map.mapObjects[tmp1, tmp2] = Map.mapID.Enemy_Rat;
						this.posX= tmp1;
						this.posY= tmp2;
						semafor = false;
					}

				}
			}
			*/


		}



		//Player Interactions
		//===================
		public void Attack(int dmg) {
			/*
			if (dmg >= this.health) {
				Player.Attack(this.damage, true);
				Map.mapObjects[this.posX, this.posY] = 0;
			}
			else {
				this.health -= dmg;
				Player.Attack(this.damage, false);
			}
			*/
		}









	}
}
