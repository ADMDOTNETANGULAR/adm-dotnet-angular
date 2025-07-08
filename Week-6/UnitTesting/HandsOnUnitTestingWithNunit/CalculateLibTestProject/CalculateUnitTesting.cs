using NUnit.Framework;
using CalculateLibrary;
namespace CalculateLibTestProject
{
    [TestFixture]
    public class CalculateUnitTesting
    {
        private Calculate _calculate;
        [SetUp]
        public void Setup()
        {
            // This method is called before each test method is run.
            // You can use it to set up any necessary state or resources.
           // _calculate = new Calculate();
        }
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // This method is called once before any test methods are run.
            // You can use it to set up resources that are shared across all tests.
            Console.WriteLine("OneTimeSetup: This runs once before all tests.");
            _calculate = new Calculate();
        }
        //Wriring a test method to test the Add method
        [Test]
        public void Add_TwoPositiveIntegers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 15;
            // Act
            int actual = _calculate.Add(a, b);
            // Assert
            Assert.AreEqual(expected,actual);
        }
        //Writting a test method to test the Multiply method
        [Test]
        public void Multiply_TwoPositiveIntegers_ReturnsProduct()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 50;
            // Act
            int actual = _calculate.Multiply(a, b);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        //Writting a test method to test the IsEven method
        [Test]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            // Arrange
            int number = 4;
            // Act
            bool result = _calculate.IsEven(number);
            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        [Ignore("This test is ignored for demonstration purposes.")]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            // Arrange
            int number = 5;
            // Act
            bool result = _calculate.IsEven(number);
            // Assert
            Assert.IsFalse(result);
        }
        //Writting a test method to test the Divide method
        //Passing multiple test cases using TestCase attribute
        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(20, 4, 5)]
        [TestCase(15, 3, 15)]
        public void Divide_ValidInputs_ReturnsQuotient(int a, int b, int expected)
        {
            // Act
            int actual = _calculate.Divide(a, b);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TearDown]
        public void TearDown()
        {
            // This method is called after each test method is run.
            // You can use it to clean up any resources or state.
            Console.WriteLine("TearDown: This runs after each test.");
            _calculate = null; // Clean up the Calculate instance
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // This method is called once after all test methods have run.
            // You can use it to clean up resources that were shared across all tests.
            Console.WriteLine("OneTimeTearDown: This runs once after all tests.");
            _calculate = null; // Clean up the Calculate instance
        }
        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 10;
            int b = 0;
            // Act & Assert
            var ex = Assert.Throws<DivideByZeroException>(() => _calculate.Divide(a, b));
           // Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
        }


    }
}