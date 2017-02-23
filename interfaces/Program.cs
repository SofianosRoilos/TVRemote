using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powbut = new PowerButton(TV);
            powbut.Execute();
            powbut.Undo();
            Television vol = new Television(80);
            if (vol is IElectronicDevice)
            {
                vol.VolumeUp();
                vol.VolumeDown();
            }
            else
            {
                Console.WriteLine("isnt electronic device");
            }
           
           
            Console.ReadLine();
        }

        
    }
}
