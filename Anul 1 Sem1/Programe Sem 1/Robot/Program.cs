namespace Robot {
   internal class Program {
      static void Main() {
         GiantKillerRobot robot = new GiantKillerRobot();

         robot.Initialize();

         //robot.Target = {Animals, Humans, Superheroes}
         robot.Target(Animals, Humans, Superheroes);

         Animals animal = new Animals();
         animal.AnimalCount = 0;

         Planets earthCopy = new Planets();
         int earth = earthCopy.Health
         Planets earth = Planets.Earth;

         while (robot.Active && earth.Containslife) {
            if (robot.CurrentTarget.IsAlive)
               robot.FireLaserAt(robot.CurrentTarget);
            else
               robot.AquireNextTarget();
         }

      }
   }
}
