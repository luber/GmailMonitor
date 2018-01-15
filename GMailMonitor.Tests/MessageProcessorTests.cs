using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GMailMonitor.Tests
{
    [TestClass]
    public class MessageProcessorTests
    {
        [TestMethod]
        public void MessageProcessorWillDetermineFlatNumberFromEmailSubjectWhenNoAssociatedFlatFoundTest()
        {
            var flatsRepoMock = new Mock<IFlatsRepository>();
            flatsRepoMock
                .Setup(fr => fr.FindFlatNumberBySender(It.IsAny<string>()))
                .Returns<string>(null);

            var messageProcessor = new MessageProcessor(flatsRepoMock.Object);

            var result = messageProcessor.Process(new DateTime(2018, 1, 9, 19, 13, 00), "mail1@gmail.com", "Квартира 159", "Доброго дня!\r\nТепло-40,450");

            flatsRepoMock.VerifyAll();

            Assert.AreEqual("159", result.FlatNumber);
            Assert.AreEqual(40.45, result.MeterReading);
        }

        [TestMethod]
        public void MessageProcessorWillDetermineFlatNumberFromEmailBodyWhenNoAssociatedFlatFoundTest()
        {
            var flatsRepoMock = new Mock<IFlatsRepository>();
            flatsRepoMock
                .Setup(fr => fr.FindFlatNumberBySender(It.IsAny<string>()))
                .Returns<string>(null);

            var messageProcessor = new MessageProcessor(flatsRepoMock.Object);

            var result = messageProcessor.Process(new DateTime(2018, 1, 2, 16, 17, 00), "mail2009@meta.ua", "Опалення Прізвище І.П.", "Показник 14,5 квартира 280 Прізвище І.П.");

            flatsRepoMock.VerifyAll();

            Assert.AreEqual("280", result.FlatNumber);
            Assert.AreEqual(14.5, result.MeterReading);
        }


        [TestMethod]
        public void MessageProcessorWillDetermineMeterReadingFromEmailBodyTest()
        {
            var flatsRepoMock = new Mock<IFlatsRepository>();
            flatsRepoMock
                .Setup(fr => fr.FindFlatNumberBySender(It.IsAny<string>()))
                .Returns<string>(null);

            var messageProcessor = new MessageProcessor(flatsRepoMock.Object);

            var result = messageProcessor.Process(new DateTime(2018, 1, 2, 16, 17, 00), "mail2009@meta.ua", "Опалення Прізвище С.В.", "Показник 14,5 квартира 280 Прізвище С.В.");

            flatsRepoMock.VerifyAll();

            Assert.AreEqual(14.5, result.MeterReading);
        }
    }
}
