using Prog;

namespace тест_теста
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DivisionByZeroTest()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                int number = 0;
                int result = 100 / number;
            });
        }
        [Test]
        public void FormatExceptionTest()
        {
            Assert.Throws<FormatException>(() =>
            {
                int number = int.Parse("abc");
            });


        }
        [Test]
        public void CheckNumberTest()
        {
            double number = -1;
            Assert.Throws<CustomException>(() =>
            {
                
                double result = number;

            });


        }
    }
}