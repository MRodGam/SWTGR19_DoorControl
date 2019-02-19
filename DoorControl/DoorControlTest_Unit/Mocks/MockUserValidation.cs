using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Test.Unit
{
    class MockUserValidation : IUserValidation
    {
        public bool WasRequestValidated { get; private set; } = false;
        
        public bool ValidateEntryRequest(int ID)
        {
            
            WasRequestValidated = true;
            return WasRequestValidated;
        }
    }
}
