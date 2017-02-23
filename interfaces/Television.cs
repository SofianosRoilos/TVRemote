using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public Television(int volume = 0)
        {
            Volume = volume;
        }

        public void Off()
        {
            Console.WriteLine("The TV is On");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine("The TV volume is at {0}",Volume);
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine("The TV volume is at {0}", Volume);
        }
    }
}
