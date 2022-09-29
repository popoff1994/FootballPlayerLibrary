using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Xml.Linq;

namespace FootballPlayerTest
{
    [TestClass]
    public class FootballTest
    {
        [TestMethod]
        public void TestNameValidatorException()
        {
            //Arrange
            Class1 testName = new Class1(1, "b", 2, 2);
            //Act & Assert
            Assert.ThrowsException<ArgumentException>(testName.NameValidatior);

            //Arrange
            Class1 testName1 = new Class1(2, "bent", 3, 3);
            //Act
            testName1.NameValidatior();
            //Assert
            Assert.AreEqual(testName1.Name.Length > 2, "bent".Length > 2);
        }


        [TestMethod]
        public void TestAgeValidatorException()
        {
            //Arrange
            Class1 testName = new Class1(3, "b", -1, 4);
            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(testName.AgeValidator);

            //Arrange
            Class1 testName1 = new Class1(4, "bent", 5, 5);
            //Act
            testName1.AgeValidator();
            //Assert
            Assert.AreEqual(testName1.Age > 1 && testName1.Age < 120, 2 > 1 && 2 < 120);

        }
        [TestMethod]
        public void TestShirtNumberException()
        {
            //Arrange
            Class1 testName2 = new Class1(4, "bent", 6, -1);
            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(testName2.ShirtNumberValidator);
            
            //Arrange
            Class1 testName1 = new Class1(4, "bent", 5, 5);
            //Act
            testName1.ShirtNumberValidator();
            //Assert
            Assert.AreEqual(testName1.ShirtNumber > 0 && testName1.ShirtNumber < 100, 1 > 0 && 2 < 100);
        }

        void NameValidator()
        {
            throw new ArgumentException();
        }
    }
}