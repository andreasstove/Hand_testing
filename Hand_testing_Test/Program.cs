using Hand_testing;
using NUnit.Framework;
using System;

namespace Hand_testing_Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void AddUnderTest()
        {
            var uut = new Calculator();

            //uut.Add(1, 2);

            Assert.That(uut.Add(1, 2), Is.EqualTo(3));
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
}
