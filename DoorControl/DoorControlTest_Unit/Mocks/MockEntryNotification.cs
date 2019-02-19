using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Test.Unit
{
    class MockEntryNotification : IEntryNotification
    {
        public bool WasEntryGranted { get; private set; } = false;
        public bool WasEntryDenied { get; private set; } = false;

        public void NotifyEntryDenied()
        {
            WasEntryDenied = true;
        }

        public void NotifyEntryGranted()
        {
            WasEntryGranted = true;
        }
    }
}
