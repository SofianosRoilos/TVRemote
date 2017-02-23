using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Vol : IVolume
    {
        IElectronicDevice device;
        public Vol (IElectronicDevice device)
        {
            this.device = device;
        }

        public void VoDown()
        {
            device.VolumeDown();
        }

        public void VoUp()
        {
            device.VolumeUp();
        }
    }
}
