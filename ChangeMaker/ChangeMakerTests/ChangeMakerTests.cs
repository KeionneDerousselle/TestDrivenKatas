using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChangeMaker;
using NUnit.Framework;

namespace ChangeMakerTests
{
    [TestFixture]
    public class ChangeMakerTests
    {
        private static ChangeMakerController changeMaker;

        [Test]
        public void TestMakeChange()
        {
            double amount = 427.57;
            string change = "100's: 4, 50's:, 20's: 1, 10's:, 5's: 1, 1's: 2, .25's: 2, .10's:, .05's: 1, .01's: 2, ";
            string value = changeMaker.MakeChange(amount);

            Assert.AreEqual(change, value);
        }
    }
}
