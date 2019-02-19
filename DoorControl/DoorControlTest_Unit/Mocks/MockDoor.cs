using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Test.Unit
{
    public class MockDoor : IDoor
    {
        public bool WasDoorOpened { get; private set; } = false;
        public bool WasDoorClosed { get; private set; } = false;


        public void Open()
        {
            WasDoorOpened = true;
        }

        public void Close()
        {
            WasDoorClosed = true;
        }

    }
}
