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
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex0()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();  
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expectedResult = 1;

            //Act
            CustomList<int> actualResult = test1 + test2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult[0]);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expectedResult = 2;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex3()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expectedResult = 4;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[3];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex5()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expectedResult = 6;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[5];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AdditionOperator_CheckIfListsCombineCorrectlyAtIndex12()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            test1.Add(7);
            test1.Add(8);
            test1.Add(9);
            test2.Add(10);
            test2.Add(11);
            test2.Add(12);
            test2.Add(13);
            int expectedResult = 13;

            //Act
            test3 = test1 + test2;
            int actualResult = test3[12];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex0()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            int expectedResult = 0;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            test2.Add(10);
            test2.Add(12);
            int expectedResult = 12;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex1Again()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);
            test1.Add(7);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            int expectedResult = 7;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractOperator_CheckIfListsSubractCorrectlyAtIndex5()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test2.Add(5);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);                            
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            test2.Add(10);
            test2.Add(12);
            int expectedResult = 12;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[5];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToString_CheckIfCombinesCorrectly1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            string expectedValue = "123";

            //Act
            string actualValue = test1.ToString();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ToString_CheckIfCombinesCorrectly2()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);
            test1.Add(6);
            test1.Add(7);
            test1.Add(8);
            test1.Add(9);
            string expectedValue = "123456789";

            //Act
            string actualValue = test1.ToString();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_CheckAtIndex1()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            int expectedValue = 2;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[1];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_CheckAtIndex4()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            int expectedValue = 5;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[4];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_ListsOfDifferentSizesAtIndex7()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            int expectedValue = 8;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[7];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_ListsOfDifferentSizesAtIndex12()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            test2.Add(9);
            test2.Add(10);
            test2.Add(11);
            test2.Add(12);
            test2.Add(13);
            int expectedValue = 13;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[12];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Zip_ListsOfDifferentSizesAtIndex16()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(7);
            test2.Add(8);
            test2.Add(9);
            test2.Add(10);
            test2.Add(11);
            test2.Add(12);
            test2.Add(13);
            test2.Add(14);
            test2.Add(15);
            test2.Add(16);
            test2.Add(17);
            int expectedValue = 17;

            //Act
            test3 = test1.Zip(test2);
            int actualValue = test3[16];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
