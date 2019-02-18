using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorControl
    {
        public IDoor _door;
        public IEntryNotification _entryNotification;
        public IUserValidation _userValidation;
        public IAlarm _alarm;

        public bool IsDoorOpen { get; private set; } = false;
        public bool IsDoorBreached { get; private set; } = false;

        public DoorControl (IDoor door, IUserValidation userValidation, IEntryNotification entryNotification, IAlarm alarm)
        {
            _door = door;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
            _alarm = alarm;
        }

        public void RequestEntry(int ID)
        {
            if (_userValidation.ValidateEntryRequest(ID) == true)
            {
                _door.Open();
                _entryNotification.NotifyEntryGranted();
            }
            else
            {
                _entryNotification.NotifyEntryDenied();
            }
        }

        public void DoorOpen()
        {
            if (IsDoorOpen == true)
            {
                _door.Close();
            }
            else
            {
                _alarm.RaiseAlarm();
                IsDoorBreached = true;
            }
        }

        public void DoorClosed()
        {
            IsDoorOpen = false;
        }
    }
}
