using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MusicDeck.Models;

namespace MusicDeck.Tests.UnitTests
{
    class Music
    {
        [Test]
        public void GetMusic()
        {
            Models.Music music = new Models.Music();
            music.Id = 1;
            music.Name = "Despacito";
            music.Author = "Luis Fonsi";
            music.Album = "Vida";
            music.ReleaseDate = new DateTime(1516147200);
            music.Note = 5;
            Assert.AreEqual(1, music.Id);
            Assert.AreEqual("Despacito", music.Name);
            Assert.AreEqual("Luis Fonsi", music.Author);
            Assert.AreEqual("Vida", music.Album);
            Assert.AreEqual(1516147200, music.ReleaseDate.Ticks);
            Assert.AreEqual(5, music.Note);
        }
    }
}
