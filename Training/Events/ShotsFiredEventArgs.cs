using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Events
{
   

    public class ShotsFiredEventArgs : EventArgs
    {
        public DateTime TimeOfKill { get; set; }

        public ShotsFiredEventArgs() { }
      

        public ShotsFiredEventArgs(DateTime time)
        {
            this.TimeOfKill = time;
        }

    }
}
