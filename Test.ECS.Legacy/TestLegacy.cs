using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NUnit.Framework;

namespace Test.ECS.Legacy
{
    [TestFixture]
    class TestLegacy
    {
        private global::ECS.Legacy.ECS uut;
        [SetUp]
        public void Setup()
        {
            uut = new global::ECS.Legacy.ECS(10);
        }

        [Test]
        public void TEST_TEST_TEST()
        {
            Assert.That(0,Is.EqualTo(0));
        }
        static void Main(string[] args)
        {

        }
    }
}
