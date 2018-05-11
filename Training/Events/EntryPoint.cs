using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Events
{
    class EntryPoint
    {
        static int score = 0;

        public static void Main7()
        {
            Shooter shooter = new Shooter();
            shooter.ShotsFired += KilledEnemy;
            shooter.ShotsFired += AddScore;

            shooter.OnShoot();

            Console.ReadKey();
        }
        public static void KilledEnemy(object Sender, ShotsFiredEventArgs e)
        {
            var tempSender = Sender as Shooter;

            Console.WriteLine($"I killed an enemy! And my name is {tempSender.Name}");
            Console.WriteLine($"Time of kill is: {e.TimeOfKill}");
            Console.WriteLine($"my score is now {score}");
        }

       public static void AddScore(object sender, EventArgs e) 
       {
            score++;
       }

    }
}
