using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Test.Unit
{
    class MockAlarm : IAlarm
    {
        public bool WasAlarmCalled { get; private set; } = false;

        public void RaiseAlarm()
        {
            WasAlarmCalled = true;
        }
    }
}
