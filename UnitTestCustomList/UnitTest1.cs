using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

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

        [TestMethod]
        public void Add_CheckValueIndex12()
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
            int expectedResult8 = 8;
            int expectedResult9 = 9;
            int expectedResult10 = 10;
            int expectedResult11 = 11;
            int expectedResult12 = 12;
            int expectedResult13 = 13;

            //Act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            test.Add(expectedResult3);
            test.Add(expectedResult4);
            test.Add(expectedResult5);
            test.Add(expectedResult6);
            test.Add(expectedResult7);
            test.Add(expectedResult8);
            test.Add(expectedResult9);
            test.Add(expectedResult10);
            test.Add(expectedResult11);
            test.Add(expectedResult12);
            test.Add(expectedResult13);

            //Assert
            Assert.AreEqual(expectedResult13, test[12]);

        }

        [TestMethod]
        public void Remove_CheckAtIndex0()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(14);
            test.Add(10);
            int expectedResult = 10;

            //Act
            test.Remove(14);
            int actualResult = test[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Remove_CheckAtIndex2()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(10);
            test.Add(11);
            test.Add(12);
            test.Add(13);
            test.Add(14);
            int expectedResult = 13;

            //Act
            test.Remove(12);
            int actualResult = test[2];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_CheckAtIndex7()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(10);
            test.Add(11);
            test.Add(12);
            test.Add(13);
            test.Add(14);
            test.Add(15);
            test.Add(16);
            test.Add(17);
            test.Add(18);
            int expectedResult = 18;

            //Act
            test.Remove(17);
            int actualResult = test[7];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Remove_CheckAtIndex12()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(10);
            test.Add(11);
            test.Add(12);
            test.Add(13);
            test.Add(14);
            test.Add(15);
            test.Add(16);
            test.Add(17);
            test.Add(18);
            test.Add(19);
            test.Add(20);
            test.Add(21);
            test.Add(22);
            test.Add(23);
            int expectedResult = 23;

            //Act
            test.Remove(22);
            int actualResult = test[12];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfStringsCombineCorrectly()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> actualResult;
            CustomList<int> expectedResult = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);

            //Act
            actualResult = test1 + test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfStringsReduceCorrectly()
        {
            //subracting each number and the same indexes

            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> actualResult;
            CustomList<int> expectedResult = new CustomList<int>();
            test1.Add(4);
            test1.Add(5);
            test1.Add(6);
            test2.Add(1);
            test2.Add(2);
            test2.Add(3);
            expectedResult.Add(3);
            expectedResult.Add(3);
            expectedResult.Add(3);

            //Act
            actualResult = test1 - test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ConvertListToString()
        {
            CustomList<int> test1 = new CustomList<int>();
            //Arrange
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            string expectedValue = "1,2,3";
            //Act
            string actualValue = test1.ToString();
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
