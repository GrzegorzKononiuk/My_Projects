using Arkanoid.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arkanoid.UnitTests
{
    public class UnitTests
    {
        [Test]
        public void TestingMock()
        {

            var author = new Mock<IRectangleItem>();
            author.SetupGet(p => p.X).Returns(1);
            author.SetupGet(p => p.Y).Returns(2);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, author.Object.X);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(2, author.Object.Y);
        }


        [Test]
        public void TestingNUnit()
        {
            var a = new ViewModel.ArkanoidViewModel();


            var result = a.Test();


            NUnit.Framework.Assert.AreEqual("Helolo world!!", result);
        }

    }
}
