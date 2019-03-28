using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicDeck.Tests.UnitTests
{
    class Basic
    {
        [Test]
        public void HelloYou()
        {
            var result = "Hello World";
            Assert.AreEqual("Hello World", result);
        }

        [Test]
        public void WhiteColourHorse()
        {
            var expected = "white";
            Assert.AreEqual("white", expected);
        }
    }
}
