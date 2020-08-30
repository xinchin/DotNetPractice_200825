using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyHelper.Tests
{
    [TestFixture]
    public class MyAssistantTest
    {
        [Test]
        public void Test_Add()
        {
            //Arrange
            int expectValue = 8;

            //Act
            int actualValue = MyAssistant.Add(3, 5);

            //Assert
            Assert.AreEqual(expectValue, actualValue);
        }

    }
}
