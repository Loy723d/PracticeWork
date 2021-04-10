using ConsoleApp3;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Subtraction()
        {
            // �������� �� ������ ������� � �����
            double a = 4.4;
            double b = 12.4;
            //���������� ���������
            double expected = -8;
            Operations object1 = new Operations();
            double actual = object1.Subtraction(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Plus()
        {
            // �������� �� ������ ������� � �����
            double a = 4.4;
            double b = 12.4;
            //���������� ���������
            double expected = 16.8;
            Operations object2 = new Operations();
            double actual = object2.Plus(a, b);
            Assert.Equal(expected, actual);
        }


    }
}
