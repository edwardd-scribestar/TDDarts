using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDarts_Tests
{
    [TestFixture]
    class TDDartsTests
    {
        [Test]
        public void ShouldCreateMainWindow()
        {
            var game = new DartsGame();

            Assert.That(game.window.isVIsible(), Is.True);
        }
    }
}
