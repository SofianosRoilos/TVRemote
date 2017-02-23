using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface ICommand
    {
        void Execute();
        void Undo();
        //void VUp();
        //void VDown();
        
    }
}
