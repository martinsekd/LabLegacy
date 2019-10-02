using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NUnit.Framework;
using NSubstitute;
using NSubstitute.Core.Arguments;

namespace Test.ECS.Legacy
{
    [TestFixture]
    class TestLegacy
    {
        private ITempSensor uut1;
        IHeater uut2;
        private global::ECS.Legacy.ECS uut3;

        [SetUp]
        public void setup()
        {
            
            
        }

        /*[TestCase(3,3)]
        [TestCase(0, 0)]
        [TestCase(-5, -5)]
        public void GetTemp_setTempToa_b(int a, int b)
        {
            //uut1 = new FakeTempSensor(a);
            uut1 = Substitute.For<ITempSensor>();
            uut1.SetTemp(a);
            int temp = uut1.GetTemp();
            Assert.That(temp,Is.EqualTo(b));
        }

        [Test]
        public void TurnOn_turnOnHeater_true()
        {
            //uut2 = new FakeHeater();
            uut2 = Substitute.For<IHeater>();
            uut1 = Substitute.For<ITempSensor>();

            uut3 = new global::ECS.Legacy.ECS(25, uut2, uut1);

            uut1.GetTemp().Returns(20);

            uut3.Regulate();

            // Assert
            uut2.Received().TurnOn();

        }
        */
        [Test]
        public void TurnOn_turnOffHeater_false()
        {
            //uut2 = new FakeHeater();
            uut2 = Substitute.For<IHeater>();
            uut1 = Substitute.For<ITempSensor>();

            uut3 = new global::ECS.Legacy.ECS(20,uut2,uut1);


            Assert.That(uut2.RunSelfTest, Is.EqualTo(false));
        }

        [TestCase( 10)]
        [TestCase(20)]
        [TestCase(6)]
        [TestCase(5)]
        public void TurnOn_SetThresholdOverTempAndRegulate_TurnOnCalledOnce(int a)
        {
            //arrange
            uut2 = Substitute.For<IHeater>();
            uut1 = Substitute.For<ITempSensor>();
            uut3 = new global::ECS.Legacy.ECS(a, uut2, uut1);

            //act
            uut1.GetTemp().Returns(5);
            uut3.Regulate();

            //assert
            uut2.Received(1).TurnOn();
        }

        
        [TestCase(4)]
        [TestCase(0)]
        [TestCase(-1)]
        public void TurnOff_SetThresholdUnderTempAndRegulate_TurnOffCalledOnce(int a)
        {
            //arrange
            uut2 = Substitute.For<IHeater>();
            uut1 = Substitute.For<ITempSensor>();
            uut3 = new global::ECS.Legacy.ECS(a, uut2, uut1);

            //act
            uut1.GetTemp().Returns(5);
            uut3.Regulate();

            //assert
            uut2.Received(1).TurnOff();
        }

        [TestCase(-1)]
        public void RunSelfTest_HeaterFails_SelfTestFails(int a)
        {
            //arrange
            uut2 = Substitute.For<IHeater>();
            uut1 = Substitute.For<ITempSensor>();
            uut3 = new global::ECS.Legacy.ECS(a, uut2, uut1);

            //act
            uut1.RunSelfTest().Returns(true);
            uut2.RunSelfTest().Returns(true);

            //uut3.Regulate();

            //assert
            Assert.IsTrue(uut3.RunSelfTest());
        }

    }
}
