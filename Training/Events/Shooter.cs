using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.Events
{
    public class Shooter
    {
        // Event to be invoked upon successful kill
        

        public event EventHandler<ShotsFiredEventArgs> ShotsFired;

        public string Name { get; set; } = "Billy";

        private Random rng = new Random();

        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    //if(ShotsFired != null)
                    //{
                    //    ShotsFired.Invoke(this, new ShotsFiredEventArgs(DateTime.Now));
                    //}
                    //replace with
                    ShotsFired?.Invoke(this, new ShotsFiredEventArgs(DateTime.Now));
                }
                else
                {
                    Console.WriteLine("I Missed!");
                }
                Thread.Sleep(500);
            }
        }
    }
}
