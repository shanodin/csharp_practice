using System;
using NUnit.Framework;

namespace Library
{

    [TestFixture]
    public class LibraryTest
    {
        Library library;
        [SetUp]
        public void Init()
        {
            library = new Library("Zonal Library", 10);
        }

        [Test]
        public void TestHasName()
        {
            Assert.AreEqual("Zonal Library", library.Name);
        }

        [Test]
        public void TestCapacity()
        {
            Assert.AreEqual(10, library.Capacity);
        }

        [Test]
        public void TestStartsEmpty()
        {
            Assert.AreEqual(0, library.ItemCount());
        }
    }
}
