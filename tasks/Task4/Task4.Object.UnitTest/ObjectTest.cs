using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Object.UnitTest
{
    [TestFixture]
    public class ObjectTest
    {
        [Test]
        public void TestName()
        {
            var name = "test1";
            Airplane a = new Airplane(10, name);
            Assert.AreEqual(a.Name, name);
        }

        [Test]
        public void TestSpeed()
        {
            var speed = 100;
            Airplane a = new Airplane();
            a.Speed = speed;
            Assert.AreEqual(a.Speed, speed);
        }

        [Test]
        public void TestLength()
        {
            var length = 100;
            Airplane a = new Airplane(length,"");            
            Assert.AreEqual(a.Length, length);
        }

        [Test]
        public void TestInFlyMode()
        {
            var flymode = true;
            Airplane a = new Airplane();
            a.TakeOf();            
            Assert.AreEqual(a.GetFlyStatus(), flymode);
        }

        [Test]
        public void TestNotInFlyMode()
        {         
            Airplane a = new Airplane();
            a.Land();
            Assert.AreEqual(a.GetFlyStatus(), false);
        }
        [Test]
        public void TestMaxPassagers()
        {
            var mypassgers = 100;
            Airplane a = new Airplane();
            a.MaxPassagers = mypassgers;
            Assert.AreEqual(a.MaxPassagers, mypassgers);
        }
        [Test]
        public void TestMaxFuel()
        {
            var maxFuel = 100;
            Airplane a = new Airplane();
            a.MaxFuel = maxFuel;
            Assert.AreEqual(a.MaxFuel, maxFuel);
        }
        [Test]
        public void TestMaxHeight()
        {
            var maxHeight = 100;
            Airplane a = new Airplane();
            a.Maxheight = maxHeight;
            Assert.AreEqual(a.Maxheight, maxHeight);
        }
    }
}
