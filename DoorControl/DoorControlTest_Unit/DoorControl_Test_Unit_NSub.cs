using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using DoorControl;
using NUnit;
using NUnit.Framework;
using NSubstitute;

namespace DoorControl.Test.Unit
{
    [TestFixture]
    class DoorControl_Test_Unit_NSub
    {
        private DoorControl _uut;
        public IDoor _door;
        private IUserValidation _userValidation;
        private IEntryNotification _entryNotification;
        private IAlarm _alarm;

        [SetUp]
        public void Setup()
        {
            _door = Substitute.For<IDoor>();
            _userValidation = Substitute.For<IUserValidation>();
            _entryNotification = Substitute.For<IEntryNotification>();
            _alarm = Substitute.For<IAlarm>();

            _uut = new DoorControl(_door,_userValidation,_entryNotification,_alarm);
        }

        [Test]
        public void CheckIfValidated_ExpectedTrue()
        {
            _uut.RequestEntry(123);
            _userValidation.Received(1).ValidateEntryRequest(123);
        }

        [Test]
        public void CheckIfAlarmRaised_ExpectedTrue()
        {
            _uut.IsDoorOpen = false;
            _uut.DoorOpen();
            _alarm.Received(1).Equals(true);
        }
    }
}
