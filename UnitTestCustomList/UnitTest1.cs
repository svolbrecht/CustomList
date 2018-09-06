using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCustomList
{
    [TestClass]
    public class UnitTest1
    {
        //use unit test that tests up to 12 additions and removing then check index 0.
        //minimum 25-30 tests written
        //5 for add, 5 for remove, 5 for overloading +, 5 for overloading -, 5 for zip.
        //this is bare minimum, should probably do more.
        //goal before weekend, have tests written and add possibly remove method completed.

        [TestMethod]
        public void Add_CheckIfCountIncreases()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult = 1;

            //Act
            test.Add(2);

            //Assert
            Assert.AreEqual(expectedResult, test.Count);
        }

       [TestMethod]
        public void Add_CheckValueIndex0()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult = 2;

            //Act
            test.Add(expectedResult);

            //Assert
            Assert.AreEqual(expectedResult, test[0]);

        }

        [TestMethod]
        public void Add_CheckValueIndex1()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;
            //Act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            //Assert
            Assert.AreEqual(expectedResult2, test[1]);

        }

        [TestMethod]
        public void Add_CheckValueIndex6()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;
            int expectedResult3 = 3;
            int expectedResult4 = 4;
            int expectedResult5 = 5;
            int expectedResult6 = 6;
            int expectedResult7 = 7;
   
            //Act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            test.Add(expectedResult3);
            test.Add(expectedResult4);
            test.Add(expectedResult5);
            test.Add(expectedResult6);
            test.Add(expectedResult7);

            //Assert
            Assert.AreEqual(expectedResult7, test[6]);

        }
    }
}
