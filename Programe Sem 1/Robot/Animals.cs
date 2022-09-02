namespace Robot {
   internal class Animals : TargetBase {

      public int Health {
         get {
            return Health;
         }
         set {
            if (Health <= 0) {
               IsAlive = false;
               Health = 0;
            }
         }
      }

      public bool IsAlive { get; set; }

      public string Name { get; set; }

      public static int AnimalCount { get; set; }

      public Animals() {
         Health = 100;
         IsAlive = true;
         AnimalCount++;
         Name = $"Animal{AnimalCount}";
      }

      public Animals(string name) {
         Health = 100;
         IsAlive = true;
         AnimalCount++;
         Name = name;
      }

      public override void GetHitByLaser() {
         Health = Health - 50;
         System.Console.WriteLine($"Animal {Name} was hit by laser. <Animal Sound!>");
      }

   }
}
