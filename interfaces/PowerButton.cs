using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class PowerButton : ICommand
    {
        IElectronicDevice Device;
        public PowerButton(IElectronicDevice device)
        {
            Device = device;
        }

        public void Execute()
        {
            Device.On(); 
        }

        public void Undo()
        {
            Device.Off();
        }

        /*public void VDown()
        {
            Device.VolumeDown();
        }

        public void VUp()
        {
            Device.VolumeUp();
        }*/
    }
}
