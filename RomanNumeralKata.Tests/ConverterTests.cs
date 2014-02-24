using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RomanNumeralKata.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        private Converter converter;

        [SetUp]
        public void SetUp()
        {
            converter = new Converter();
        }

        [Test]
        public void IReturns1()
        {
            var actual = converter.Convert("I");
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void IIReturns2()
        {
            var actual = converter.Convert("II");
            Assert.That(actual, Is.EqualTo(2));
        }
    }
}
