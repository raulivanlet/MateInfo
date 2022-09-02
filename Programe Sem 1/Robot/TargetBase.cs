namespace Robot {
   public abstract class TargetBase {

      //Abstract 

      //Virtual

      //Override

      private int health;
      public int Health { get; set; }

      public bool IsAlive { get; set; }

      public string Name { get; set; }

      public abstract void GetHitByLaser();
   }
}
