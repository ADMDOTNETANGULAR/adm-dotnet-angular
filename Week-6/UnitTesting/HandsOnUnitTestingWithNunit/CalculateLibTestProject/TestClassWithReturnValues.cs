using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibTestProject
{
    internal class TestClassWithReturnValues
    {
        [Test]
        public void Test_Methods_With_ReturnString()
        {
            // Arrange
            string actual = "Hello, World!";
           
            // Assert
            Assert.AreEqual("hello,World", actual);
            Assert.That("hello,World", Is.EqualTo(actual).IgnoreCase, "The strings are not equal ignoring case.");
            Assert.That(actual,Does.Contain("World"), "The string does not contain 'World'.");
            Assert.That(actual, Does.StartWith("Hello"), "The string does not start with 'Hello'.");    
            Assert.That(actual, Does.EndWith("!"), "The string does not end with '!'.");
            Assert.That(actual, Does.Match(@"^Hello, World!$"), "The string does not match the expected pattern.");
            string str=null;
            Assert.That(str, Is.Null, "The string is not null.");
            str = "";
            Assert.That(str, Is.Empty, "The string is not empty.");
        }
        [Test]
        public void StringAssertionsTogether()
        {
            string result= "Hello, World!";
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Hello, World!"), "The strings are not equal.");
                Assert.That(result, Does.Contain("World"), "The string does not contain 'World'.");
                Assert.That(result, Does.StartWith("Hello"), "The string does not start with 'Hello'.");
                Assert.That(result, Does.EndWith("!"), "The string does not end with '!'.");
                Assert.That(result, Does.Match(@"^Hello, World!$"), "The string does not match the expected pattern.");
            });
        }
        //check with Array or List
        [Test]
        public void Test_Methods_With_ReturnArray()
        {
            // Arrange
            int[] actual = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            // Assert
            Assert.That(actual, Is.EqualTo(expected), "The arrays are not equal.");
            Assert.That(actual, Has.Length.EqualTo(5), "The array does not have the expected length.");
            Assert.That(actual, Does.Contain(3), "The array does not contain the expected value.");
            Assert.That(actual, Is.Not.Empty, "The array is empty.");
        }
        [Test]
        public void Test_Methods_With_ReturnList()
        {
            // Arrange
            List<int> actual = new List<int> { 1, 2, 3, 4, 5 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            // Assert
            Assert.That(actual, Is.EqualTo(expected), "The lists are not equal.");
            Assert.That(actual, Has.Count.EqualTo(5), "The list does not have the expected count.");
            Assert.That(actual, Does.Contain(3), "The list does not contain the expected value.");
            Assert.That(actual, Is.Not.Empty, "The list is empty.");
            Assert.That(actual,Is.All.GreaterThan(0), "All elements in the list are not greater than 0.");
        }
        [Test]
        public void IncrementCount_ReturnsIncrementedValue()
        {
            // Arrange
            CalculateLibrary.Calculate calculate = new CalculateLibrary.Calculate();
            calculate.Count = 0;
            // Act
            calculate.IncrementCount();
            // Assert
            Assert.AreEqual(1, calculate.Count, "Count should be incremented to 1.");
        }
    }
}
