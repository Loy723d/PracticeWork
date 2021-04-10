using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Division()
        {
            // Значення які будуть передані в метод
            double a = 12.6;
            double b = 4.2;
            //очікуваний результат
            double expected = 3;
            Operations object1 = new Operations();
            double actual = object1.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication()
        {
            // Значення які будуть передані в метод
            double a = 4.2;
            double b = 12.6;
            //очікуваний результат
            double expected = 52.92;
            Operations object2 = new Operations();
            double actual = object2.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }

    }

}
