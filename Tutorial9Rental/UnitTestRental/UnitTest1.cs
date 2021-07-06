using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tutorial9Rental;

namespace UnitTestRental
{
    [TestClass]
    public class UnitTest1
    {
        Rental rental;

        [TestInitialize]
        public void TestInitalize()
        {
            rental = new Rental();
        }

        [TestMethod]
        public void TestNoDay()
        { 
            Assert.AreEqual(0, rental.TotalPrice(-1, RentalType.Hatchback));
        }
        //test for Hatchback , $50
        [TestMethod]
        public void TestLessThenFiveDayHatchback()
        {
            Assert.AreEqual(200, rental.TotalPrice(4, RentalType.Hatchback));
        }

        [TestMethod]
        public void TestLessThenTenDayHatchback()
        {
            Assert.AreEqual(225, rental.TotalPrice(5, RentalType.Hatchback));
        }

        [TestMethod]
        public void TestLessThen20DayHatchback()
        {
            Assert.AreEqual(425, rental.TotalPrice(10, RentalType.Hatchback));
        }

        [TestMethod]
        public void TestMore20DayHatchback()
        {
            Assert.AreEqual(800, rental.TotalPrice(20, RentalType.Hatchback));
        }
        //test for Sedan , $80
        [TestMethod]
        public void TestLessThenFiveDaySedan()
        {
            Assert.AreEqual(320, rental.TotalPrice(4, RentalType.Sedan));
        }

        [TestMethod]
        public void TestLessThenTenDaySedan()
        {
            Assert.AreEqual(360, rental.TotalPrice(5, RentalType.Sedan));
        }

        [TestMethod]
        public void TestLessThen20DaySedan()
        {
            Assert.AreEqual(680, rental.TotalPrice(10, RentalType.Sedan));
        }

        [TestMethod]
        public void TestMore20DaySedan()
        {
            Assert.AreEqual(1280, rental.TotalPrice(20, RentalType.Sedan));
        }

        //test for Convertible , $100
        [TestMethod]
        public void TestLessThenFiveDayConvertible()
        {
            Assert.AreEqual(400, rental.TotalPrice(4, RentalType.Convertible));
        }

        [TestMethod]
        public void TestLessThenTenDayConvertible()
        {
            Assert.AreEqual(450, rental.TotalPrice(5, RentalType.Convertible));
        }

        [TestMethod]
        public void TestLessThen20DayConvertible()
        {
            Assert.AreEqual(850, rental.TotalPrice(10, RentalType.Convertible));
        }
        
        [TestMethod]
        public void TestMore20DayConvertible()
        {
            Assert.AreEqual(1600, rental.TotalPrice(20, RentalType.Convertible));
        }

        //test for Saloon, $120
        [TestMethod]
        public void TestLessThenFiveDaySaloon()
        {
            Assert.AreEqual(480, rental.TotalPrice(4, RentalType.Saloon));
        }

        [TestMethod]
        public void TestLessThenTenDaySaloon()
        {
            Assert.AreEqual(540, rental.TotalPrice(5, RentalType.Saloon));
        }

        [TestMethod]
        public void TestLessThen20DaySaloon()
        {
            Assert.AreEqual(1020, rental.TotalPrice(10, RentalType.Saloon));
        }

        [TestMethod]
        public void TestMore20DaySaloon()
        {
            Assert.AreEqual(1920, rental.TotalPrice(20, RentalType.Saloon));
        }
    }
}
