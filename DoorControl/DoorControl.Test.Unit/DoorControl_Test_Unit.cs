using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControl;
using NUnit;
using NUnit.Framework;

namespace DoorControl.Test.Unit
{
    [TestFixture]
    class DoorControl_Test_Unit
    {
        private DoorControl _uut;
        public MockDoor _door;
        private MockUserValidation _userValidation;
        private MockEntryNotification _entryNotification;
        private MockAlarm _alarm;

        [SetUp]
        public void SetUp()
        {
            _door = new MockDoor();
            _userValidation = new MockUserValidation();
            _entryNotification = new MockEntryNotification();
            _alarm = new MockAlarm();

            _uut = new DoorControl(_door, _userValidation,_entryNotification,_alarm );
        }

        [Test]
        public void RequestEntryCalled_ExpectedTrue()
        {
            _uut.RequestEntry(1);
            Assert.IsTrue(_userValidation.WasRequestValidated);
        }
    }
}
