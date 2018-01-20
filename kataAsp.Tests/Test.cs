using NUnit.Framework;
using System;

namespace kataAsp.Tests {
    [TestFixture]
    public class Test {
        [Test]
        public void exampleSumTest() {
            var kataAsp = new kataAsp.Default();
            var sum = kataAsp.exampleSum();

            Assert.AreEqual(9, sum);
        }

        [Test]
        public void nashPrisonerTest() {
            var kataAsp = new kataAsp.Default();
            var result = kataAsp.nashPrisoner();
            var exampleClass = new exampleClass();
            Assert.AreEqual(exampleClass.property, "value");
        }
    }
}
