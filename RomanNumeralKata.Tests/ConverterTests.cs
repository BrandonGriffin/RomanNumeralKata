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
        [Test]
        public void IReturns1()
        {
            var converter = new Converter();
            var actual = converter.Convert("I");

            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
