using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NUnit.Framework;

namespace Test.ECS.Legacy
{
    class TestLegacy
    {
        private global::ECS.Legacy.ECS uut;

        [SetUp]
        public void SetUp()
        {
            uut = new global::ECS.Legacy.ECS(25);
        }

        [Test]
        public void RunSelfTest_RunSelfTest_True()
        {
            Assert.That(uut.RunSelfTest,Is.True);
        }
        static void Main(string[] args)
        {

        }
    }
}
