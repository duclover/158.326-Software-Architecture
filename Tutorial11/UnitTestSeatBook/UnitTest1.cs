using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tutorial11;

namespace UnitTestSeatBook
{
    [TestClass]
    public class UnitTest1
    {
        private Theatre _theatre;

        [TestInitialize]
        public void TestInitialize()
        {
            _theatre = new Theatre("MyName", "MyAddress");
            _theatre.ResetAllSeatsForNewShow();
        }

        [TestMethod]
        public void TestInitialEmptySeats()
        {
            bool isCompletelyVacant = _theatre.IsCompleteVacant;
            Assert.AreEqual(true, isCompletelyVacant);
        }

        [TestMethod]
        public void TestResetAllSeatsForNewShow()
        {
            int _currentVacantSeats = _theatre.CurrentVacantSeats;
            Assert.AreEqual(60, _currentVacantSeats);
        }

        [TestMethod]
        public void TestBookingOfMoreThan60SeatsMessage()
        {
            Assert.AreEqual("Booking cannt more than 60.", _theatre.PleaseBookSeats(61));
            //Assert.AreEqual("There is no enough seats.", _theatre.PleaseBookSeats(61));
        }

        [TestMethod]
        public void TestCompleteVacantIsTrueithIncorrectFirstBooking()
        {
            _theatre.PleaseBookSeats(1);
            Assert.AreEqual(59, _theatre.CurrentVacantSeats);
        }

        [TestMethod]
        public void TestBookingOf5Seats()
        {
            _theatre.PleaseBookSeats(5);
            int currentSeatNumber = _theatre.CurrentVacantSeats;
            Assert.AreEqual(55, currentSeatNumber);
        }

        [TestMethod]
        public void TestBookingDetailsOf3Seates()
        {
            //string booked = _theatre.PleaseBookSeats(3);
            //string lastBookedDetails = _theatre.DetailsOfLastBooking;
            //Assert.AreEqual(lastBookedDetails, booked);

            //_theatre.ResetAllSeatsForNewShow();
            string reply = _theatre.PleaseBookSeats(3);
            string message = "Booked 3 seats";
            Assert.AreEqual(message, reply);
            string lastBookedDetails = _theatre.DetailsOfLastBooking;
            Assert.AreEqual("A1 booked A2 booked A3 booked ", lastBookedDetails);
        }


        [TestMethod]
        public void TestCompleteVacantIsFalseWithCorrectFirstBooking()
        {
            //_theatre.PleaseBookSeats(1);
            //Assert.AreEqual(false, _theatre.IsCompleteVacant);
            //_theatre.ResetAllSeatsForNewShow();
            _theatre.PleaseBookSeats(1);
            Assert.AreEqual(false, _theatre.IsCompleteVacant);
            string message = "Booked 1 seats";
            Assert.AreEqual(message, _theatre.PleaseBookSeats(1));
        }

        [TestMethod]
        public void TestBookingMoreSeatsAfterAllSeatsHaveBeenBookedMessage()
        {
            //_theatre.PleaseBookSeats(60);
            //Assert.AreEqual("There is no enough seats.", _theatre.PleaseBookSeats(1));
            //_theatre.ResetAllSeatsForNewShow();
            string message = "Booked 60 seats";
            Assert.AreEqual(message, _theatre.PleaseBookSeats(60));
            Assert.AreEqual("There is no enough seats.", _theatre.PleaseBookSeats(1));
        }

        [TestMethod]
        public void TestBookingMoreSeatsWhenFewerSeatsAreRemainingMessage()
        {
            _theatre.PleaseBookSeats(55);
            Assert.AreEqual("There is no enough seats.", _theatre.PleaseBookSeats(6));
        }

        [TestMethod]
        public void TestVacantSeatsAfterAllSeateBooked()
        {
            _theatre.PleaseBookSeats(60);
            int currentSeatNumber = _theatre.CurrentVacantSeats;
            Assert.AreEqual(0, currentSeatNumber);
        }
    }
}
