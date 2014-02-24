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

        [Test]
        public void VReturns5()
        {
            var actual = converter.Convert("V");
            Assert.That(actual, Is.EqualTo(5));
        }

        [Test]
        public void XReturns10()
        {
            var actual = converter.Convert("X");
            Assert.That(actual, Is.EqualTo(10));
        }

        [Test]
        public void LReturns50()
        {
            var actual = converter.Convert("L");
            Assert.That(actual, Is.EqualTo(50));
        }

        [Test]
        public void CReturns100()
        {
            var actual = converter.Convert("C");
            Assert.That(actual, Is.EqualTo(100));
        }

        [Test]
        public void DReturns500()
        {
            var actual = converter.Convert("D");
            Assert.That(actual, Is.EqualTo(500));
        }

        [Test]
        public void MReturns1000()
        {
            var actual = converter.Convert("M");
            Assert.That(actual, Is.EqualTo(1000));
        }

        [Test]
        public void VIReturns6()
        {
            var actual = converter.Convert("VI");
            Assert.That(actual, Is.EqualTo(6));
        }

        [Test]
        public void IVReturns4()
        {
            var actual = converter.Convert("IV");
            Assert.That(actual, Is.EqualTo(4));
        }

        [Test]
        public void XCIXReturns99()
        {
            var actual = converter.Convert("XCIX");
            Assert.That(actual, Is.EqualTo(99));
        }
    }
}
